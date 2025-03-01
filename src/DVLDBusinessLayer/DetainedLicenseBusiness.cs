using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDetainedLicense
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

        public int LicenseID
        {
            set;
            get;
        }

        public DateTime DetainDate
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public int CreatedByUserID
        {
            set;
            get;
        }

        public bool IsReleased
        {
            set;
            get;
        }

        public DateTime ReleaseDate
        {
            set;
            get;
        }

        public int ReleasedByUserID
        {
            set;
            get;
        }

        public int ReleaseAppID
        {
            set;
            get;
        }

        public clsDetainedLicense()
        {
            this.ID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MinValue;
            this.Fees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseAppID = -1;
            Mode = enMode.AddNew;
        }

        public clsDetainedLicense(int ID, int LicenseID, DateTime DetainDate, float Fees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseAppID)
        {
            this.ID = ID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.Fees = Fees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseAppID = ReleaseAppID;
            Mode = enMode.Update;
        }

        private bool _Detain()
        {
            this.ID = clsDetainedLicensesData.NewDetain(this.LicenseID, this.Fees, this.CreatedByUserID);
            return (this.ID != -1);
        }

        private bool _Realese()
        {
            return clsDetainedLicensesData.ReleaseDetain(this.ID, this.ReleasedByUserID);
        }

        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseAppID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;
            float Fees = -1;
            bool IsReleased = false;

            if (clsDetainedLicensesData.GetDetainInfoByID(DetainID, ref LicenseID, ref DetainDate, ref Fees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseAppID))
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, Fees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseAppID);
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
                        if (_Detain())
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
                        return _Realese();
                    }
            }
            return false;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesData.GetAllDetains();
        }

        public static bool DeleteDetainedLicense(int DetainID)
        {
            return clsDetainedLicensesData.DeleteDetain(DetainID);
        }

        public static bool IsDetainedLicenseExist(int DetainID)
        {
            return clsDetainedLicensesData.IsDetainExist(DetainID);
        }

        public static int GetInReleasedDetainID(int LicenseID)
        {
            return clsDetainedLicensesData.GetInReleasedDetainID(LicenseID);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesData.IsLicenseDetained(LicenseID);
        }
    }
}