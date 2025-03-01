using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicense
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };
        public enMode Mode = enMode.AddNew;

        public int ID
        {
            set;
            get;
        }

        public int GeneralAppID
        {
            set;
            get;
        }

        public int DriverID
        {
            set;
            get;
        }

        public int LicenseClassID
        {
            set;
            get;
        }

        public string Notes
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public bool IsActive
        {
            set;
            get;
        }

        public int Reason
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public DateTime Date
        {
            set;
            get;
        }

        public DateTime ExpDate
        {
            set;
            get;
        }

        public clsLicense()
        {
            this.ID = -1;
            this.GeneralAppID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.Notes = string.Empty;
            this.Fees = -1;
            this.IsActive = false;
            this.Reason = -1;
            this.UserID = -1;
            this.Date = DateTime.Now;
            this.ExpDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsLicense(int ID, int AppID, int DriverID, int LicenseClassID, string Notes, float Fees, bool IsActive, int Reason, int UserID, DateTime Date, DateTime ExpDate)
        {
            this.ID = ID;
            this.GeneralAppID = AppID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.Notes = Notes;
            this.Fees = Fees;
            this.IsActive = IsActive;
            this.Reason = Reason;
            this.UserID = UserID;
            this.Date = Date;
            this.ExpDate = ExpDate;
            Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            this.ID = clsLicenseData.AddNewLicense(this.GeneralAppID, this.DriverID, this.LicenseClassID, this.Notes, this.Fees, this.IsActive, this.Reason, this.UserID);
            return (this.ID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(this.ID, this.GeneralAppID, this.DriverID, this.LicenseClassID, this.Notes, this.Fees, this.IsActive, this.Reason, this.UserID);
        }

        public static clsLicense Find(int LicenseID)
        {
            int AppID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            string Notes = string.Empty;
            float Fees = -1;
            bool IsActive = false;
            int Reason = -1;
            int UserID = -1;
            DateTime Date = DateTime.MinValue;
            DateTime ExpDate = DateTime.MinValue;

            if (clsLicenseData.GetLicenseInfoByID(LicenseID, ref AppID, ref DriverID, ref LicenseClassID, ref Notes, ref Fees, ref IsActive, ref Reason, ref UserID, ref Date, ref ExpDate))
            {
                return new clsLicense(LicenseID, AppID, DriverID, LicenseClassID, Notes, Fees, IsActive, Reason, UserID, Date, ExpDate);
            }
            else
            {
                return null;
            }
        }

        public static clsLicense FindByGenerlAppID(int AppID)
        {
            int LicenseID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            string Notes = string.Empty;
            float Fees = -1;
            bool IsActive = false;
            int Reason = -1;
            int UserID = -1;
            DateTime Date = DateTime.MinValue;
            DateTime ExpDate = DateTime.MinValue;

            if (clsLicenseData.GetLicenseInfoByGeneralAppID(ref LicenseID, AppID, ref DriverID, ref LicenseClassID, ref Notes, ref Fees, ref IsActive, ref Reason, ref UserID, ref Date, ref ExpDate))
            {
                return new clsLicense(LicenseID, AppID, DriverID, LicenseClassID, Notes, Fees, IsActive, Reason, UserID, Date, ExpDate);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLicense())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _UpdateLicense();
                    }
            }
            return false;
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }

        public static DataTable GetAllPersonLocalLicenses(int PersonID)
        {
            return clsLicenseData.GetAllPersonLocalLicenses(PersonID);
        }

        public static bool DeleteLicense(int ID)
        {
            return clsLicenseData.DeleteLicense(ID);
        }

        public static bool isLicenseExist(int ID)
        {
            return clsLicenseData.IsLicenseExist(ID);
        }

    }
}