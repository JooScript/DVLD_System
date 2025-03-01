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
    public partial class ctrlInternationalAppLicenseInfo : UserControl
    {
        private clsInternationalLicense _License;
        private int _ID;

        public ctrlInternationalAppLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadDefaultData()
        {
            lblAppDate.Text = DateTime.Today.ToShortDateString();
            lblIssueDate.Text = DateTime.Today.ToShortDateString();
            lblExpDate.Text = DateTime.Today.AddYears(1).ToShortDateString();
            lblUser.Text = clsUser.Find(clsUtil.UserID).UserName;
            lblFees.Text = clsApplicationType.Find(6).Fees.ToString();
            lblAppID.Text = clsUtil.Default;
            lblInternationalLicenseID.Text = clsUtil.Default;
            lblLocalLicenseID.Text = clsUtil.Default;
        }

        public void LoadData(int ID)
        {
            _ID = ID;
            _License = clsInternationalLicense.Find(_ID);

            if (_License == null)
            {
                LoadDefaultData();
                return;
            }

            lblAppDate.Text = _License.IssueDate.ToShortDateString();
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblExpDate.Text = _License.ExpDate.ToShortDateString();
            lblUser.Text = clsUser.Find(_License.UserID).UserName;
            lblAppID.Text = _License.LicenseAppID.ToString();
            lblFees.Text = clsApplicationType.Find(6).Fees.ToString();
            lblInternationalLicenseID.Text = _License.ID.ToString();
            lblLocalLicenseID.Text = _License.LocalLicenseID.ToString();
        }

    }
}
