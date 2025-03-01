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
    public partial class frmReplacementForDamagedLicense : Form
    {
        clsLicense _OLicense;
        clsLicense _NLicense;

        public frmReplacementForDamagedLicense()
        {
            InitializeComponent();
        }

        private void ctrlFLInfo_OnLicenseFound(int obj)
        {
            _OLicense = clsLicense.Find(ctrlFLInfo.LicenseID);

            if (_OLicense.ExpDate < DateTime.Today)
            {
                llHistory.Enabled = true;
                ctrlRLAppInfo.OldLicenseID = ctrlFLInfo.LicenseID;
                MessageBox.Show($"Selected License Expired , it expired on {_OLicense.ExpDate.ToShortDateString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_OLicense.IsActive)
            {
                llHistory.Enabled = true;
                ctrlRLAppInfo.OldLicenseID = ctrlFLInfo.LicenseID;
                MessageBox.Show("This License Not Active", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlRLAppInfo.OldLicenseID = ctrlFLInfo.LicenseID;
            btnIssue.Enabled = true;
        }

        private void _ReturnToDefault()
        {
            _OLicense = new clsLicense();
            _NLicense = new clsLicense();
            ctrlRLAppInfo.LoadDefaultData();
            llHistory.Enabled = false;
            llInfo.Enabled = false;
            btnIssue.Enabled = false;
        }

        private void ctrlFLInfo_OnLicenseNotFound(int obj)
        {
            _ReturnToDefault();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
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
                MessageBox.Show("License not replaced", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _NLicense.Reason = rbDamaged.Checked ? 3 : 4;
            _NLicense.UserID = clsUtil.UserID;

            if (_OLicense.Save() && _NLicense.Save())
            {
                MessageBox.Show("License replaced successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIssue.Enabled = false;
                llHistory.Enabled = true;
                llInfo.Enabled = true;
                ctrlRLAppInfo.LoadData(_NLicense.ID);
                return;
            }
            else
            {
                MessageBox.Show("License not replaced", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {
            _ReturnToDefault();
            ctrlRLAppInfo.Fees = clsApplicationType.Find(4).Fees;
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            _ChangeFees(sender);
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            _ChangeFees(sender);
        }

        private void _ChangeFees(object sender)
        {
            if (sender is RadioButton radioButton && radioButton.Tag != null)
            {
                if (int.TryParse(radioButton.Tag.ToString(), out int AppTypeID))
                {
                    clsApplicationType ApplicationType = clsApplicationType.Find(AppTypeID);
                    if (ApplicationType != null)
                    {
                        ctrlRLAppInfo.Fees = ApplicationType.Fees;
                    }
                    else
                    {
                        ctrlRLAppInfo.Fees = -1;
                    }
                }
                else
                {
                    throw new InvalidOperationException("The Tag value is not a valid integer.");
                }
            }
            else
            {
                throw new InvalidOperationException("Sender is not a RadioButton or Tag is null.");
            }
        }

        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(_NLicense.GeneralAppID);
            frm.ShowDialog();
        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_OLicense.DriverID).PersonID);
            frm.ShowDialog();
        }
    }
}
