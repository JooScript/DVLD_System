using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsAppointment
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

        public int TestTypeID
        {
            set;
            get;
        }

        public int LocalDrivingLicenseApplicationID
        {
            set;
            get;
        }

        public DateTime AppointmentDate
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public bool IsLocked
        {
            set;
            get;
        }

        public clsAppointment()
        {
            this.ID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.Fees = -1;
            this.UserID = -1;
            this.IsLocked = true;
            Mode = enMode.AddNew;
        }

        private clsAppointment(int ID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float Fees, int UserID, bool IsLocked)
        {
            this.ID = ID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.Fees = Fees;
            this.UserID = UserID;
            this.IsLocked = IsLocked;
            Mode = enMode.Update;
        }

        private bool _AddNewAppointment()
        {
            this.ID = clsAppointmentData.AddNewAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.Fees, this.UserID, this.IsLocked);
            return (this.ID != -1);
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentData.UpdateAppointment(this.ID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.Fees, this.UserID, this.IsLocked);
        }

        public static clsAppointment Find(int ID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float Fees = -1;
            int UserID = -1;
            bool IsLocked = false;

            if (clsAppointmentData.GetAppointmentInfoByID(ID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref Fees, ref UserID, ref IsLocked))
            {
                return new clsAppointment(ID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, Fees, UserID, IsLocked);
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
                        if (_AddNewAppointment())
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
                        return _UpdateAppointment();
                    }
            }
            return false;
        }

        public static DataTable GetAllAppointments(int LocalAppID, int TestTypeID)
        {
            return clsAppointmentData.GetAllAppointments(LocalAppID, TestTypeID);
        }

        public static bool DeleteAppointment(int ID)
        {
            return clsAppointmentData.DeleteAppointment(ID);
        }

        public static bool IsAppointmentExist(int ID)
        {
            return clsAppointmentData.IsAppointmentExist(ID);
        }

        public static bool IsAppointmentActive(int LoalAppID, int TestTypeID)
        {
            return clsAppointmentData.IsAppointmentActive(LoalAppID, TestTypeID);
        }

        public static bool IsTestPassed(int LoalAppID, int TestTypeID)
        {
            return clsAppointmentData.IsTestPassed(LoalAppID, TestTypeID);
        }

        public static bool IsPastAppointmentExist(int LoalAppID, int TestTypeID)
        {
            return clsAppointmentData.IsPastAppointmentExist(LoalAppID, TestTypeID);
        }

    }
}
