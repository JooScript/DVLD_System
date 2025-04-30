using BusinessLayer;
using DVLDWindowsFormsApp.Properties;
using System.Windows.Forms;
using System.IO;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlPersonInfo : UserControl
    {
        clsPerson _Person = new clsPerson();
        private int _PersonID;

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get
            {
                if (int.TryParse(lblPersonID.Text, out int PersonIDInt))
                {
                    return PersonIDInt;
                }
                else
                {
                    return -1;
                }
            }
        }

        private void _DefaultPhoto()
        {
            if (lblGendor.Text == "Male")
            {
                pbPersonImage.Image = Resources.Male;
                pbPersonImage.Tag = "Male";
            }
            else if (lblGendor.Text == "Female")
            {
                pbPersonImage.Image = Resources.Female;
                pbPersonImage.Tag = "Female";
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                return;
            }
            llEditPerson.Visible = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _PersonID.ToString();
            lblName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblPhone.Text = _Person.Phone;
            lblGendor.Text = _Person.Gendor;

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
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblDateofBirth.Text = _Person.DateOfBirth.ToShortDateString();
        }

        public void ConvertToDefault()
        {
            lblPersonID.Text = "?????";
            lblName.Text = "?????";
            lblNationalNo.Text = "?????";
            lblGendor.Text = "?????";
            lblEmail.Text = "?????";
            lblAddress.Text = "?????";
            lblDateofBirth.Text = "?????";
            lblPhone.Text = "?????";
            lblCountry.Text = "?????";
            pbPersonImage.Image = Resources.Male;
            llEditPerson.Visible = false;
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }

    }
}