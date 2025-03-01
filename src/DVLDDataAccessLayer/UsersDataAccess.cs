using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserData
    {
        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
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
                clsDataAccessSettings.ErrorLogger(ex, "GetUserInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            int InsertedID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Users(PersonID, UserName, Password, IsActive)
                                Values (@PersonID, @UserName, @Password, @IsActive);
                                Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out InsertedID))
                {
                    UserID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewUser");
            }
            finally
            {
                Connection.Close();
            }
            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Users
                                    set PersonID = @PersonID,
			                            UserName = @UserName,
			                            Password = @Password,
                                        IsActive =@IsActive
                                        where UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateUser");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT     Users.UserID AS 'User ID',
                                        Users.PersonID AS 'Person ID',
                                        (People.FirstName + ' '+ People.SecondName + ' '+ People.ThirdName + ' '+ People.LastName)as 'Full Name' ,
                                        Users.UserName,
                                        Users.IsActive AS 'Is Active'
                                        FROM People INNER JOIN  Users
                                            ON People.PersonID = Users.PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetAllUsers");
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteUser");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Users WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsUserExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Found = 1 FROM Users WHERE UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsUserExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static string GetPassword(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select Users.Password 
	                                From Users 
	                                    Where Users.UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            string Password = null;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    Password = Result.ToString();
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetPassword");
            }
            finally
            {
                Connection.Close();
            }
            return Password;
        }

        public static bool IsActive(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select Users.IsActive
	                                From Users 
	                                    Where Users.UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            bool IsActive = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Convert.ToBoolean(Result))
                {
                    IsActive = true;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "IsActive");
            }
            finally
            {
                Connection.Close();
            }
            return IsActive;
        }

        public static bool IsPersonAUser(int PersonID)
        {
            bool IsUser = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Users Where PersonID = @PersonID";
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
                clsDataAccessSettings.ErrorLogger(ex, "IsPersonAUser");
            }
            finally
            {
                Connection.Close();
            }
            return IsUser;
        }

        public static bool RememberChecking(bool Remember)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update RememberMe set Remember = @Remember";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Remember", Remember);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "RememberChecking");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsUserRememberd()
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Found = 1 FROM RememberMe WHERE Remember = 1";
            SqlCommand Command = new SqlCommand(Query, Connection);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsUserRememberd");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int GetUserID(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select Users.UserID
	                                From Users 
	                                    Where Users.UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            int UserID = -1;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    UserID = Convert.ToInt32(Result);
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetUserID");
            }
            finally
            {
                Connection.Close();
            }
            return UserID;
        }

    }
}