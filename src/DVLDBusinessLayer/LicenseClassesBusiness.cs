using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClass
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

        public string Name
        {
            set;
            get;
        }

        public string Description
        {
            set;
            get;
        }

        public int MinAge
        {
            set;
            get;
        }

        public int DefaultValidityLength
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public clsLicenseClass()
        {
            this.ID = -1;
            this.Name = "";
            this.Description = "";
            this.MinAge = -1;
            this.DefaultValidityLength = -1;
            this.Fees = -1;
            Mode = enMode.AddNew;
        }

        private clsLicenseClass(int ID, string Name, string Description, int MinAge, int DefaultValidityLength, float Fees)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.MinAge = MinAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.Fees = Fees;
            Mode = enMode.Update;
        }

        private bool _AddNewLicenseClass()
        {
            this.ID = clsLicenseClassesData.AddLicenseClass(this.Name, this.Description, this.MinAge, this.DefaultValidityLength, this.Fees);
            return (this.ID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassesData.UpdateLicenseClass(this.ID, this.Name, this.Description, this.MinAge, this.DefaultValidityLength, this.Fees);
        }

        public static clsLicenseClass Find(int ID)
        {
            string Name = "";
            string Description = "";
            int MinAge = -1;
            int DefaultValidityLength = -1;
            float Fees = -1;

            if (clsLicenseClassesData.GetLicenseClassInfoByID(ID, ref Name, ref Description, ref MinAge, ref DefaultValidityLength, ref Fees))
            {
                return new clsLicenseClass(ID, Name, Description, MinAge, DefaultValidityLength, Fees);
            }
            else
            {
                return null;
            }
        }

        public static clsLicenseClass Find(string Name)
        {
            int ID = -1;
            string Description = "";
            int MinAge = -1;
            int DefaultValidityLength = -1;
            float Fees = -1;

            if (clsLicenseClassesData.GetLicenseClassInfoByName(Name, ref ID, ref Description, ref MinAge, ref DefaultValidityLength, ref Fees))
            {
                return new clsLicenseClass(ID, Name, Description, MinAge, DefaultValidityLength, Fees);
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
                        if (_AddNewLicenseClass())
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
                        return _UpdateLicenseClass();
                    }
            }
            return false;
        }

        public static float GetLicenseClassFeesByID(int ID)
        {
            return clsLicenseClassesData.GetLicenseClassFeesByID(ID);
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }

        public static bool DeleteLicenseClass(int ID)
        {
            return clsLicenseClassesData.DeleteLicenseClass(ID);
        }

        public static bool isLicenseClassExist(int ID)
        {
            return clsLicenseClassesData.IsLicenseClassExist(ID);
        }
    }
}
