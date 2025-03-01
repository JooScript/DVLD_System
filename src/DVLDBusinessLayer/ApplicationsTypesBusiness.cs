using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplicationType
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

        public string Title
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public clsApplicationType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = -1;
            Mode = enMode.AddNew;
        }

        private clsApplicationType(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            this.ID = clsApplicationTypeData.AddApplicationType(this.Title, this.Fees);
            return (this.ID != -1);
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = "";
            float Fee = -1;

            if (clsApplicationTypeData.GetApplicationTypeInfoByID(ID, ref Title, ref Fee))
            {
                return new clsApplicationType(ID, Title, Fee);
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
                        if (_AddNewApplicationType())
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
                        return _UpdateApplicationType();
                    }
            }
            return false;
        }

        public static DataTable GetAllApplicationsTypes()
        {
            return clsApplicationTypeData.GetAllApplicationsTypes();
        }

        public static bool DeleteApplicationType(int ID)
        {
            return clsApplicationTypeData.DeleteApplicationType(ID);
        }

        public static bool isApplicationTypeExist(int ID)
        {
            return clsApplicationTypeData.IsApplicationTypeExist(ID);
        }

    }
}
