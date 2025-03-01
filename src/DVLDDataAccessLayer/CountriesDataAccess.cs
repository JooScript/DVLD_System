using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName, ref string Code, ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    CountryName = (string)reader["CountryName"];

                    if (reader["CountryCode"] != DBNull.Value)
                    {
                        Code = (string)reader["CountryCode"];
                    }
                    else
                    {
                        Code = "";
                    }

                    if (reader["CountryPhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)reader["CountryPhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }
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
                clsDataAccessSettings.ErrorLogger(ex, "GetCountryInfoByID");
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int ID, ref string Code, ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["CountryID"];

                    if (Reader["CountryCode"] != DBNull.Value)
                    {
                        Code = (string)Reader["CountryCode"];
                    }
                    else
                    {
                        Code = "";
                    }

                    if (Reader["CountryPhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)Reader["CountryPhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetCountryInfoByName");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewCountry(string CountryName, string Code, string PhoneCode)
        {
            int CountryID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Countries (CountryName,Code,PhoneCode)
                                VALUES (@CountryName,@Code,@PhoneCode);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            if (Code != "")
            {
                command.Parameters.AddWithValue("@Code", Code);
            }
            else
            {
                command.Parameters.AddWithValue("@Code", System.DBNull.Value);
            }

            if (PhoneCode != "")
            {
                command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            }
            else
            {
                command.Parameters.AddWithValue("@PhoneCode", System.DBNull.Value);
            }
            try
            {
                Connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CountryID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewCountry");
            }
            finally
            {
                Connection.Close();
            }
            return CountryID;
        }

        public static bool UpdateCountry(int ID, string CountryName, string Code, string PhoneCode)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Countries  
                            set CountryName=@CountryName,
                                Code=@Code,
                                PhoneCode=@PhoneCode
                                where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateCountry");
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Countries order by CountryName";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetAllCountries");
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool DeleteCountry(int CountryID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete Countries 
                                where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteCountry");
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool IsCountryExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Countries WHERE CountryID = @CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsCountryExist");
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsCountryExist(string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Countries WHERE CountryName = @CountryName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsCountryExist");
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