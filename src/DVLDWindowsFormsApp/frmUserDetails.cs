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
    public partial class frmUserDetails : Form
    {

        private int _UserID;

        public frmUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(_UserID);
            if (User != null)
            {
                piPersonInfo.LoadPersonInfo(User.PersonID);
                liLogInInfo.LoadUserInfo(User.UserID);
            }
            else
            {
                MessageBox.Show($"No user with ID = {_UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
