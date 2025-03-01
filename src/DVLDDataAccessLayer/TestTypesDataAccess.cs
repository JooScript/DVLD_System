using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestTypeData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT TestTypeID AS 'ID',
                                    TestTypeTitle AS 'Title',
                                    TestTypeDescription AS 'Description',
                                    TestTypeFees AS 'Fees'
                                                FROM TestTypes";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllTestTypes");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool UpdateTestType(int ID, string Title, string Description, float Fees)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update TestTypes
                                    set TestTypeFees = @TestTypeFees,
                                        TestTypeDescription =@TestTypeDescription,
		                                TestTypeTitle = @TestTypeTitle
                                                where TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", ID);
            Command.Parameters.AddWithValue("@TestTypeTitle", Title);
            Command.Parameters.AddWithValue("@TestTypeFees", Fees);
            Command.Parameters.AddWithValue("@TestTypeDescription", Description);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateTestType");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool GetTestTypeInfoByID(int ID, ref string Title, ref string Description, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    Title = reader["TestTypeTitle"] != DBNull.Value ? Convert.ToString(reader["TestTypeTitle"]) : "";
                    Description = reader["TestTypeDescription"] != DBNull.Value ? Convert.ToString(reader["TestTypeDescription"]) : "";
                    Fees = reader["TestTypeFees"] != DBNull.Value ? Convert.ToSingle(reader["TestTypeFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetTestTypeInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddTestType(string Title, string Description, float Fees)
        {
            int TestTypeID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees)
                                VALUES (@TestTypeTitle,@TestTypeDescription,@TestTypeFees);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            if (Title != "")
            {
                Command.Parameters.AddWithValue("@TestTypeTitle", Title);
            }
            else
            {
                Command.Parameters.AddWithValue("@TestTypeTitle", System.DBNull.Value);
            }

            if (Description != "")
            {
                Command.Parameters.AddWithValue("@TestTypeDescription", Title);
            }
            else
            {
                Command.Parameters.AddWithValue("@TestTypeDescription", System.DBNull.Value);
            }

            if (Fees >= 0)
            {
                Command.Parameters.AddWithValue("@TestTypeFees", Fees);
            }
            else
            {
                Command.Parameters.AddWithValue("@TestTypeFees", System.DBNull.Value);
            }

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    TestTypeID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddTestType");
            }
            finally
            {
                Connection.Close();
            }
            return TestTypeID;
        }

        public static int NumOfTestTypes()
        {
            int NumOfTestTypes = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select Count (*) From TestTypes";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    NumOfTestTypes = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddTestType");
            }
            finally
            {
                Connection.Close();
            }
            return NumOfTestTypes;
        }

        public static bool DeleteTestType(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete TestTypes
                                where TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", ID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteTestType");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsTestTypeExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM TestTypes WHERE TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsDataAccessSettings.ErrorLogger(ex, "IsTestTypeExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
    }
}
