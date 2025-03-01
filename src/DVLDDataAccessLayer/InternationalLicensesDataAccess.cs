using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public class clsInternationalLicenseData
    {
        public static DataTable GetAllLicenses()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select  * From InternationalLicenses";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllLicenses");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static DataTable GetAllLicensesByPersonID(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT InternationalLicenses.*
                                    FROM InternationalLicenses INNER JOIN
                                        Drivers ON InternationalLicenses.DriverID = Drivers.DriverID INNER JOIN
                                        People ON Drivers.PersonID = People.PersonID
						                Where People.PersonID =@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllLicensesByPersonID");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }





        private static int _GetPersonIDByDriverID(int DriverID)
        {
            int UserID = -1;
            int PersonID = -1;
            clsDriverData.GetDriverInfoByID(DriverID, ref PersonID, ref UserID);
            return PersonID;
        }

        public static int AddNewLicense(int DriverID, int LocalLicenseID, int UserID)
        {
            int GeneralAppID = clsApplicationsData.AddApplication(_GetPersonIDByDriverID(DriverID), 6, UserID);
            int LicesneID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                                        VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", GeneralAppID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", DateTime.Now);
            Command.Parameters.AddWithValue("@ExpirationDate", DateTime.Now.AddYears(1));
            Command.Parameters.AddWithValue("@IsActive", true);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    LicesneID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewLicense");
            }
            finally
            {
                Connection.Close();
            }
            return LicesneID;
        }

        public static bool UpdateLicense(int LicenseID, bool IsActive)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update InternationalLicenses
                            set IsActive = @IsActive,
                            where InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", LicenseID > 0 ? LicenseID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateLicense");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool GetLicenseInfoByID(int LicenseID, ref int AppID, ref int DriverID, ref int LocalLicenseID, ref DateTime IssueDate, ref DateTime ExpDate, ref bool IsActive, ref int UserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    AppID = Reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["ApplicationID"]) : -1;
                    DriverID = Reader["DriverID"] != DBNull.Value ? Convert.ToInt32(Reader["DriverID"]) : -1;
                    LocalLicenseID = Reader["IssuedUsingLocalLicenseID"] != DBNull.Value ? Convert.ToInt32(Reader["IssuedUsingLocalLicenseID"]) : -1;
                    IssueDate = Reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(Reader["IssueDate"]) : DateTime.MinValue;
                    ExpDate = Reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(Reader["ExpirationDate"]) : DateTime.MinValue;
                    IsActive = Reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(Reader["IsActive"]) : false;
                    UserID = Reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["CreatedByUserID"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetLicenseInfoByLocalLicenseID(ref int LicenseID, ref int AppID, ref int DriverID, int LocalLicenseID, ref DateTime IssueDate, ref DateTime ExpDate, ref bool IsActive, ref int UserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From InternationalLicenses Where IssuedUsingLocalLicenseID = @LocalLicenseID AND IsActive = 1 AND GETDATE() < ExpirationDate\r\n";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    AppID = Reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["ApplicationID"]) : -1;
                    DriverID = Reader["DriverID"] != DBNull.Value ? Convert.ToInt32(Reader["DriverID"]) : -1;
                    LicenseID = Reader["InternationalLicenseID"] != DBNull.Value ? Convert.ToInt32(Reader["InternationalLicenseID"]) : -1;
                    IssueDate = Reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(Reader["IssueDate"]) : DateTime.MinValue;
                    ExpDate = Reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(Reader["ExpirationDate"]) : DateTime.MinValue;
                    IsActive = Reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(Reader["IsActive"]) : false;
                    UserID = Reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["CreatedByUserID"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseInfoByLocalLicenseID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }


        private static bool _GetGeneralApplicationIDByLicenseID(int LicenseID, ref int GeneralAppID)
        {
            int DriverID = -1;
            int LocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpDate = DateTime.MinValue;
            bool IsActive = false;
            int UserID = -1;

            return GetLicenseInfoByID(LicenseID, ref GeneralAppID, ref DriverID, ref LocalLicenseID, ref IssueDate, ref ExpDate, ref IsActive, ref UserID);
        }

        public static bool DeleteLicense(int ID)
        {
            int RowsAffected = 0;
            int GeneralAppID = -1;
            _GetGeneralApplicationIDByLicenseID(ID, ref GeneralAppID);
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteLicense");
            }
            finally
            {
                Connection.Close();
            }
            clsApplicationsData.DeleteApplication(GeneralAppID);
            return (RowsAffected > 0);
        }

        public static bool IsLicenseExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsLicenseExist");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsActiveLicenseExistByLocalLicense(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT Found = 1
                                FROM InternationalLicenses 
                                WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID 
                                        And ExpirationDate > GETDATE()
	                                    And IsActive = 1";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsActiveLicenseExistByLocalLicense");
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