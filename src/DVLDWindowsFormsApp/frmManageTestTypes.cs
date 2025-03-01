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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private DataTable _TestTypesDataTable = new DataTable();

        private void _RefreshTestTypesList()
        {
            _TestTypesDataTable = clsTestType.GetAllTestTypes();
            dgvTestTypesList.DataSource = _TestTypesDataTable;
            lblRecords.Text = $"#Records: {_TestTypesDataTable.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
        }

        private void EditTestType_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((int)dgvTestTypesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshTestTypesList();
        }
    }
}
