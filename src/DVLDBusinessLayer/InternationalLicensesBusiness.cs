using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalLicense
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

        public int LicenseAppID
        {
            set;
            get;
        }

        public int DriverID
        {
            set;
            get;
        }

        public int LocalLicenseID
        {
            set;
            get;
        }

        public DateTime IssueDate
        {
            set;
            get;
        }

        public DateTime ExpDate
        {
            set;
            get;
        }

        public bool IsActive
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public clsInternationalLicense()
        {
            this.ID = -1;
            this.LicenseAppID = -1;
            this.DriverID = -1;
            this.LocalLicenseID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpDate = DateTime.MinValue;
            this.IsActive = false;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int LicenseID, int AppID, int DriverID, int LocalLicenseID, DateTime IssueDate, DateTime ExpDate, bool IsActive, int UserID)
        {
            this.ID = LicenseID;
            this.LicenseAppID = AppID;
            this.DriverID = DriverID;
            this.LocalLicenseID = LocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpDate = ExpDate;
            this.IsActive = IsActive;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            if (clsLicense.Find(this.LocalLicenseID).LicenseClassID == 3)
            {
                this.ID = clsInternationalLicenseData.AddNewLicense(this.DriverID, this.LocalLicenseID, this.UserID);
                return (this.ID != -1);
            }
            return false;
        }

        private bool _UpdateLicense()
        {
            return clsInternationalLicenseData.UpdateLicense(this.ID, this.IsActive);
        }

        public static clsInternationalLicense Find(int ID)
        {
            int AppID = -1;
            int DriverID = -1;
            int LocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpDate = DateTime.MinValue;
            bool IsActive = false;
            int UserID = -1;

            if (clsInternationalLicenseData.GetLicenseInfoByID(ID, ref AppID, ref DriverID, ref LocalLicenseID, ref IssueDate, ref ExpDate, ref IsActive, ref UserID))
            {
                return new clsInternationalLicense(ID, AppID, DriverID, LocalLicenseID, IssueDate, ExpDate, IsActive, UserID);
            }
            else
            {
                return null;
            }
        }

        public static clsInternationalLicense FindByLocalLicenseID(int LocalLicenseID)
        {
            int AppID = -1;
            int DriverID = -1;
            int ID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpDate = DateTime.MinValue;
            bool IsActive = false;
            int UserID = -1;

            if (clsInternationalLicenseData.GetLicenseInfoByLocalLicenseID(ref ID, ref AppID, ref DriverID, LocalLicenseID, ref IssueDate, ref ExpDate, ref IsActive, ref UserID))
            {
                return new clsInternationalLicense(ID, AppID, DriverID, LocalLicenseID, IssueDate, ExpDate, IsActive, UserID);
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
            return clsInternationalLicenseData.GetAllLicenses();
        }

        public static DataTable GetAllLicensesByPersonID(int PersonID)
        {
            return clsInternationalLicenseData.GetAllLicensesByPersonID(PersonID);
        }

        public static bool DeleteLicense(int ID)
        {
            return clsInternationalLicenseData.DeleteLicense(ID);
        }

        public static bool IsLicenseExist(int ID)
        {
            return clsInternationalLicenseData.IsLicenseExist(ID);
        }

        public static bool IsActiveLicenseExistByLocalLicense(int ID)
        {
            return clsInternationalLicenseData.IsActiveLicenseExistByLocalLicense(ID);
        }

    }
}