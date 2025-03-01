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
    public partial class frmNewInternationalLicense : Form
    {

        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private clsInternationalLicense _License = new clsInternationalLicense();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrlILicenseInfo.LoadDefaultData();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsInternationalLicense.IsActiveLicenseExistByLocalLicense(ctrlFilterLicenseInfo.LicenseID))
            {
                _License = clsInternationalLicense.FindByLocalLicenseID(ctrlFilterLicenseInfo.LicenseID);
                ctrlILicenseInfo.LoadData(_License.ID);
                llShowLicenseInfo.Enabled = true;
                llShowLicenseHistory.Enabled = true;
                MessageBox.Show($"Person Already Have An Active International License With ID = {_License.ID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsLicense.Find(ctrlFilterLicenseInfo.LicenseID).LicenseClassID != 3)
            {
                _ReturnToDefault();
                MessageBox.Show("The Client Must Have 3rd Class License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((clsLicense.Find(ctrlFilterLicenseInfo.LicenseID).IsActive == false) || (clsLicense.Find(ctrlFilterLicenseInfo.LicenseID).ExpDate < DateTime.Today))
            {
                _ReturnToDefault();
                MessageBox.Show("The Client Must Have Active License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _License.LocalLicenseID = ctrlFilterLicenseInfo.LicenseID;
            _License.DriverID = clsLicense.Find(ctrlFilterLicenseInfo.LicenseID).DriverID;
            _License.UserID = clsUtil.UserID;

            if (DialogResult.OK == MessageBox.Show("Are you sure you want to isuue the license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
            {
                if (_License.Save())
                {
                    ctrlILicenseInfo.LoadData(_License.ID);
                    llShowLicenseInfo.Enabled = true;
                    llShowLicenseHistory.Enabled = true;
                    MessageBox.Show("International License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _ReturnToDefault();
                    MessageBox.Show("International License not issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                _ReturnToDefault();
                MessageBox.Show("International License not issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _ReturnToDefault()
        {
            _License = new clsInternationalLicense();
            ctrlILicenseInfo.LoadDefaultData();
            llShowLicenseInfo.Enabled = false;
            llShowLicenseHistory.Enabled = false;
        }

        private void ctrlFilterLicenseInfo_OnLicenseFound(int obj)
        {
            if (clsInternationalLicense.IsActiveLicenseExistByLocalLicense(ctrlFilterLicenseInfo.LicenseID))
            {
                _License = clsInternationalLicense.FindByLocalLicenseID(ctrlFilterLicenseInfo.LicenseID);
                ctrlILicenseInfo.LoadData(_License.ID);
                llShowLicenseInfo.Enabled = true;
                llShowLicenseHistory.Enabled = true;
            }
            btnIssue.Enabled = true;
        }

        private void ctrlFilterLicenseInfo_OnLicenseNotFound(int obj)
        {
            _ReturnToDefault();
            btnIssue.Enabled = false;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(_License.ID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_License.DriverID).PersonID);
            frm.ShowDialog();
        }
    }
}