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
    public partial class frmPersonLicenseHistory : Form
    {
        private int _PersonID;
        public frmPersonLicenseHistory(int PersonD)
        {
            InitializeComponent();
            _PersonID = PersonD;
        }

        private void _RefreshLocal()
        {
            DataTable _Licenses = clsLicense.GetAllPersonLocalLicenses(_PersonID);
            dgvLocal.DataSource = _Licenses;
            lblRecords.Text = $"#Records: {_Licenses.Rows.Count}";
        }

        private void _RefreshInternational()
        {
            DataTable _Licenses = clsInternationalLicense.GetAllLicensesByPersonID(_PersonID);
            dgvInternational.DataSource = _Licenses;
            lblRecords.Text = $"#Records: {_Licenses.Rows.Count}";
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadPersonInfo(_PersonID);
            _RefreshLocal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpInternational_Enter(object sender, EventArgs e)
        {
            _RefreshInternational();
        }

        private void tpLocal_Enter(object sender, EventArgs e)
        {
            _RefreshLocal();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense frm = new frmShowLicense((int)dgvLocal.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dgvInternational.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
