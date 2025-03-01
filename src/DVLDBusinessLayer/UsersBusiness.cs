using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        public enMode Mode = enMode.AddNew;

        public int UserID
        {
            set;
            get;
        }

        public int PersonID
        {
            set;
            get;
        }

        public string UserName
        {
            set;
            get;
        }

        public string Password
        {
            set;
            get;
        }

        public bool IsActive
        {
            set;
            get;
        }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            Mode = enMode.AddNew;
        }

        public clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
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
                        if (_AddNewUser())
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
                        return _UpdateUser();
                    }
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static string GetPassword(string UserName)
        {
            return clsUserData.GetPassword(UserName);
        }

        public static bool IsUserActive(string UserName)
        {
            return clsUserData.IsActive(UserName);
        }

        public static bool IsPersonAUser(int PersonID)
        {
            return clsUserData.IsPersonAUser(PersonID);
        }

        public static bool RememberChecking(bool Remember)
        {
            return clsUserData.RememberChecking(Remember);
        }

        public static bool IsUserRememberd()
        {
            return clsUserData.IsUserRememberd();
        }

        public static int GetUserID(string UserName)
        {
            return clsUserData.GetUserID(UserName);
        }

    }
}