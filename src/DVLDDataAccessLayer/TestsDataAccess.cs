using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestData
    {
        public static bool GetTestInfoByID(int ID, ref int AppointmentID, ref bool Result, ref string Notes, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@TestID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    AppointmentID = Reader["TestAppointmentID"] != DBNull.Value ? Convert.ToInt32(Reader["TestAppointmentID"]) : -1;
                    Notes = Reader["Notes"] != DBNull.Value ? Convert.ToString(Reader["Notes"]) : string.Empty;
                    Result = Reader["TestResult"] != DBNull.Value && Convert.ToBoolean(Reader["TestResult"]);
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
                clsDataAccessSettings.ErrorLogger(ex, "GetTestInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewTest(int AppointmentID, bool Result, string Notes, int UserID)
        {
            int TestID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID )
                                        VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", AppointmentID > 0 ? AppointmentID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@TestResult", Result);
            Command.Parameters.AddWithValue("@Notes", Notes != string.Empty ? Notes : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewTest");
            }
            finally
            {
                Connection.Close();
            }
            return TestID;
        }

        public static bool UpdateTest(int ID, int AppointmentID, bool Result, string Notes, int UserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Tests 
                                set TestAppointmentID = @TestAppointmentID,
                                    TestResult = @TestResult,
                                    Notes = @Notes,
	                            	CreatedByUserID = @CreatedByUserID
                                where TestID = @TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestID", ID);
            Command.Parameters.AddWithValue("@TestAppointmentID", AppointmentID > 0 ? AppointmentID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@TestResult", Result);
            Command.Parameters.AddWithValue("@Notes", Notes != string.Empty ? Notes : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateTest");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllTests()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Tests";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllTests");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool DeleteTest(int TestID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete Tests where TestID = @TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteTest");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsTestExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Tests WHERE TestID = @TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsTestExist");
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
