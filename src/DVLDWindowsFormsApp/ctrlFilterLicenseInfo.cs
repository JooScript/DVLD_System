using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlFilterLicenseInfo : UserControl
    {
        private bool _IsFound = false;
        private clsLicense _Lisence;
        public ctrlFilterLicenseInfo()
        {
            InitializeComponent();
        }

        public event Action<int> OnLicenseFound;
        protected virtual void LicenseFound(int LicenseID)
        {
            Action<int> handler = OnLicenseFound;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        private void _FireLicenseFound()
        {
            if (OnLicenseFound != null)
            {
                LicenseFound(int.Parse(txtFilter.Text));
            }
        }

        public event Action<int> OnLicenseNotFound;
        protected virtual void LicenseNotFound(int LicenseID)
        {
            Action<int> handler = OnLicenseNotFound;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        private void _FireLicenseNotFound()
        {
            if (OnLicenseNotFound != null)
            {
                LicenseNotFound(-1);
            }
        }

        public int LicenseID
        {
            get
            {
                return _Lisence.ID;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == string.Empty)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }

            if (!int.TryParse(txtFilter.Text, out _))
            {
                if (txtFilter.Text.Length > 0)
                {
                    txtFilter.Text = txtFilter.Text.Substring(0, txtFilter.Text.Length - 1);
                    txtFilter.SelectionStart = txtFilter.Text.Length;
                }
            }
        }

        public void LoadData(int LicenseID)
        {
            gbFilter.Enabled = false;
            txtFilter.Text = LicenseID.ToString();
            ctrlDriverLicense.LoadInfo(LicenseID);
            _Lisence = clsLicense.Find(LicenseID);
        }

        public void RefreshLicense()
        {
            ctrlDriverLicense.LoadInfo(int.Parse(txtFilter.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == String.Empty)
            {
                _IsFound = false;
                ctrlDriverLicense.LoadDefaultData();
                _FireLicenseNotFound();
                return;
            }

            _Lisence = clsLicense.Find(int.Parse(txtFilter.Text));

            if (_Lisence == null)
            {
                _IsFound = false;
                MessageBox.Show($"There is no Local Lisence with ID = {txtFilter.Text}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlDriverLicense.LoadDefaultData();
                _FireLicenseNotFound();
                return;
            }

            _IsFound = true;
            ctrlDriverLicense.LoadInfo(int.Parse(txtFilter.Text));
            _FireLicenseFound();
        }

    }
}