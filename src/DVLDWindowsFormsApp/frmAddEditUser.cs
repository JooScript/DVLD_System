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
    public partial class frmAddEditUser : Form
    {
        private enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        private enMode _Mode;
        clsUser _User;
        int _UserID;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            if (_UserID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void ctrlFilterPersonalInfo_OnPersonFound(int obj)
        {
            _EnablingbtnNext();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _CheckIsPersonAUser();
        }

        private void _SaveUser()
        {
            _User.UserName = txtUserName.Text;
            _User.Password = txtConfirmPassword.Text;
            _User.IsActive = cbIsActive.Checked;
            _User.PersonID = ctrlFilterPersonalInfo.PersonID;

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _Mode = enMode.Update;
                _ProceduresToUpdate();
            }
            else
            {
                MessageBox.Show("Data Is not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void _ProceduresToUpdate()
        {
            lblTitle.Text = "Update User";
            this.Text = "Update User";
            btnSave.Text = "Update";
            btnSave.Enabled = false;
            ctrlFilterPersonalInfo.SelectFilterIndex(2);
            ctrlFilterPersonalInfo.EnablingFiltering(false);
            lblUserIDTitle.Visible = true;
            lblUserID.Visible = true;
            _UserID = _User.UserID;
            lblUserID.Text = _UserID.ToString();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add User";
                this.Text = "Add User";
                lblUserID.Visible = false;
                lblUserIDTitle.Visible = false;
                _User = new clsUser();
                ctrlFilterPersonalInfo.SelectFilterIndex(2);
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();
                return;
            }
            _ProceduresToUpdate();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;
            ctrlFilterPersonalInfo.LoadPersonInfo(_User.PersonID);
        }

        private void _CheckIsPersonAUser()
        {
            if (_Mode == enMode.AddNew)
            {
                if (!(clsUser.IsPersonAUser(ctrlFilterPersonalInfo.PersonID)) && ctrlFilterPersonalInfo.IsFound)
                {
                    AddUserTabControl.SelectedTab = tpLoginInfo;
                }
                else
                {
                    AddUserTabControl.SelectedTab = tpPersonalInfo;
                    if (ctrlFilterPersonalInfo.IsFound)
                    {
                        MessageBox.Show("The Person is user already", "User is already exist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveUser();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
            _WhenbtnUpdateEnabled();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
            _WhenbtnUpdateEnabled();
        }

        private void tpLoginInfo_Enter(object sender, EventArgs e)
        {
            _CheckIsPersonAUser();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                ErrorProvider.SetError(txtUserName, "UserName should have a value");
            }
            else if (clsUser.IsUserExist(txtUserName.Text) && _Mode == enMode.AddNew)
            {
                e.Cancel = true;
                txtUserName.Focus();
                ErrorProvider.SetError(txtUserName, "This Username already taken");
            }
            else if (clsUser.IsUserExist(txtUserName.Text) && _Mode == enMode.Update)
            {
                if (txtUserName.Text != _User.UserName)
                {
                    e.Cancel = true;
                    txtUserName.Focus();
                    ErrorProvider.SetError(txtUserName, "This Username already taken");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProvider.SetError(txtUserName, "");
                }
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtUserName, "");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            _WhenbtnUpdateEnabled();
        }

        private void _WhenbtnUpdateEnabled()
        {
            if (_Mode == enMode.Update)
            {
                if (_User.UserName != txtUserName.Text || _User.Password != txtPassword.Text || _User.Password != txtConfirmPassword.Text || _User.IsActive != cbIsActive.Checked)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                ErrorProvider.SetError(txtPassword, "Password should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                ErrorProvider.SetError(txtConfirmPassword, "Not the same to Password");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtConfirmPassword, "");
            }
        }

        private void cbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _WhenbtnUpdateEnabled();
        }

        private void _EnablingbtnNext()
        {
            if (ctrlFilterPersonalInfo.IsFound)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

    }
}