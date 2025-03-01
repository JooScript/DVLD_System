using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace DataAccessLayer
{
    public class clsApplicationsData
    {
        public static DataTable GetAllApplications()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * From Applications";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllApplications");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool GetApplicationInfoByID(int ID, ref int PersonID, ref DateTime AppDate, ref int AppTypeID, ref string AppStatus, ref DateTime LastStatusDate, ref float Fees, ref int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = reader["ApplicantPersonID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicantPersonID"]) : -1;
                    AppDate = reader["ApplicationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ApplicationDate"]) : DateTime.MaxValue;
                    AppTypeID = reader["ApplicationTypeID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationTypeID"]) : -1;

                    if (Convert.ToInt32(reader["ApplicationStatus"]) == 1)
                    {
                        AppStatus = "New";
                    }
                    else if (Convert.ToInt32(reader["ApplicationStatus"]) == 2)
                    {
                        AppStatus = "Cancelled";
                    }
                    else if (Convert.ToInt32(reader["ApplicationStatus"]) == 2)
                    {
                        AppStatus = "Completed";
                    }
                    else
                    {
                        AppStatus = "???";
                    }

                    LastStatusDate = reader["LastStatusDate"] != DBNull.Value ? Convert.ToDateTime(reader["LastStatusDate"]) : DateTime.MaxValue;
                    UserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
                    Fees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetApplicationInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddApplication(int PersonID, int AppllicationTypeID, int UserID)
        {
            int ApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Applications(ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                                VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            string Title = string.Empty;
            float Fees = -1;
            clsApplicationTypeData.GetApplicationTypeInfoByID(AppllicationTypeID, ref Title, ref Fees);

            Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
            Command.Parameters.AddWithValue("@ApplicationTypeID", AppllicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", 1);
            Command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID);
            Command.Parameters.AddWithValue("@PaidFees", Fees);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "AddApplication");
            }
            finally
            {
                Connection.Close();
            }
            return ApplicationID;
        }

        public static bool DeleteApplication(int ID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete Applications
                                    Where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);

            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteApplication");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool CancelApplicationClass(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Applications
                                    set ApplicationStatus = 2,
	                                    LastStatusDate = GETDATE()
                                    where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "CancelApplicationClass");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool CompleteApplicationClass(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Applications
                                    set ApplicationStatus = 3,
	                                    LastStatusDate = GETDATE()
                                    where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "CompleteApplicationClass");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsApplicationExist(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsApplicationExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
    }
}