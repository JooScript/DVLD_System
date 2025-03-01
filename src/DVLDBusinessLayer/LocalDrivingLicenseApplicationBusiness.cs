using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication
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

        public int LicenseClassID
        {
            set;
            get;
        }

        public int PersonID
        {
            set;
            get;
        }

        public DateTime AppDate
        {
            set;
            get;
        }

        public int AppTypeID
        {
            set;
            get;
        }

        public string AppStatus
        {
            set;
            get;
        }

        public DateTime LastStatusDate
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public int PassedTests
        {
            set;
            get;
        }

        public int AllTrials
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public int GeneralAppID
        {
            set;
            get;
        }

        public clsLocalDrivingLicenseApplication()
        {
            this.ID = -1;
            this.LicenseClassID = -1;
            this.PersonID = -1;
            this.AppDate = DateTime.Now;
            this.AppTypeID = -1;
            this.AppStatus = "";
            this.LastStatusDate = DateTime.MinValue;
            this.UserID = -1;
            this.Fees = -1;
            this.PassedTests = -1;
            this.AllTrials = -1;
            this.GeneralAppID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int ID, int PersonID, int LicenseClassID, DateTime AppDate, int AppTypeID, string Status, DateTime LastStatusDate, int UserID, float Fees, int passedTests, int Trials, int GeneralAppID)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.LicenseClassID = LicenseClassID;
            this.AppDate = AppDate;
            this.AppTypeID = AppTypeID;
            this.AppStatus = Status;
            this.LastStatusDate = LastStatusDate;
            this.UserID = UserID;
            this.Fees = Fees;
            Mode = enMode.Update;
            this.PassedTests = passedTests;
            this.AllTrials = Trials;
            this.GeneralAppID = GeneralAppID;
        }

        private bool _AddNewApplication()
        {
            int GeneralAppID = -1;
            this.ID = clsLocalDrivingLicenseApplicationsData.AddNewApplication(this.PersonID, this.UserID, this.LicenseClassID);
            clsLocalDrivingLicenseApplicationsData.GetGeneralApplicationIDByLocalAppID(ID, ref GeneralAppID);
            this.GeneralAppID = GeneralAppID;
            return (this.ID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateApplicationLicenseClass(this.ID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplication Find(int ID)
        {
            int LicenseClassID = -1;
            int PersonID = -1;
            DateTime AppDate = DateTime.Now;
            int AppTypeID = -1;
            string AppStatus = "";
            DateTime LastStatusDate = DateTime.Now;
            int UserID = -1;
            float Fees = -1;
            int PassedTests = -1;
            int GeneralAppID = -1;
            int Trials = -1;

            if (clsLocalDrivingLicenseApplicationsData.GetApplicationInfoByID(ID, ref LicenseClassID, ref PersonID, ref AppDate, ref AppTypeID, ref AppStatus, ref LastStatusDate, ref Fees, ref UserID, ref PassedTests, ref Trials))
            {
                clsLocalDrivingLicenseApplicationsData.GetGeneralApplicationIDByLocalAppID(ID, ref GeneralAppID);
                return new clsLocalDrivingLicenseApplication(ID, PersonID, LicenseClassID, AppDate, AppTypeID, AppStatus, LastStatusDate, UserID, Fees, PassedTests, Trials, GeneralAppID);
            }
            else
            {
                return null;
            }
        }

        public static clsLocalDrivingLicenseApplication FindByGenaralApp(int GeneralAppID)
        {
            int LocalAppID = -1;

            if (clsLocalDrivingLicenseApplicationsData.GetLocalApplicationIDByGeneralAppID(GeneralAppID, ref LocalAppID))
            {
                return Find(LocalAppID);
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
                        if (_AddNewApplication())
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
                        return _UpdateApplication();
                    }
            }
            return false;
        }

        public static bool CancelApplicationStatus(int ID)
        {
            int GeneralAppID = -1;
            clsLocalDrivingLicenseApplicationsData.GetGeneralApplicationIDByLocalAppID(ID, ref GeneralAppID);
            return clsApplicationsData.CancelApplicationClass(GeneralAppID);
        }

        public static bool CompleteApplicationStatus(int ID)
        {
            int GeneralAppID = -1;
            clsLocalDrivingLicenseApplicationsData.GetGeneralApplicationIDByLocalAppID(ID, ref GeneralAppID);
            return clsApplicationsData.CompleteApplicationClass(GeneralAppID);
        }

        public static DataTable GetAllApplications()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllApplications();
        }

        public static bool DeleteApplication(int ID)
        {
            return clsLocalDrivingLicenseApplicationsData.DeleteApplication(ID);
        }

        public static bool IsApplicationExist(int ID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsApplicationExist(ID);
        }

        public static bool IsOpenToAddApp(string NationalNo, string ClassName)
        {
            return clsLocalDrivingLicenseApplicationsData.IsOpenToAddApp(NationalNo, ClassName);
        }

        public static int GetSpecificTestTrials(int AppID, int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetSpecificTestTrials(AppID, TestTypeID);
        }

    }
}