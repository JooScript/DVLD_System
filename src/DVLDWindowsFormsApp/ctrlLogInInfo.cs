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
    public partial class ctrlLogInInfo : UserControl
    {

        public ctrlLogInInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            clsUser User = clsUser.Find(UserID);
            if (User != null)
            {
                lblUserID.Text = User.UserID.ToString();
                lblUserName.Text = User.UserName.ToString();
                if (User.IsActive)
                {
                    lblIsActive.Text = "Yes";
                }
                else
                {
                    lblIsActive.Text = "No";
                }
            }
            else
            {
                MessageBox.Show($"There's no user with ID = {UserID}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
