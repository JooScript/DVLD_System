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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private clsDetainedLicense DLicense;

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (clsDetainedLicense.IsLicenseDetained(ctrlFilterLI.LicenseID))
            {
                MessageBox.Show("This License Detained Already", "Detained Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DLicense.LicenseID = ctrlFilterLI.LicenseID;
            DLicense.Fees = ctrlDInfo.Fees;
            DLicense.CreatedByUserID = clsUtil.UserID;

            if (DLicense.Save())
            {
                ctrlDInfo.LoadData(DLicense.ID);
                llInfo.Enabled = true;
                lllHistory.Enabled = true;
                ctrlFilterLI.RefreshLicense();
                btnDetain.Enabled = false;
                MessageBox.Show("This License Detained Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("This License Not Detained", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lllHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(clsLicense.Find(ctrlFilterLI.LicenseID).DriverID).PersonID);
            frm.ShowDialog();
        }

        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(clsLicense.Find(ctrlFilterLI.LicenseID).GeneralAppID);
            frm.ShowDialog();
        }

        private void _ReturnToDefault()
        {
            DLicense = new clsDetainedLicense();
            ctrlDInfo.LoadDefaultData();
            llInfo.Enabled = false;
            lllHistory.Enabled = false;
            btnDetain.Enabled = false;
        }

        private void ctrlFilterLI_OnLicenseFound(int obj)
        {
            if (clsDetainedLicense.IsLicenseDetained(ctrlFilterLI.LicenseID))
            {
                ctrlDInfo.LoadData(clsDetainedLicense.GetInReleasedDetainID(ctrlFilterLI.LicenseID));
                llInfo.Enabled = true;
                lllHistory.Enabled = true;
                btnDetain.Enabled = false;
                MessageBox.Show("This License Detained Already", "Detained Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            llInfo.Enabled = true;
            lllHistory.Enabled = true;
            btnDetain.Enabled = true;
        }

        private void ctrlFilterLI_OnLicenseNotFound(int obj)
        {
            _ReturnToDefault();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _ReturnToDefault();
        }
    }
}