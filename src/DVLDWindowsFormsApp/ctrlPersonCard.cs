using DVLDWindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Collections.Specialized;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlPersonCard : UserControl
    {
        clsPerson _Person = new clsPerson();

        static private List<string> _ExictedNationalNos = new List<string>();

        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
        }
        public string SecondName
        {
            get
            {
                return txtSecondName.Text;
            }
        }
        public string ThirdName
        {
            get
            {
                return txtThirdName.Text;
            }
        }
        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
        }
        public string NationalNo
        {
            get
            {
                return txtNationalNo.Text;
            }
        }
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }
        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
        }
        public string Phone
        {
            get
            {
                return txtPhone.Text;
            }
        }
        public string Gendor
        {
            get
            {
                if (rbMale.Checked)
                {
                    return rbMale.Text;
                }
                else
                {
                    return rbFemale.Text;
                }
            }
        }
        public string PersonImage
        {
            get
            {
                return pbPersonImage.ImageLocation;
            }
        }
        public string Country
        {
            get
            {
                return cbCountry.Text;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return dtpDateOfBirth.Value;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            if (_Person.Gendor == "Male")
            {
                rbMale.Checked = true;
            }
            else if (_Person.Gendor == "Female")
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
            if (_Person.ImagePath != "")
            {
                if (File.Exists(_Person.ImagePath))
                {
                    pbPersonImage.Load(_Person.ImagePath);
                    pbPersonImage.Tag = "0";
                }
                else
                {
                    _DefaultPhoto();
                }
            }
            else
            {
                _DefaultPhoto();
            }
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);
            dtpDateOfBirth.Value = _Person.DateOfBirth;
        }

        private void _DefaultPhoto()
        {
            if (rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male;
                pbPersonImage.Tag = "Male";
            }
            else
            {
                pbPersonImage.Image = Resources.Female;
                pbPersonImage.Tag = "Female";
            }
            llRRemove.Visible = false;
        }

        private void _FillCountries()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        static public void FillExictedNationalNo()
        {
            DataTable dtPeople = clsPerson.GetAllPeople();

            foreach (DataRow row in dtPeople.Rows)
            {
                _ExictedNationalNos.Add((row["National No"]).ToString().ToLower());
            }
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
            _FillCountries();
            FillExictedNationalNo();
            if (pbPersonImage.Tag.ToString() != "0")
            {
                llRRemove.Visible = false;
            }
            cbCountry.SelectedIndex = 50;
            dtpDateOfBirth.MaxDate = (DateTime.Now).AddYears(-18);
            dtpDateOfBirth.MinDate = (DateTime.Now).AddYears(-150);
        }

        private void llChangeImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Title = "Choose Picture";
            OpenFileDialog.DefaultExt = "png";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (pbPersonImage.Tag.ToString() == "0")
                {
                    clsUtil.DeleteFile(pbPersonImage.ImageLocation);
                }
                clsUtil.CopyFile(OpenFileDialog.FileName, out string Destination);
                pbPersonImage.Load(Destination);
                pbPersonImage.Tag = "0";
                llRRemove.Visible = true;
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.Tag.ToString() != "0")
            {
                if (rbMale.Checked)
                {
                    pbPersonImage.Image = Resources.Male;
                    pbPersonImage.Tag = "Male";
                }
                else
                {
                    pbPersonImage.Image = Resources.Female;
                    pbPersonImage.Tag = "Female";
                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                ErrorProvider.SetError(txtFirstName, "FirstName should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                e.Cancel = true;
                txtSecondName.Focus();
                ErrorProvider.SetError(txtSecondName, "SecondName should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtSecondName, "");
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                ErrorProvider.SetError(txtNationalNo, "NationalNo should have a value");
            }
            else if (_ExictedNationalNos.Contains(txtNationalNo.Text.ToLower()))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                ErrorProvider.SetError(txtNationalNo, "NationalNo Repeated");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtNationalNo, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                ErrorProvider.SetError(txtPhone, "Phone should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtPhone, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                ErrorProvider.SetError(txtEmail, "Email should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtEmail, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                ErrorProvider.SetError(txtAddress, "Address should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtAddress, "");
            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {
                e.Cancel = true;
                txtThirdName.Focus();
                ErrorProvider.SetError(txtThirdName, "Third Name should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtThirdName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                ErrorProvider.SetError(txtLastName, "Last Name should have a value");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtLastName, "");
            }
        }

        private void llRRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pbPersonImage.Tag.ToString() == "0")
            {
                clsUtil.DeleteFile(pbPersonImage.ImageLocation);
            }
            _DefaultPhoto();
        }

    }
}