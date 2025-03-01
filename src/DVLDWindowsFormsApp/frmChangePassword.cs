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
    public partial class frmChangePassword : Form
    {
        private clsUser _User = new clsUser();
        int _UserID;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.Find(_UserID);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_User != null)
            {
                piPersonInfo.LoadPersonInfo(_User.PersonID);
                liLogInInfo.LoadUserInfo(_User.UserID);
            }
            else
            {
                MessageBox.Show($"No User with ID = {_UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == _User.Password)
            {
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtNewPassword.Enabled = false;
                txtNewPassword.Text = string.Empty;
                txtConfirmPassword.Enabled = false;
                txtConfirmPassword.Text = string.Empty;
            }
        }

        private void _ChangePassword()
        {
            _User.Password = txtConfirmPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtCurrentPassword.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Password Is not Changed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ChangePassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ActivateSaveButton()
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text && txtCurrentPassword.Text == _User.Password)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            _ActivateSaveButton();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _ActivateSaveButton();
        }
    }
}
