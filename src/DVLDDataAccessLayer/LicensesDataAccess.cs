using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsLicenseData
    {
        public static bool GetLicenseInfoByID(int ID, ref int AppID, ref int DriverID, ref int LicenseClassID, ref string Notes, ref float Fees, ref bool IsActive, ref int Reason, ref int UserID, ref DateTime Date, ref DateTime ExpDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Licenses Where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    AppID = Reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["ApplicationID"]) : -1;
                    Reason = Reader["IssueReason"] != DBNull.Value ? Convert.ToInt32(Reader["IssueReason"]) : -1;
                    DriverID = Reader["DriverID"] != DBNull.Value ? Convert.ToInt32(Reader["DriverID"]) : -1;
                    LicenseClassID = Reader["LicenseClass"] != DBNull.Value ? Convert.ToInt32(Reader["LicenseClass"]) : -1;
                    Notes = Reader["Notes"] != DBNull.Value ? Convert.ToString(Reader["Notes"]) : string.Empty;
                    Fees = Reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(Reader["PaidFees"]) : -1;
                    IsActive = Reader["IsActive"] != DBNull.Value && Convert.ToBoolean(Reader["IsActive"]);
                    UserID = Reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["CreatedByUserID"]) : -1;
                    Date = Reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(Reader["IssueDate"]) : DateTime.Now;
                    ExpDate = Reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(Reader["ExpirationDate"]) : DateTime.Now;
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

        public static bool GetLicenseInfoByGeneralAppID(ref int LicanseID, int AppID, ref int DriverID, ref int LicenseClassID, ref string Notes, ref float Fees, ref bool IsActive, ref int Reason, ref int UserID, ref DateTime Date, ref DateTime ExpDate)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Licenses Where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", AppID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    LicanseID = Reader["LicenseID"] != DBNull.Value ? Convert.ToInt32(Reader["LicenseID"]) : -1;
                    Reason = Reader["IssueReason"] != DBNull.Value ? Convert.ToInt32(Reader["IssueReason"]) : -1;
                    DriverID = Reader["DriverID"] != DBNull.Value ? Convert.ToInt32(Reader["DriverID"]) : -1;
                    LicenseClassID = Reader["LicenseClass"] != DBNull.Value ? Convert.ToInt32(Reader["LicenseClass"]) : -1;
                    Notes = Reader["Notes"] != DBNull.Value ? Convert.ToString(Reader["Notes"]) : string.Empty;
                    Fees = Reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(Reader["PaidFees"]) : -1;
                    IsActive = Reader["IsActive"] != DBNull.Value && Convert.ToBoolean(Reader["IsActive"]);
                    UserID = Reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["CreatedByUserID"]) : -1;
                    Date = Reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(Reader["IssueDate"]) : DateTime.Now;
                    ExpDate = Reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(Reader["ExpirationDate"]) : DateTime.Now;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetLicenseInfoByGenaralAppID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewLicense(int GeneralAppID, int DriverID, int LicenseClassID, string Notes, float Fees, bool IsActive, int Reason, int UserID)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass,ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                VALUES (@ApplicationID, @DriverID, @LicenseClass, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", GeneralAppID > 0 ? GeneralAppID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@DriverID", DriverID > 0 ? DriverID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID > 0 ? LicenseClassID : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@ExpirationDate", LicenseClassID > 0 ? DateTime.Now.AddYears(clsLicenseClassesData.GetLicenseClassDefaultValidityLengthByID(LicenseClassID)) : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@Notes", Notes != string.Empty ? Notes : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@PaidFees", Fees > 0 ? Fees : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", Reason > 0 ? Reason : (object)System.DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID > 0 ? UserID : (object)System.DBNull.Value);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LicenseID = InsertedID;
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
            return LicenseID;
        }

        public static bool UpdateLicense(int ID, int AppID, int DriverID, int LicenseClassID, string Notes, float Fees, bool IsActive, int Reason, int UserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Licenses 
                                set ApplicationID = @ApplicationID,
                                    DriverID = @DriverID,
                                    LicenseClass = @LicenseClass,
		                            PaidFees = @PaidFees,
		                            Notes = @Notes , 
							        IsActive = @IsActive,
						        	IssueReason = @IssueReason,
						        	CreatedByUserID = @CreatedByUserID
		                        where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", ID);
            Command.Parameters.AddWithValue("@ApplicationID", AppID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            Command.Parameters.AddWithValue("@PaidFees", Fees);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", Reason);
            Command.Parameters.AddWithValue("@CreatedByUserID", UserID);

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

        public static DataTable GetAllLicenses()
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Licenses";
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

        public static DataTable GetAllPersonLocalLicenses(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT        
Licenses.LicenseID AS 'ID',
Licenses.ApplicationID AS 'App ID',
LicenseClasses.ClassName AS 'Class Name',
Licenses.IssueDate AS 'Issue Date',
Licenses.ExpirationDate AS 'Expiration Date',
Licenses.IsActive AS 'Is Active'
FROM            Licenses INNER JOIN
                         Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN
                         People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                         LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID AND LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
Where PersonID = @PersonID
";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllPersonLocalLicenses");
            }
            finally
            {
                Connection.Close();
            }
            return DT;
        }

        public static bool DeleteLicense(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete Licenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", ID);

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
            return (RowsAffected > 0);
        }

        public static bool IsLicenseExist(int ID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", ID);

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
    }
}
