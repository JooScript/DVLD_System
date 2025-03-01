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
    public partial class ctrlAppNewLicenseInfo : UserControl
    {
        public ctrlAppNewLicenseInfo()
        {
            InitializeComponent();
        }

        public int OldLicenseID
        {
            set
            {
                lblOldLicenseID.Text = value.ToString();
            }
        }

        private clsLicense _License = new clsLicense();

        public void LoadData(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);

            lblAppDate.Text = clsApplication.Find(_License.GeneralAppID).Date.ToShortDateString();
            lblIssueDate.Text = _License.Date.ToShortDateString();
            lblAppFees.Text = clsApplicationType.Find(2).Fees.ToString();
            lblUser.Text = _License.UserID.ToString();
            lblAppID.Text = _License.GeneralAppID.ToString();
            lblLicenseFees.Text = clsLicenseClass.Find(_License.LicenseClassID).Fees.ToString();
            lblRLicenseID.Text = _License.ID.ToString();
            lblExpDate.Text = _License.ExpDate.ToShortDateString();
            lblTotalFees.Text = (int.Parse(lblLicenseFees.Text) + int.Parse(lblAppFees.Text)).ToString();
        }

        public void LoadDefaultData()
        {
            lblAppDate.Text = DateTime.Today.ToShortDateString();
            lblIssueDate.Text = DateTime.Today.ToShortDateString();
            lblAppFees.Text = clsApplicationType.Find(2).Fees.ToString();
            lblUser.Text = clsUser.Find(clsUtil.UserID).UserName;
            lblAppID.Text = clsUtil.Default;
            lblLicenseFees.Text = clsUtil.Default;
            lblOldLicenseID.Text = clsUtil.Default;
            lblRLicenseID.Text = clsUtil.Default;
            lblExpDate.Text = clsUtil.Default;
            lblTotalFees.Text = clsUtil.Default;
        }

    }
}
