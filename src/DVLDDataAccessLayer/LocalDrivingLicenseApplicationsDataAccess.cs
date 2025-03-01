using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsData
    {
        public static DataTable GetAllApplications()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
Select  LocalDrivingLicenseApplicationID AS 'ID',
        ClassName AS 'Driving Class',
		NationalNo AS 'National No',
		FullName AS 'Full Name',
		ApplicationDate AS 'Date',
		PassedTestCount AS 'Passed Tests',
		Status AS 'Status'
From    LocalDrivingLicenseApplications_View";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DT.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetAllApplications");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static int AddNewApplication(int PersonID, int UserID, int LicenseClassID)
        {
            int AppID = clsApplicationsData.AddApplication(PersonID, 1, UserID);
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                                        VALUES (@ApplicationID,@LicenseClassID);
                                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", AppID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseApplicationID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewApplication");
            }
            finally
            {
                Connection.Close();
            }
            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateApplicationLicenseClass(int ID, int LicenseClassID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update LocalDrivingLicenseApplications
                                    set LicenseClassID = @LicenseClassID
                                    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateApplicationLicenseClass");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        private static int _GetPassesdTests(int ID)
        {

            int PassedTests = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT Count (*)
FROM            LocalDrivingLicenseApplications INNER JOIN
                         TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
Where  LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @AppID AND Tests.TestResult = 1";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AppID", ID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Tests))
                {
                    PassedTests = Tests;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "_GetPassesdTests");
            }
            finally
            {
                Connection.Close();
            }
            return PassedTests;
        }

        private static int _GetAllTestsTrials(int ID)
        {

            int PassedTests = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT Count (*)
FROM            LocalDrivingLicenseApplications INNER JOIN
                         TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
Where  LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @AppID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AppID", ID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Tests))
                {
                    PassedTests = Tests;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "_GetAllTestsTrials");
            }
            finally
            {
                Connection.Close();
            }
            return PassedTests;
        }

        public static int GetSpecificTestTrials(int AppID, int TestTypeID)
        {

            int PassedTests = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT Count (*)
FROM            LocalDrivingLicenseApplications INNER JOIN
                         TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
Where  LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @AppID AND TestAppointments.TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AppID", AppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Tests))
                {
                    PassedTests = Tests;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetSpecificTestTrials");
            }
            finally
            {
                Connection.Close();
            }
            return PassedTests;
        }

        public static bool GetApplicationInfoByID(int LocalAppID, ref int LicenseClassID, ref int PersonID, ref DateTime AppDate, ref int AppTypeID, ref string AppStatus, ref DateTime LastStatusDate, ref float Fees, ref int UserID, ref int PassedTests, ref int Trials)
        {
            bool IsFound = false;
            int AppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    AppID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : -1;
                    LicenseClassID = reader["LicenseClassID"] != DBNull.Value ? Convert.ToInt32(reader["LicenseClassID"]) : -1;
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsDataAccessSettings.ErrorLogger(ex, "GetApplicationInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            PassedTests = _GetPassesdTests(LocalAppID);
            Trials = _GetAllTestsTrials(LocalAppID);

            clsApplicationsData.GetApplicationInfoByID(AppID, ref PersonID, ref AppDate, ref AppTypeID, ref AppStatus, ref LastStatusDate, ref Fees, ref UserID);
            return IsFound;
        }

        public static bool GetLocalApplicationIDByGeneralAppID(int GeneralAppID, ref int LocalAppID)
        {
            bool IsFound = false;
            LocalAppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications
                                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", GeneralAppID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    LocalAppID = Reader["LocalDrivingLicenseApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["LocalDrivingLicenseApplicationID"]) : -1;
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsDataAccessSettings.ErrorLogger(ex, "GetLocalApplicationIDByGeneralAppID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetGeneralApplicationIDByLocalAppID(int LocalAppID, ref int GeneralAppID)
        {
            bool IsFound = false;
            GeneralAppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications
                                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    GeneralAppID = Reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["ApplicationID"]) : -1;
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsDataAccessSettings.ErrorLogger(ex, "GetGeneralApplicationIDByLocalAppID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool DeleteApplication(int ID)
        {
            int RowsAffected = 0;
            int GeneralAppID = -1;
            GetGeneralApplicationIDByLocalAppID(ID, ref GeneralAppID);
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete LocalDrivingLicenseApplications
                                Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteApplication");
            }
            finally
            {
                Connection.Close();
            }
            clsApplicationsData.DeleteApplication(GeneralAppID);
            return (RowsAffected > 0);
        }

        public static bool IsApplicationExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsApplicationExist");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsOpenToAddApp(string NationalNo, string ClassName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"   
Select LocalDrivingLicenseApplicationID
From LocalDrivingLicenseApplications_View 
Where NationalNo = @NationalNo AND ClassName = @ClassName AND Status != 'Cancelled'";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsOpenToAddApp");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return !IsFound;
        }

    }
}