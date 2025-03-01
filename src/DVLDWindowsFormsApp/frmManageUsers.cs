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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private DataTable _UsersDataTable = new DataTable();

        private void _RefreshUsersList()
        {
            _UsersDataTable = clsUser.GetAllUsers();
            dgvAllUsers.DataSource = _UsersDataTable;
            lblRecords.Text = $"#Records: {_UsersDataTable.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilter.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _AddUser();
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
                    {
                        txtFilter.Visible = true;
                        cbIsActive.Visible = false;
                        break;
                    }
                case 5:
                    {
                        txtFilter.Visible = false;
                        cbIsActive.Visible = true;
                        cbIsActive.SelectedIndex = 0;
                        break;
                    }
                default:
                    {
                        txtFilter.Visible = false;
                        cbIsActive.Visible = false;
                        break;
                    }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilter.Text))
            {
                if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
                {
                    _UsersDataTable.DefaultView.RowFilter = $"CONVERT([{cbFilter.Text}], 'System.String') LIKE '%{txtFilter.Text}%'";
                }
                else
                {
                    _UsersDataTable.DefaultView.RowFilter = $"[{cbFilter.Text}] LIKE '%{txtFilter.Text}%'";
                }
            }
            else
            {
                _UsersDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_UsersDataTable.DefaultView.Count}";
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.SelectedIndex == 1)
            {
                _UsersDataTable.DefaultView.RowFilter = "[Is Active] = true";
            }
            else if (cbIsActive.SelectedIndex == 2)
            {
                _UsersDataTable.DefaultView.RowFilter = "[Is Active] = false";
            }
            else
            {
                _UsersDataTable.DefaultView.RowFilter = string.Empty;
            }
            lblRecords.Text = $"#Records: {_UsersDataTable.DefaultView.Count}";
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            clsUser User = clsUser.Find(UserID);
            if (User != null)
            {
                frmChangePassword frm = new frmChangePassword(UserID);
                frm.ShowDialog();
                _RefreshUsersList();
            }
            else
            {
                MessageBox.Show($"No User with ID = {UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _AddUser()
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddUser();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dgvAllUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvAllUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User is not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }

    }
}
