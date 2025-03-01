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
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        DataTable _DriversDataTable = new DataTable();

        private void _RefreshDrivers()
        {
            _DriversDataTable = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = _DriversDataTable;
            lblRecords.Text = $"#Records: {_DriversDataTable.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _RefreshDrivers();
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            txtFilter.Visible = cbFilter.SelectedIndex != 0;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilter.Text))
            {
                if (cbFilter.Text == "Person ID" || cbFilter.Text == "Driver ID")
                {
                    _DriversDataTable.DefaultView.RowFilter = $"CONVERT([{cbFilter.Text}], 'System.String') LIKE '%{txtFilter.Text}%'";
                }
                else
                {
                    _DriversDataTable.DefaultView.RowFilter = $"[{cbFilter.Text}] LIKE '%{txtFilter.Text}%'";
                }
            }
            else
            {
                _DriversDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_DriversDataTable.DefaultView.Count}";
        }
    }
}
