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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private int _ID;

        public void LoadInfo(int ID)
        {
            _ID = ID;
            clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(_ID);
            lblID.Text = App.ID.ToString();
            lblLicense.Text = clsLicenseClass.Find(App.LicenseClassID).Name;
            lblTests.Text = App.PassedTests.ToString() + "/" + clsTestType.NumOfTestTypes().ToString();
        }

    }
}
