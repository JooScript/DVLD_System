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
    public partial class frmManageInternationalLicenses : Form
    {
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        DataTable _LicensesDataTable = new DataTable();

        private void _RefreshLicenses()
        {
            _LicensesDataTable = clsInternationalLicense.GetAllLicenses();
            dgvAllLicenses.DataSource = _LicensesDataTable;
            lblRecords.Text = $"#Records: {_LicensesDataTable.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
            _RefreshLicenses();
        }

        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshLicenses();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(clsDriver.Find((int)dgvAllLicenses.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dgvAllLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find((int)dgvAllLicenses.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();
        }
    }
}