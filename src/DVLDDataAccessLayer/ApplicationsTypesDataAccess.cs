using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationTypeData
    {
        public static DataTable GetAllApplicationsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT ApplicationTypeID AS 'ID',
                                    ApplicationTypeTitle AS 'Title',
	                                ApplicationFees AS 'Fees'
                                                    FROM ApplicationTypes                       ";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllApplicationsTypes");
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool UpdateApplicationType(int ID, string Title, float Fees)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update ApplicationTypes
                                    set ApplicationFees = @ApplicationFees,
                                        ApplicationTypeTitle =@ApplicationTypeTitle
                                                where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            Command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "UpdateApplicationType");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool GetApplicationTypeInfoByID(int ID, ref string Title, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Title = reader["ApplicationTypeTitle"] != DBNull.Value ? Convert.ToString(reader["ApplicationTypeTitle"]) : "";
                    Fees = reader["ApplicationFees"] != DBNull.Value ? Convert.ToSingle(reader["ApplicationFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetApplicationTypeInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddApplicationType(string Title, float Fees)
        {
            int ApplicationTypeID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                                VALUES (@ApplicationTypeTitle,@ApplicationFees);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);


            if (Title != "")
            {
                command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            }
            else
            {
                command.Parameters.AddWithValue("@ApplicationTypeTitle", System.DBNull.Value);
            }

            if (Fees >= 0)
            {
                command.Parameters.AddWithValue("@ApplicationFees", Fees);
            }
            else
            {
                command.Parameters.AddWithValue("@ApplicationFees", System.DBNull.Value);
            }

            try
            {
                Connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddApplicationType");
            }
            finally
            {
                Connection.Close();
            }
            return ApplicationTypeID;
        }

        public static bool DeleteApplicationType(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete ApplicationTypes
                                where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteApplicationType");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsApplicationTypeExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsDataAccessSettings.ErrorLogger(ex, "IsApplicationTypeExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

    }
}
