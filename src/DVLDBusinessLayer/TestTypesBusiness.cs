using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestType
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

        public string Description
        {
            set;
            get;
        }

        public float Fees
        {
            set;
            get;
        }

        public clsTestType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = -1;
            Mode = enMode.AddNew;
        }

        private clsTestType(int ID, string Title, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
            Mode = enMode.Update;
        }

        private bool _AddNewTestType()
        {
            this.ID = clsTestTypeData.AddTestType(this.Title, this.Description, this.Fees);
            return (this.ID != -1);
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType(this.ID, this.Title, this.Description, this.Fees);
        }

        public static clsTestType Find(int ID)
        {
            string Title = "";
            string Description = "";
            float Fee = -1;

            if (clsTestTypeData.GetTestTypeInfoByID(ID, ref Title, ref Description, ref Fee))
            {
                return new clsTestType(ID, Title, Description, Fee);
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
                        if (_AddNewTestType())
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
                        return _UpdateTestType();
                    }
            }
            return false;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public static bool DeleteTestType(int ID)
        {
            return clsTestTypeData.DeleteTestType(ID);
        }

        public static int NumOfTestTypes()
        {
            return clsTestTypeData.NumOfTestTypes();
        }

        public static bool isTestTypeExist(int ID)
        {
            return clsTestTypeData.IsTestTypeExist(ID);
        }
    }
}