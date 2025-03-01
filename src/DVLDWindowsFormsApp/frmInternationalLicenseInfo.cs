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
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _ID;
        public frmInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _ID = InternationalLicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrliLicenseInfo.LoadData(_ID);
        }
    }
}