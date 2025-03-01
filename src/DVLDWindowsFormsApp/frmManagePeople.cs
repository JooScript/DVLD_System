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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        DataTable _PeopleDataTable = new DataTable();

        private void _RefreshPeopleList()
        {
            _PeopleDataTable = clsPerson.GetAllPeople();
            dgvAllPeople.DataSource = _PeopleDataTable;
            lblRecords.Text = $"#Records: {dgvAllPeople.Rows.Count}";
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            cbFilter.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _AddPerson()
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _AddPerson();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddPerson();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            switch (cbFilter.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    {
                        txtFilter.Visible = true;
                        break;
                    }
                default:
                    {
                        txtFilter.Visible = false;
                        break;
                    }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilter.Text))
            {
                if (cbFilter.Text == "Person ID")
                {
                    _PeopleDataTable.DefaultView.RowFilter = $"CONVERT([{cbFilter.Text}], 'System.String') LIKE '%{txtFilter.Text}%'";
                }
                else
                {
                    _PeopleDataTable.DefaultView.RowFilter = $"[{cbFilter.Text}] LIKE '%{txtFilter.Text}%'";
                }
            }
            else
            {
                _PeopleDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_PeopleDataTable.DefaultView.Count}";
        }

        private void addPesonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddPerson();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
