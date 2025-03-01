using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DataAccessLayer
{
    public class clsAppointmentData
    {
        public static bool GetAppointmentInfoByID(int ID, ref int TestTypeID, ref int LocalDrivingLicenseID, ref DateTime Date, ref float Fees, ref int UserID, ref bool IsLocked)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * From TestAppointments 
                                    Where TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    TestTypeID = Reader["TestTypeID"] != DBNull.Value ? Convert.ToInt32(Reader["TestTypeID"]) : -1;
                    LocalDrivingLicenseID = Reader["LocalDrivingLicenseApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["LocalDrivingLicenseApplicationID"]) : -1;
                    Date = Reader["AppointmentDate"] != DBNull.Value ? Convert.ToDateTime(Reader["AppointmentDate"]) : DateTime.Now;
                    Fees = Reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(Reader["PaidFees"]) : -1;
                    UserID = Reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["CreatedByUserID"]) : -1;
                    IsLocked = Reader["IsLocked"] != DBNull.Value && Convert.ToBoolean(Reader["IsLocked"]);
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAppointmentInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewAppointment(int TestTypeID, int LocalDrivingLicenseID, DateTime Date, float Fees, int UserID, bool IsLocked)
        {
            int AppointmentID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                                VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID > 0 ? TestTypeID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseID > 0 ? LocalDrivingLicenseID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@AppointmentDate", Date >= DateTime.Today ? Date : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@PaidFees", Fees > 0 ? Fees : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    AppointmentID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewAppointment");
            }
            finally
            {
                Connection.Close();
            }
            return AppointmentID;
        }

        public static bool UpdateAppointment(int ID, int TestTypeID, int LocalDrivingLicenseID, DateTime Date, float Fees, int UserID, bool IsLocked)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update TestAppointments 
                                    set TestTypeID = @TestTypeID,
                                        LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                        AppointmentDate = @AppointmentDate,
		                                PaidFees = @PaidFees,
		                                CreatedByUserID = @CreatedByUserID,
		                                IsLocked = @IsLocked
		                            where TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", ID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseID);
            Command.Parameters.AddWithValue("@AppointmentDate", Date);
            Command.Parameters.AddWithValue("@PaidFees", Fees);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateAppointment");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllAppointments(int LocalAppID, int TestTypeID)
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select TestAppointmentID AS 'ID' ,
                                    AppointmentDate AS 'Date', 
	                                PaidFees AS 'Fees',
	                                IsLocked AS 'Is Locked'
                            From TestAppointments
                            Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllAppointments");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool DeleteAppointment(int TestAppointmentID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete TestAppointments
                                where TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteAppointment");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsAppointmentActive(int LocalAppID, int TestTypeID)
        {
            bool IsOpen = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Found = 1 From TestAppointments Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 0";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsOpen = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsAppointmentActive");
                IsOpen = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsOpen;
        }

        public static bool IsTestPassed(int LocalAppID, int TestTypeID)
        {
            bool IsOpen = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT Found = 1
                                FROM TestAppointments INNER JOIN
                                                        Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND  TestTypeID = @TestTypeID AND TestResult = 1";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsOpen = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsOpenToRetakeAppointment");
                IsOpen = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsOpen;
        }

        public static bool IsPastAppointmentExist(int LocalAppID, int TestTypeID)
        {
            bool IsOpen = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT Found = 1
                                FROM TestAppointments INNER JOIN
                                                        Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND TestResult	= 0";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsOpen = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsPastAppointmentExist");
                IsOpen = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsOpen;
        }

        public static bool IsAppointmentExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsAppointmentExist");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

    }
}
