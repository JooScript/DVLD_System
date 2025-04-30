using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (clsUser.IsUserExist(txtUserName.Text.ToString()) && clsUser.IsUserActive(txtUserName.Text.ToString()) && clsUser.GetPassword(txtUserName.Text.ToString()) == txtPassword.Text.ToString())
            {
                clsUser.RememberChecking(cbRememberMe.Checked);
                if (cbRememberMe.Checked)
                {
                    clsUtil.RememberUser(txtUserName.Text.ToString(), txtPassword.Text.ToString());
                }
                clsUtil.UserID = clsUser.GetUserID(txtUserName.Text.ToString());
                frmHome frm = new frmHome();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password", "Wrong Credinitial", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            string UserName = null;
            string Password = null;
            if (clsUser.IsUserRememberd())
            {
                cbRememberMe.Checked = true;
                clsUtil.GetUserRemembered(ref UserName, ref Password);
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
            }
        }
    }
}