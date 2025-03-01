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
    public partial class frmReleaseLicense : Form
    {
        private clsDetainedLicense _Detain;
        private int _DetainID;
        public frmReleaseLicense(int DetainID)
        {
            _DetainID = DetainID;
            _Detain = DetainID == -1 ? new clsDetainedLicense() : clsDetainedLicense.Find(DetainID);
            InitializeComponent();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (!clsDetainedLicense.IsLicenseDetained(ctrlFilterLI.LicenseID))
            {
                llInfo.Enabled = true;
                llHistory.Enabled = true;
                ctrlRDInfo.LoadDefaultData();
                btnRelease.Enabled = false;
                MessageBox.Show("This License Is Not Detained", "Not Detained License", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _Detain = clsDetainedLicense.Find(clsDetainedLicense.GetInReleasedDetainID(ctrlFilterLI.LicenseID));
            _Detain.ReleasedByUserID = clsUtil.UserID;

            if (_Detain.Save())
            {
                btnRelease.Enabled = false;
                ctrlRDInfo.LoadData(_Detain.ID);
                ctrlFilterLI.RefreshLicense();

                MessageBox.Show("The License Released Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The License Not Released", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(clsLicense.Find(ctrlFilterLI.LicenseID).GeneralAppID);
            frm.ShowDialog();
        }

        private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(clsLicense.Find(ctrlFilterLI.LicenseID).DriverID).PersonID);
            frm.ShowDialog();
        }

        private void ctrlFilterLI_OnLicenseFound(int obj)
        {
            if (!clsDetainedLicense.IsLicenseDetained(ctrlFilterLI.LicenseID))
            {
                llInfo.Enabled = true;
                llHistory.Enabled = true;
                ctrlRDInfo.LoadDefaultData();
                btnRelease.Enabled = false;
                MessageBox.Show("This License Is Not Detained", "Not Detained License", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ctrlRDInfo.LoadData(clsDetainedLicense.GetInReleasedDetainID(ctrlFilterLI.LicenseID));
            btnRelease.Enabled = true;
            llInfo.Enabled = true;
            llHistory.Enabled = true;
            ctrlRDInfo.LoadDefaultData();
        }

        private void _ReturnToDefault()
        {
            ctrlRDInfo.LoadDefaultData();
            llInfo.Enabled = false;
            llHistory.Enabled = false;
            btnRelease.Enabled = false;
        }

        private void ctrlFilterLI_OnLicenseNotFound(int obj)
        {
            _Detain = new clsDetainedLicense();
            _ReturnToDefault();
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            if (_DetainID != -1)
            {
                ctrlFilterLI.LoadData(clsDetainedLicense.Find(_DetainID).LicenseID);
                ctrlRDInfo.LoadData(clsDetainedLicense.GetInReleasedDetainID(ctrlFilterLI.LicenseID));
                return;
            }

            _ReturnToDefault();
        }

    }
}
