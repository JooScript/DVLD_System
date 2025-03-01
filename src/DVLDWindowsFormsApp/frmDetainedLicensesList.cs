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
    public partial class frmDetainedLicensesList : Form
    {
        public frmDetainedLicensesList()
        {
            InitializeComponent();
        }

        private DataTable _LicensesDataTable;

        private void _RefreshLicenses()
        {
            _LicensesDataTable = clsDetainedLicense.GetAllDetainedLicenses();
            dgvLicenses.DataSource = _LicensesDataTable;
            lblRecords.Text = $"#Records: {_LicensesDataTable.Rows.Count}";
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _RefreshLicenses();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(-1);
            frm.ShowDialog();
            _RefreshLicenses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainedLicensesList_Load(object sender, EventArgs e)
        {
            _RefreshLicenses();
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;

            switch (cbFilter.SelectedIndex)
            {
                case 1:
                case 3:
                case 4:
                case 5:
                    {
                        txtFilter.Visible = true;
                        cbRelease.Visible = false;
                        break;
                    }
                case 2:
                    {
                        txtFilter.Visible = false;
                        cbRelease.Visible = true;
                        cbRelease.SelectedIndex = 0;
                        break;
                    }
                default:
                    {
                        txtFilter.Visible = false;
                        cbRelease.Visible = false;
                        break;
                    }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilter.Text))
            {
                string Column = string.Empty;

                switch (cbFilter.Text)
                {
                    case "Detain ID":
                        {
                            Column = "D.ID";
                            break;
                        }
                    case "National No":
                        {
                            Column = "N.NO.";
                            break;
                        }
                    case "Full Name":
                        {
                            Column = "Full Name";
                            break;
                        }
                    case "Release Application ID":
                        {
                            Column = "Release App.ID";
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }

                if (cbFilter.Text == "Detain ID" || cbFilter.Text == "Release Application ID")
                {
                    _LicensesDataTable.DefaultView.RowFilter = $"CONVERT([{Column}], 'System.String') LIKE '%{txtFilter.Text}%'";
                }
                else if (cbFilter.Text == "National No" || cbFilter.Text == "Full Name")
                {
                    _LicensesDataTable.DefaultView.RowFilter = $"[{Column}] LIKE '%{txtFilter.Text}%'";
                }
            }
            else
            {
                _LicensesDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_LicensesDataTable.DefaultView.Count}";
        }

        private void cbRelease_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRelease.Text == "Released")
            {
                _LicensesDataTable.DefaultView.RowFilter = $"[Is Released] = True";
            }
            else if (cbRelease.Text == "Detained")
            {
                _LicensesDataTable.DefaultView.RowFilter = $"[Is Released] = False";
            }
            else
            {
                _LicensesDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_LicensesDataTable.DefaultView.Count}";
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(clsPerson.Find((string)dgvLicenses.CurrentRow.Cells[6].Value).PersonID);
            frm.Show();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(clsLicense.Find((int)dgvLicenses.CurrentRow.Cells[1].Value).GeneralAppID);
            frm.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsPerson.Find((string)dgvLicenses.CurrentRow.Cells[6].Value).PersonID);
            frm.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense((int)dgvLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLicenses();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsmiRelease.Enabled = !(bool)dgvLicenses.CurrentRow.Cells[3].Value;
        }
    }
}