using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public class clsLicenseClassesData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT LicenseClassID AS 'ID',
                                    ClassName AS 'Name',
                                    ClassDescription AS 'Description',
                                    MinimumAllowedAge AS 'Min Age',
	                                DefaultValidityLength AS 'Default Validity Length',
	                                ClassFees AS 'Fees'
                                                FROM LicenseClasses";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllLicenseClasses");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool UpdateLicenseClass(int ID, string Name, string Description, int MinAge, int DefaultValidityLength, float Fees)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update LicenseClasses
                                    set ClassName = @ClassName,
                                        ClassDescription =@ClassDescription,
		                                MinimumAllowedAge = @MinimumAllowedAge,
				                        DefaultValidityLength = @DefaultValidityLength,
				                        ClassFees = @ClassFees
                                                where LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseClassID", ID);
            Command.Parameters.AddWithValue("@ClassName", Name);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", Fees);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateLicenseClass");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool GetLicenseClassInfoByID(int ID, ref string Name, ref string Description, ref int MinAge, ref int DefaultValidityLength, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    Name = reader["ClassName"] != DBNull.Value ? Convert.ToString(reader["ClassName"]) : "";
                    Description = reader["ClassDescription"] != DBNull.Value ? Convert.ToString(reader["ClassDescription"]) : "";
                    MinAge = reader["MinimumAllowedAge"] != DBNull.Value ? Convert.ToInt32(reader["MinimumAllowedAge"]) : -1;
                    DefaultValidityLength = reader["DefaultValidityLength"] != DBNull.Value ? Convert.ToInt32(reader["DefaultValidityLength"]) : -1;
                    Fees = reader["ClassFees"] != DBNull.Value ? Convert.ToSingle(reader["ClassFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseClassInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetLicenseClassInfoByName(string Name, ref int ID, ref string Description, ref int MinAge, ref int DefaultValidityLength, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ClassName", Name);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ID = reader["LicenseClassID"] != DBNull.Value ? Convert.ToInt32(reader["LicenseClassID"]) : -1;
                    Description = reader["ClassDescription"] != DBNull.Value ? Convert.ToString(reader["ClassDescription"]) : "";
                    MinAge = reader["MinimumAllowedAge"] != DBNull.Value ? Convert.ToInt32(reader["MinimumAllowedAge"]) : -1;
                    DefaultValidityLength = reader["DefaultValidityLength"] != DBNull.Value ? Convert.ToInt32(reader["DefaultValidityLength"]) : -1;
                    Fees = reader["ClassFees"] != DBNull.Value ? Convert.ToSingle(reader["ClassFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseClassInfoByName");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static float GetLicenseClassFeesByID(int ID)
        {
            bool IsFound = false;
            float Fees = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Fees = reader["ClassFees"] != DBNull.Value ? Convert.ToSingle(reader["ClassFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseClassFeesByID");
            }
            finally
            {
                Connection.Close();
            }
            if (IsFound)
            {
                return Fees;
            }
            return -1;
        }

        public static int GetLicenseClassDefaultValidityLengthByID(int ID)
        {
            bool IsFound = false;
            int DefaultValidityLength = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    DefaultValidityLength = Reader["DefaultValidityLength"] != DBNull.Value ? Convert.ToInt32(Reader["DefaultValidityLength"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseClassDefaultValidityLengthByID");
            }
            finally
            {
                Connection.Close();
            }
            if (IsFound)
            {
                return DefaultValidityLength;
            }
            return -1;
        }

        public static int AddLicenseClass(string Name, string Description, int MinAge, int DefaultValidityLength, float Fees)
        {
            int LicenseClassID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO LicenseClasses (ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees)
                                VALUES (@ClassName,@ClassDescription,@MinimumAllowedAge,@DefaultValidityLength,@ClassFees);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            if (Name != "")
            {
                Command.Parameters.AddWithValue("@ClassName", Name);
            }
            else
            {
                Command.Parameters.AddWithValue("@ClassName", System.DBNull.Value);
            }

            if (Description != "")
            {
                Command.Parameters.AddWithValue("@ClassDescription", Description);
            }
            else
            {
                Command.Parameters.AddWithValue("@ClassDescription", System.DBNull.Value);
            }

            if (MinAge >= 0)
            {
                Command.Parameters.AddWithValue("@MinimumAllowedAge", MinAge);
            }
            else
            {
                Command.Parameters.AddWithValue("@MinimumAllowedAge", System.DBNull.Value);
            }

            if (DefaultValidityLength >= 0)
            {
                Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            }
            else
            {
                Command.Parameters.AddWithValue("@DefaultValidityLength", System.DBNull.Value);
            }

            if (Fees >= 0)
            {
                Command.Parameters.AddWithValue("@ClassFees", Fees);
            }
            else
            {
                Command.Parameters.AddWithValue("@ClassFees", System.DBNull.Value);
            }

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    LicenseClassID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddLicenseClass");
            }
            finally
            {
                Connection.Close();
            }
            return LicenseClassID;
        }

        public static bool DeleteLicenseClass(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete LicenseClasses
                                    Where LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteLicenseClass");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsLicenseClassExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", ID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsLicenseClassExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
    }
}
