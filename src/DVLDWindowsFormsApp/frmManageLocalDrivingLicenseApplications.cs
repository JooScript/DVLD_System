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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private DataTable _AppsDataTable = new DataTable();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshAppsList()
        {
            _AppsDataTable = clsLocalDrivingLicenseApplication.GetAllApplications();
            dgvAllApps.DataSource = _AppsDataTable;
            lblRecords.Text = $"#Records: {_AppsDataTable.Rows.Count}";
        }

        private void _AddApplication()
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
            _RefreshAppsList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _AddApplication();
        }

        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _RefreshAppsList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            switch (cbFilter.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    {
                        txtFilter.Visible = true;
                        cbStatus.Visible = false;
                        break;
                    }
                case 4:
                    {
                        txtFilter.Visible = false;
                        cbStatus.Visible = true;
                        cbStatus.SelectedIndex = 0;
                        break;
                    }
                default:
                    {
                        txtFilter.Visible = false;
                        cbStatus.Visible = false;
                        break;
                    }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilter.Text))
            {
                if (cbFilter.Text == "ID" || cbFilter.Text == "National No")
                {
                    _AppsDataTable.DefaultView.RowFilter = $"CONVERT([{cbFilter.Text}], 'System.String') LIKE '%{txtFilter.Text}%'";
                }
                else
                {
                    _AppsDataTable.DefaultView.RowFilter = $"[{cbFilter.Text}] LIKE '%{txtFilter.Text}%'";
                }
            }
            else
            {
                _AppsDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_AppsDataTable.DefaultView.Count}";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStatus.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    {
                        _AppsDataTable.DefaultView.RowFilter = $"[{cbFilter.Text}] LIKE '%{cbStatus.Text}%'";
                        break;
                    }
                default:
                    {
                        _AppsDataTable.DefaultView.RowFilter = string.Empty;
                        break;
                    }
            }
            lblRecords.Text = $"#Records: {_AppsDataTable.DefaultView.Count}";
        }

        private void AppsContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            miShowApplication.Enabled = true;
            miEditApplication.Enabled = true;
            miDeleteApplication.Enabled = true;
            miCancelApplication.Enabled = true;
            miSechduleTasks.Enabled = true;
            miIssueDrivingLicense.Enabled = true;
            miShowLicense.Enabled = true;
            miShowPersonLicenseHistory.Enabled = true;
            miVisionTest.Enabled = true;
            miWrittenTest.Enabled = true;
            miStreetTest.Enabled = true;

            switch (dgvAllApps.CurrentRow.Cells[6].Value.ToString())
            {
                case "New":
                    {
                        miIssueDrivingLicense.Enabled = false;
                        miShowLicense.Enabled = false;
                        break;
                    }
                case "Cancelled":
                    {
                        miEditApplication.Enabled = false;
                        miCancelApplication.Enabled = false;
                        miSechduleTasks.Enabled = false;
                        miIssueDrivingLicense.Enabled = false;
                        miShowLicense.Enabled = false;
                        miShowPersonLicenseHistory.Enabled = false;
                        break;
                    }
                case "Completed":
                    {
                        miEditApplication.Enabled = false;
                        miDeleteApplication.Enabled = false;
                        miCancelApplication.Enabled = false;
                        miSechduleTasks.Enabled = false;
                        miIssueDrivingLicense.Enabled = false;
                        break;
                    }
                default:
                    {
                        miShowApplication.Enabled = false;
                        miEditApplication.Enabled = false;
                        miDeleteApplication.Enabled = false;
                        miCancelApplication.Enabled = false;
                        miSechduleTasks.Enabled = false;
                        miIssueDrivingLicense.Enabled = false;
                        miShowLicense.Enabled = false;
                        miShowPersonLicenseHistory.Enabled = false;
                        break;
                    }
            }

            switch (Int16.Parse(dgvAllApps.CurrentRow.Cells[5].Value.ToString()))
            {
                case 0:
                    {
                        miWrittenTest.Enabled = false;
                        miStreetTest.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        miVisionTest.Enabled = false;
                        miStreetTest.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        miVisionTest.Enabled = false;
                        miWrittenTest.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        if (dgvAllApps.CurrentRow.Cells[6].Value.ToString() != "Completed")
                        {
                            miIssueDrivingLicense.Enabled = true;
                        }
                        miSechduleTasks.Enabled = false;
                        miVisionTest.Enabled = false;
                        miWrittenTest.Enabled = false;
                        miStreetTest.Enabled = false;
                        break;
                    }
                default:
                    {
                        miSechduleTasks.Enabled = false;
                        miVisionTest.Enabled = false;
                        miWrittenTest.Enabled = false;
                        miStreetTest.Enabled = false;
                        break;
                    }
            }
        }

        private void miShowApplication_Click(object sender, EventArgs e)
        {

        }

        private void miEditApplication_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication((int)dgvAllApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAppsList();
        }

        private void miDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Application [" + dgvAllApps.CurrentRow.Cells[0].Value + "]", "Confirm Deleting", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.DeleteApplication((int)dgvAllApps.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAppsList();
                }
                else
                {
                    MessageBox.Show("Application is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void miCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel Application [" + dgvAllApps.CurrentRow.Cells[0].Value + "]", "Confirm Canceling", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.CancelApplicationStatus((int)dgvAllApps.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAppsList();
                }
                else
                {
                    MessageBox.Show("Application is not Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void miIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            frmIssueLicense frm = new frmIssueLicense((int)dgvAllApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void miShowLicense_Click(object sender, EventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(clsLocalDrivingLicenseApplication.Find((int)dgvAllApps.CurrentRow.Cells[0].Value).GeneralAppID);
            frm.ShowDialog();
        }

        private void miShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsLocalDrivingLicenseApplication.Find((int)dgvAllApps.CurrentRow.Cells[0].Value).PersonID);
            frm.ShowDialog();
        }

        private void miVisionTest_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(frmTestAppointments.enType.Vision, (int)dgvAllApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAppsList();
        }

        private void miWrittenTest_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(frmTestAppointments.enType.Writing, (int)dgvAllApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAppsList();
        }

        private void miStreetTest_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(frmTestAppointments.enType.Street, (int)dgvAllApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAppsList();
        }

    }
}