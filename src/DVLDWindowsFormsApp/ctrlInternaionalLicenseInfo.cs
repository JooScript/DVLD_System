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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using DVLDWindowsFormsApp.Properties;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlInternaionalLicenseInfo : UserControl
    {
        public ctrlInternaionalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int ID)
        {
            clsInternationalLicense License = clsInternationalLicense.Find(ID);
            clsApplication App = clsApplication.Find(License.LicenseAppID);
            clsPerson Person = clsPerson.Find(App.PersonID);

            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblIntLicense.Text = License.ID.ToString();
            lblLicense.Text = License.LocalLicenseID.ToString();
            lblNationalNo.Text = Person.NationalNo;
            lblGendor.Text = Person.Gendor;
            lblIssueDate.Text = License.IssueDate.ToShortDateString();
            lblAppID.Text = License.LicenseAppID.ToString();
            lblActive.Text = License.IsActive ? "Yes" : "No";
            lblBDate.Text = Person.DateOfBirth.ToShortDateString();
            lblDriverID.Text = License.DriverID.ToString();
            lblExpDate.Text = License.ExpDate.ToShortDateString();

            if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                pbPersonImage.Load(Person.ImagePath);
            }
            else
            {
                pbPersonImage.Image = Person.Gendor == "Male" ? Resources.Male : Resources.Female;
            }

        }
    }
}
