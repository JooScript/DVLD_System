using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplication
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };
        public enMode Mode = enMode.AddNew;

        public int ID
        {
            get;
        }

        public int PersonID
        {
            set;
            get;
        }

        public DateTime Date
        {
            set;
            get;
        }

        public int AppTypeID
        {
            set;
            get;
        }

        public string Status
        {
            set;
            get;
        }

        public DateTime LastStatusDate
        {
            set;
            get;
        }

        public float PaidFees
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public clsApplication()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Date = DateTime.MinValue;
            this.AppTypeID = -1;
            this.Status = string.Empty;
            this.LastStatusDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }

        private clsApplication(int ID, int PersonID, DateTime Date, int AppTypeID, string Status, DateTime LastStatusDate, float PaidFees, int UserID)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.Date = Date;
            this.AppTypeID = AppTypeID;
            this.Status = Status;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        public static clsApplication Find(int ID)
        {
            int PersonID = -1;
            DateTime Date = DateTime.MinValue;
            int AppTypeID = -1;
            string Status = string.Empty;
            DateTime LastStatusDate = DateTime.MinValue;
            float PaidFees = -1;
            int UserID = -1;

            if (clsApplicationsData.GetApplicationInfoByID(ID, ref PersonID, ref Date, ref AppTypeID, ref Status, ref LastStatusDate, ref PaidFees, ref UserID))
            {
                return new clsApplication(ID, PersonID, Date, AppTypeID, Status, LastStatusDate, PaidFees, UserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationsData.GetAllApplications();
        }

        public static bool DeleteApplication(int ID)
        {
            return clsApplicationsData.DeleteApplication(ID);
        }

        public static bool IsApplicationExist(int ID)
        {
            return clsApplicationsData.IsApplicationExist(ID);
        }

    }
}
