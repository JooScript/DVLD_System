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
    public partial class ctrlDetainInfo : UserControl
    {
        public ctrlDetainInfo()
        {
            InitializeComponent();
        }

        private clsDetainedLicense Detain = new clsDetainedLicense();

        public float Fees
        {
            set
            {
                txtFees.Text = value.ToString();
            }

            get
            {
                return Single.TryParse(txtFees.Text, out float Result) ? Result : 0;
            }
        }

        public void LoadData(int DetainID)
        {
            Detain = clsDetainedLicense.Find(DetainID);
            lblDetainID.Text = Detain.ID.ToString();
            lblDetainDate.Text = Detain.DetainDate.ToShortDateString();
            lblLLicenseID.Text = Detain.LicenseID.ToString();
            lblUser.Text = clsUser.Find(Detain.CreatedByUserID).UserName;
            txtFees.Text = Detain.Fees.ToString();
            txtFees.Enabled = false;
        }

        public void LoadDefaultData()
        {
            lblDetainID.Text = clsUtil.Default;
            lblDetainDate.Text = DateTime.Today.ToShortDateString();
            lblLLicenseID.Text = clsUtil.Default;
            lblUser.Text = clsUser.Find(clsUtil.UserID).UserName;
            txtFees.Text = string.Empty;
            txtFees.Enabled = true;
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFees.Text, out _))
            {
                if (txtFees.Text.Length > 0)
                {
                    txtFees.Text = txtFees.Text.Substring(0, txtFees.Text.Length - 1);
                    txtFees.SelectionStart = txtFees.Text.Length;
                }
            }
        }

    }
}
