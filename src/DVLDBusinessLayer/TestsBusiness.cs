using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTest
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

        public int AppointmentID
        {
            set;
            get;
        }

        public bool Result
        {
            set;
            get;
        }

        public string Notes
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public clsTest()
        {
            this.ID = -1;
            this.AppointmentID = -1;
            this.Result = false;
            this.Notes = string.Empty;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTest(int ID, int AppointmentID, bool Result, string Notes, int UserID)
        {
            this.ID = ID;
            this.AppointmentID = AppointmentID;
            this.Result = Result;
            this.Notes = Notes;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.ID = clsTestData.AddNewTest(this.AppointmentID, this.Result, this.Notes, this.UserID);
            return (this.ID != -1);
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.ID, this.AppointmentID, this.Result, this.Notes, this.UserID);
        }

        public static clsTest Find(int ID)
        {
            int AppointmentID = -1;
            bool Result = false;
            string Notes = string.Empty;
            int UserID = -1;

            if (clsTestData.GetTestInfoByID(ID, ref AppointmentID, ref Result, ref Notes, ref UserID))
            {
                return new clsTest(ID, AppointmentID, Result, Notes, UserID);
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
                        if (_AddNewTest())
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
                        return _UpdateTest();
                    }
            }
            return false;
        }

        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();
        }

        public static bool DeleteTest(int ID)
        {
            return clsTestData.DeleteTest(ID);
        }

        public static bool isTestExist(int ID)
        {
            return clsTestData.IsTestExist(ID);
        }

    }
}
