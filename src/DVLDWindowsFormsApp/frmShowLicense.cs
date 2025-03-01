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
    public partial class frmShowLicense : Form
    {
        int _GeneralAppID;
        public frmShowLicense(int GeneralAppID)
        {
            InitializeComponent();
            _GeneralAppID = GeneralAppID;
        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            int LicenseID = clsLicense.FindByGenerlAppID(_GeneralAppID).ID;
            ctrlDriverLicense1.LoadInfo(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
