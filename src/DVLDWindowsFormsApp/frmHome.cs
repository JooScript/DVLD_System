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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsUtil.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsUtil.UserID);
            frm.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageApplications frm = new frmManageApplications();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _NewLocalDrivingLicenseApplication();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _LocalDrivingLicenseApplicationList();
        }

        private void _NewLocalDrivingLicenseApplication()
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
        }

        private void _LocalDrivingLicenseApplicationList()
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
        }

        private void internationlDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenses frm = new frmManageInternationalLicenses();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicense frm = new frmRenewLocalLicense();
            frm.ShowDialog();
        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementForDamagedLicense frm = new frmReplacementForDamagedLicense();
            frm.ShowDialog();
        }

        private void manageDetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicensesList frm = new frmDetainedLicensesList();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(-1);
            frm.ShowDialog();
        }

        private void releaseDetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(-1);
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _LocalDrivingLicenseApplicationList();
        }
    }
}
