using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class frmRenewLocalLicense : Form
    {
        public frmRenewLocalLicense()
        {
            InitializeComponent();
        }

        private clsLicense _OLicense;
        private clsLicense _NLicense;

        private void tnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication _OLDApp = clsLocalDrivingLicenseApplication.FindByGenaralApp(_OLicense.GeneralAppID);
            clsLocalDrivingLicenseApplication _App = new clsLocalDrivingLicenseApplication();
            _App.LicenseClassID = _OLDApp.LicenseClassID;
            _App.PersonID = _OLDApp.PersonID;
            _App.UserID = clsUtil.UserID;
            _App.Fees = clsApplicationType.Find(2).Fees;
            _App.AppTypeID = _OLDApp.AppTypeID;

            if (!_App.Save())
            {
                MessageBox.Show("License not renewed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLocalDrivingLicenseApplication.CompleteApplicationStatus(_App.ID);

            _OLicense = clsLicense.Find(ctrlFLInfo.LicenseID);
            _OLicense.IsActive = false;
            _NLicense.GeneralAppID = _App.GeneralAppID;
            _NLicense.DriverID = _OLicense.DriverID;
            _NLicense.LicenseClassID = _OLicense.LicenseClassID;
            _NLicense.Notes = string.Empty;
            _NLicense.Fees = clsLicenseClass.Find(_OLicense.LicenseClassID).Fees;
            _NLicense.IsActive = true;
            _NLicense.Reason = 2;
            _NLicense.UserID = clsUtil.UserID;

            if (_OLicense.Save() && _NLicense.Save())
            {
                MessageBox.Show("License renewed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRenew.Enabled = false;
                llHistory.Enabled = true;
                llLicenseInfo.Enabled = true;
                ctrlANLicenseInfo.LoadData(_NLicense.ID);
                return;
            }
            else
            {
                MessageBox.Show("License not renewed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(_NLicense.GeneralAppID);
            frm.ShowDialog();
        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_OLicense.DriverID).PersonID);
            frm.ShowDialog();
        }

        private void ctrlFLInfo_OnLicenseFound(int obj)
        {
            _OLicense = clsLicense.Find(ctrlFLInfo.LicenseID);

            if (_OLicense.ExpDate > DateTime.Today)
            {
                llHistory.Enabled = true;
                ctrlANLicenseInfo.OldLicenseID = ctrlFLInfo.LicenseID;
                MessageBox.Show($"Selected License Not Expired Yet, it will expire on {_OLicense.ExpDate.ToShortDateString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_OLicense.IsActive)
            {
                llHistory.Enabled = true;
                ctrlANLicenseInfo.OldLicenseID = ctrlFLInfo.LicenseID;
                MessageBox.Show("This License Not Active", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlANLicenseInfo.OldLicenseID = ctrlFLInfo.LicenseID;
            btnRenew.Enabled = true;
        }

        private void _ReturnToDefault()
        {
            _OLicense = new clsLicense();
            _NLicense = new clsLicense();
            ctrlANLicenseInfo.LoadDefaultData();
            llHistory.Enabled = false;
            llLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;
        }

        private void ctrlFLInfo_OnLicenseNotFound(int obj)
        {
            _ReturnToDefault();
        }

        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            _ReturnToDefault();
        }
    }
}