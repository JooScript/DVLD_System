using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref string Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT People.PersonID,
                                    People.NationalNo,
                                    People.FirstName ,
                                    People.SecondName ,
                                    People.ThirdName,
                                    People.LastName ,
                                    People.DateOfBirth ,
                                    CASE
                                    WHEN People.Gendor = '0' THEN 'Male'
                                    WHEN People.Gendor = '1' THEN 'Female'
                                    ELSE 'Unknown'
                                    END AS Gendor, 
                                    People.Address,
                                    People.Phone,
                                    People.Email,
                                    NationalityCountryID, 
                                    People.ImagePath
                                    FROM People 
										Where People.PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (string)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetPersonInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetPersonInfoByNationalNo(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref string Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT People.PersonID ,
                                    People.NationalNo,
                                    People.FirstName ,
                                    People.SecondName ,
                                    People.ThirdName,
                                    People.LastName ,
                                    People.DateOfBirth ,
                                    CASE
                                    WHEN People.Gendor = '0' THEN 'Male'
                                    WHEN People.Gendor = '1' THEN 'Female'
                                    ELSE 'Unknown'
                                    END AS Gendor, 
                                    People.Address,
                                    People.Phone,
                                    People.Email,
                                    NationalityCountryID, 
                                    People.ImagePath
                                    FROM People 
										Where People.NationalNo = @NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (string)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetPersonInfoByNationalNo");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, string Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;
            int InsertedID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                                Values (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                                Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (Gendor == "Male")
            {
                Command.Parameters.AddWithValue("@Gendor", 0);
            }
            else if (Gendor == "Female")
            {
                Command.Parameters.AddWithValue("@Gendor", 1);
            }
            else
            {
                Command.Parameters.AddWithValue("@Gendor", 2);
            }
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out InsertedID))
                {
                    PersonID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddNewPerson");
            }
            finally
            {
                Connection.Close();
            }
            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, string Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update People 
                            set NationalNo = @NationalNo,
							    FirstName = @FirstName,
								SecondName = @SecondName,
								ThirdName = @ThirdName,
                                LastName = @LastName, 
								DateOfBirth = @DateOfBirth,
								Gendor = @Gendor,
								Address = @Address, 
								Phone = @Phone, 
                                Email = @Email, 
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (Gendor == "Male")
            {
                Command.Parameters.AddWithValue("@Gendor", 0);
            }
            else if (Gendor == "Female")
            {
                Command.Parameters.AddWithValue("@Gendor", 1);
            }
            else
            {
                Command.Parameters.AddWithValue("@Gendor", 2);
            }
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdatePerson");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT People.PersonID AS 'Person ID',
                                    People.NationalNo AS 'National No',
                                    People.FirstName AS 'First Name',
                                    People.SecondName AS 'Second Name',
                                    People.ThirdName AS 'Third Name',
                                    People.LastName AS 'Last Name',
                                    People.DateOfBirth AS 'Date Of Birth',
                                    CASE
                                    WHEN People.Gendor = '0' THEN 'Male'
                                    WHEN People.Gendor = '1' THEN 'Female'
                                    ELSE 'Unknown'
                                    END AS Gendor, 
                                    People.Address,
                                    People.Phone,
                                    People.Email,
                                    Countries.CountryName AS 'Nationality', 
                                    People.ImagePath AS 'Image Path'
                                    FROM People INNER JOIN Countries
                                        ON People.NationalityCountryID = Countries.CountryID";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllPeople");
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeletePerson");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM People WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsPersonExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

    }
}