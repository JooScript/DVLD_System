using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataAccessLayer
{
    public class clsDetainedLicensesData
    {
        public static bool GetDetainInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float Fees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseAppID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM DetainedLicenses Where DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    LicenseID = Convert.ToInt32(Reader["LicenseID"]);
                    DetainDate = Convert.ToDateTime(Reader["DetainDate"]);
                    Fees = Convert.ToSingle(Reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(Reader["IsReleased"]);
                    ReleaseDate = Reader["ReleaseDate"] != DBNull.Value ? Convert.ToDateTime(Reader["ReleaseDate"]) : DateTime.MinValue;
                    ReleasedByUserID = Reader["ReleasedByUserID"] != DBNull.Value ? Convert.ToInt32(Reader["ReleasedByUserID"]) : -1;
                    ReleaseAppID = Reader["ReleaseApplicationID"] != DBNull.Value ? Convert.ToInt32(Reader["ReleaseApplicationID"]) : -1;
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
                clsDataAccessSettings.ErrorLogger(ex, "GetDetainInfoByID");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int GetInReleasedDetainID(int LicenseID)
        {
            int DetainID = -1;
            int InsertedID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM DetainedLicenses Where LicenseID = @LicenseID and IsReleased = 0";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out InsertedID))
                {
                    DetainID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "GetInReleasedDetainID");
            }
            finally
            {
                Connection.Close();
            }
            return DetainID;
        }


        public static int NewDetain(int LicenseID, float Fees, int CreatedByUserID)
        {
            int DetainID = -1;
            int InsertedID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                Values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                                Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DateTime.Today);
            Command.Parameters.AddWithValue("@FineFees", Fees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", 0);
            Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out InsertedID))
                {
                    DetainID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "NewDetain");
            }
            finally
            {
                Connection.Close();
            }
            return DetainID;
        }

        public static bool ReleaseDetain(int DetainID, int ReleasedByUserID)
        {
            int RowsAffected = 0;

            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID1 = -1, ReleaseAppID1 = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;
            float Fees = -1;
            bool IsReleased = false;

            GetDetainInfoByID(DetainID, ref LicenseID, ref DetainDate, ref Fees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID1, ref ReleaseAppID1);

            int LicenseAppID = -1, DriverID = -1, LicenseClassID = -1, Reason = -1, UserID = -1;
            string Notes = string.Empty;
            bool IsActive = false;
            DateTime Date = DateTime.MinValue, ExpDate = DateTime.MinValue;
            float LicenseFees = -1;

            clsLicenseData.GetLicenseInfoByID(LicenseID, ref LicenseAppID, ref DriverID, ref LicenseClassID, ref Notes, ref LicenseFees, ref IsActive, ref Reason, ref UserID, ref Date, ref ExpDate);

            int PersonID = -1, DriverUserID = -1;

            clsDriverData.GetDriverInfoByID(DriverID, ref PersonID, ref DriverUserID);



            int AppID = clsApplicationsData.AddApplication(PersonID, 5, ReleasedByUserID);
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update DetainedLicenses
                                set IsReleased = @IsReleased,
	                                ReleaseDate = @ReleaseDate,
		                            ReleasedByUserID = @ReleasedByUserID,
		                            ReleaseApplicationID = @ReleaseApplicationID
	                            where DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", AppID);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            Command.Parameters.AddWithValue("@IsReleased", 1);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "ReleaseDetain");
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static DataTable GetAllDetains()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
SELECT
DetainedLicenses.DetainID AS 'D.ID',
DetainedLicenses.LicenseID AS 'L.ID',
DetainedLicenses.DetainDate AS 'D.Date',
DetainedLicenses.IsReleased  AS 'Is Released',
DetainedLicenses.FineFees AS 'Fine Fees',
DetainedLicenses.ReleaseDate AS 'Release Date',
People.NationalNo  AS 'N.NO.',
People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS 'Full Name',
DetainedLicenses.ReleaseApplicationID AS 'Release App.ID'
FROM     People INNER JOIN
                  Drivers ON People.PersonID = Drivers.PersonID INNER JOIN
                  Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                  DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID";
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
                clsDataAccessSettings.ErrorLogger(ex, "GetAllDetains");
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool DeleteDetain(int DetainID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete DetainedLicenses where DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.ErrorLogger(ex, "DeleteDetain");
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsDetainExist(int DetainID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsDetainExist");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT Found = 1 FROM DetainedLicenses WHERE IsReleased = '0' and LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
                clsDataAccessSettings.ErrorLogger(ex, "IsLicenseDetained");
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

    }
}