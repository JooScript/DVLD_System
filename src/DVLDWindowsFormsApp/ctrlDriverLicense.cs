using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlDriverLicense : UserControl
    {
        private clsLicense _Lisence;
        public ctrlDriverLicense()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get
            {
                return _Lisence.ID;
            }
        }

        public void LoadDefaultData()
        {
            lblClass.Text = clsUtil.Default;
            lblName.Text = clsUtil.Default;
            lblLicenseID.Text = clsUtil.Default;
            lblNationalNo.Text = clsUtil.Default;
            lblGendor.Text = clsUtil.Default;
            lblIssueDate.Text = clsUtil.Default;
            lblReason.Text = clsUtil.Default;
            lblNotes.Text = clsUtil.Default;
            lblIsActive.Text = clsUtil.Default;
            lblBirthDate.Text = clsUtil.Default;
            lblDriverID.Text = clsUtil.Default;
            lblExpDate.Text = clsUtil.Default;
            lblIsDetained.Text = clsUtil.Default;
        }

        public void LoadInfo(int LicenseID)
        {
            _Lisence = clsLicense.Find(LicenseID);
            lblClass.Text = clsLicenseClass.Find(_Lisence.LicenseClassID).Name;
            clsDriver Driver = clsDriver.Find(_Lisence.DriverID);
            clsPerson Person = clsPerson.Find(Driver.PersonID);
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblLicenseID.Text = _Lisence.ID.ToString();
            lblNationalNo.Text = Person.NationalNo;
            lblGendor.Text = Person.Gendor;
            lblIssueDate.Text = _Lisence.Date.ToShortDateString();
            switch (_Lisence.Reason)
            {
                case 1:
                    {
                        lblReason.Text = "First Time";
                        break;
                    }
                case 2:
                    {
                        lblReason.Text = "Renew";
                        break;
                    }
                case 3:
                    {
                        lblReason.Text = "Replacement for damage";
                        break;
                    }
                case 4:
                    {
                        lblReason.Text = "Replacement for lost";
                        break;
                    }
                default:
                    {
                        lblReason.Text = "*****";
                        break;
                    }
            }
            lblNotes.Text = _Lisence.Notes != "" ? _Lisence.Notes : "No Notes";
            lblIsActive.Text = _Lisence.IsActive ? "Yes" : "No";
            lblBirthDate.Text = Person.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _Lisence.DriverID.ToString();
            lblExpDate.Text = _Lisence.ExpDate.ToShortDateString();
            lblIsDetained.Text = clsDetainedLicense.IsLicenseDetained(_Lisence.ID) ? "YES" : "NO";
        }

    }
}
