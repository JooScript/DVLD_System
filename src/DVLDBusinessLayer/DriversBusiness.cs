using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDriver
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

        public int PersonID
        {
            set;
            get;
        }

        public int UserID
        {
            set;
            get;
        }

        public clsDriver()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }

        private clsDriver(int ID, int PersonID, int UserID)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.ID = clsDriverData.AddNewDriver(this.PersonID, this.UserID);
            return (this.ID != -1);
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.ID, this.PersonID, this.UserID);
        }

        public static clsDriver Find(int ID)
        {
            int PersonID = -1;
            int UserID = -1;

            if (clsDriverData.GetDriverInfoByID(ID, ref PersonID, ref UserID))
            {
                return new clsDriver(ID, PersonID, UserID);
            }
            else
            {
                return null;
            }
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int UserID = -1;

            if (clsDriverData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref UserID))
            {
                return new clsDriver(DriverID, PersonID, UserID);
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
                        if (_AddNewDriver())
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
                        return _UpdateDriver();
                    }
            }
            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }

        public static bool DeleteDriver(int ID)
        {
            return clsDriverData.DeleteDriver(ID);
        }

        public static bool IsPersonADriver(int PersonID)
        {
            return clsDriverData.IsPersonADriver(PersonID);
        }

        public static bool isDriverExist(int ID)
        {
            return clsDriverData.IsDriverExist(ID);
        }
    }
}
