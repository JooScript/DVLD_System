using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class frmAddEditPerson : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        private enMode _Mode;
        int _PersonID;
        clsPerson _Person = new clsPerson();

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _Person.PersonID);
            this.Close();
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = _PersonID == -1 ? enMode.AddNew : enMode.Update;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add Person";
                this.Text = "Add Person";
                lblPersonID.Visible = false;
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();
                return;
            }

            lblTitle.Text = "Update Person";
            this.Text = "Update Person";
            lblPersonID.Visible = true;
            lblPersonID.Text = "PersonID: " + _Person.PersonID.ToString();
            pcPerson.LoadPersonInfo(_PersonID);
            btnSave.Text = "Update";
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _SavePerson()
        {
            int CountryID = clsCountry.Find(pcPerson.Country).ID;

            _Person.FirstName = pcPerson.FirstName;
            _Person.SecondName = pcPerson.SecondName;
            _Person.ThirdName = pcPerson.ThirdName;
            _Person.LastName = pcPerson.LastName;
            _Person.NationalNo = pcPerson.NationalNo.ToUpper();
            _Person.Email = pcPerson.Email;
            _Person.Phone = pcPerson.Phone;
            _Person.Address = pcPerson.Address;
            _Person.DateOfBirth = pcPerson.DateOfBirth;
            _Person.NationalityCountryID = CountryID;
            _Person.Gendor = pcPerson.Gendor;

            if (pcPerson.PersonImage != null)
            {
                _Person.ImagePath = pcPerson.PersonImage;
            }
            else
            {
                _Person.ImagePath = null;
            }

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
                btnSave.Text = "Update";
                lblPersonID.Visible = true;
                _PersonID = _Person.PersonID;
                lblPersonID.Text = "PersonID: " + _Person.PersonID.ToString();
            }
            else
            {
                MessageBox.Show("Data Is not Saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            ctrlPersonCard.FillExictedNationalNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SavePerson();
        }

    }
}
