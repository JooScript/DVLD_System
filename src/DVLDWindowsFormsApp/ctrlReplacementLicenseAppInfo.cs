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
    public partial class ctrlReplacementLicenseAppInfo : UserControl
    {

        private clsLicense License = new clsLicense();

        public int OldLicenseID
        {
            set
            {
                lblOLicense.Text = value.ToString();
            }
        }

        public float Fees
        {
            set
            {
                lblAppFees.Text = value.ToString();
            }
        }

        public ctrlReplacementLicenseAppInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int LicenseID)
        {
            License = clsLicense.Find(LicenseID);

            lblAppID.Text = License.GeneralAppID.ToString();
            lblAppDate.Text = License.Date.ToShortDateString();
            lblAppFees.Text = clsApplicationType.Find(License.Reason).Fees.ToString();
            lblNLicense.Text = License.ID.ToString();
            lblUserID.Text = License.UserID.ToString();
        }

        public void LoadDefaultData()
        {
            lblAppID.Text = clsUtil.Default;
            lblAppFees.Text = clsUtil.Default;
            lblNLicense.Text = clsUtil.Default;
            lblOLicense.Text = clsUtil.Default;
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblUserID.Text = clsUtil.UserID.ToString();
        }

    }
}
