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
    public partial class frmManageApplications : Form
    {

        private DataTable _ApplicationTypesDataTable = new DataTable();

        public frmManageApplications()
        {
            InitializeComponent();
        }
        private void _RefreshApplicationTypesList()
        {
            _ApplicationTypesDataTable = clsApplicationType.GetAllApplicationsTypes();
            dgvApplicationTypesList.DataSource = _ApplicationTypesDataTable;
            lblRecords.Text = $"#Records: {_ApplicationTypesDataTable.Rows.Count}";
        }

        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int)dgvApplicationTypesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshApplicationTypesList();
        }
    }
}
