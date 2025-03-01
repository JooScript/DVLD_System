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
    public partial class ctrlReleasedDetainedInfo : UserControl
    {
        public ctrlReleasedDetainedInfo()
        {
            InitializeComponent();
        }

        private clsDetainedLicense DLicense;

        public void LoadDefaultData()
        {
            lblDetainID.Text = clsUtil.Default;
            lblDetainDate.Text = clsUtil.Default;
            lblAppFees.Text = clsApplicationType.Find(5).Fees.ToString();
            lblFine.Text = clsUtil.Default;
            lblTFees.Text = clsUtil.Default;
            lblLicenseID.Text = clsUtil.Default;
            lblUser.Text = clsUtil.Default;
            lblAppID.Text = clsUtil.Default;
        }

        public void LoadData(int DLicenseID)
        {
            DLicense = clsDetainedLicense.Find(DLicenseID);

            lblDetainID.Text = DLicense.ID.ToString();
            lblDetainDate.Text = DLicense.DetainDate.ToShortDateString();
            lblAppFees.Text = clsApplicationType.Find(5).Fees.ToString();
            lblFine.Text = DLicense.Fees.ToString();
            lblTFees.Text = (DLicense.Fees + Single.Parse(lblAppFees.Text)).ToString();
            lblLicenseID.Text = DLicense.LicenseID.ToString();
            lblUser.Text = clsUser.Find(DLicense.CreatedByUserID).UserName;
            lblAppID.Text = DLicense.ReleaseAppID == -1 ? clsUtil.Default : DLicense.ReleaseAppID.ToString();
        }
    }
}
