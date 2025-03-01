using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDriverData
    {
        public static bool GetDriverInfoByID(int DriverID, ref int PersonID, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = Reader["PersonID"] != DBNull.Value ? Convert.ToInt32(Reader["PersonID"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetDriverInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Drivers WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    DriverID = Reader["DriverID"] != DBNull.Value ? Convert.ToInt32(Reader["DriverID"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetDriverInfoByPersonID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewDriver(int PersonID, int UserID)
        {
            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Drivers (PersonID, CreatedByUserID )
                                        VALUES (@PersonID, @CreatedByUserID);
                                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID > 0 ? PersonID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewDriver");
            }
            finally
            {
                Connection.Close();
            }
            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int UserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Drivers
                                set PersonID = @PersonID,
	                            	CreatedByUserID = @CreatedByUserID
                                where DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID > 0 ? DriverID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@PersonID", PersonID > 0 ? PersonID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateDriver");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllDrivers()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT 
DriverID AS 'Driver ID',
PersonID AS 'Person ID',
NationalNo AS 'National No',
FullName AS 'Full Name',
CreatedDate AS 'Date',
NumberOfActiveLicenses AS 'Active Licenses'
FROM Drivers_View";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllDrivers");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool DeleteDriver(int DriverID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete Drivers where DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteDriver");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsDriverExist(int DriverID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Drivers WHERE DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsDriverExist");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsPersonADriver(int PersonID)
        {
            bool IsUser = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Drivers Where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsUser = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsUser = false;
                clsDataAccessSettings.ErrorLogger(ex, "IsPersonADriver");
            }
            finally
            {
                Connection.Close();
            }
            return IsUser;
        }

    }
}
