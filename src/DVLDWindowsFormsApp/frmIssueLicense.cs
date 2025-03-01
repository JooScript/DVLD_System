using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDWindowsFormsApp.frmTestAppointments;

namespace DVLDWindowsFormsApp
{
    public partial class frmIssueLicense : Form
    {
        public frmIssueLicense(int LocalAppID)
        {
            InitializeComponent();
            this._LocalAppID = LocalAppID;
        }

        private int _LocalAppID;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLicense FirstLicense = new clsLicense();
            clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(_LocalAppID);
            clsDriver Driver = new clsDriver();
            FirstLicense.GeneralAppID = App.GeneralAppID;
            if (!clsDriver.IsPersonADriver(App.PersonID))
            {
                Driver.PersonID = App.PersonID;
                Driver.UserID = clsUtil.UserID;
                if (!Driver.Save())
                {
                    MessageBox.Show("Driver Is not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                Driver = clsDriver.FindByPersonID(App.PersonID);
            }
            FirstLicense.DriverID = Driver.ID;
            FirstLicense.LicenseClassID = App.LicenseClassID;
            FirstLicense.Notes = txtNotes.Text;
            FirstLicense.Fees = 20;
            FirstLicense.IsActive = true;
            FirstLicense.Reason = 1;
            FirstLicense.UserID = clsUtil.UserID;

            if (FirstLicense.Save())
            {
                clsLocalDrivingLicenseApplication.CompleteApplicationStatus(_LocalAppID);
                MessageBox.Show($"License Issued Successfully with license ID = {FirstLicense.ID}.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                MessageBox.Show("License Is not Saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmIssueLicense_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadInfo(_LocalAppID);
            ctrlApplicationBasicInfo1.LoadInfo(clsLocalDrivingLicenseApplication.Find(_LocalAppID).GeneralAppID);
        }
    }
}
