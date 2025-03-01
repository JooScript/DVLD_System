using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class frmAddEditLocalDrivingLicenseApplication : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };
        private enMode _Mode;
        private clsLocalDrivingLicenseApplication _App;
        private int _AppID;
        private bool _IsOpenToAddApp = false;

        public frmAddEditLocalDrivingLicenseApplication(int AppID)
        {
            InitializeComponent();
            this._AppID = AppID;
            _Mode = _AppID == -1 ? enMode.AddNew : enMode.Update;
        }

        private void _FillClasses()
        {
            foreach (DataRow row in clsLicenseClass.GetAllLicenseClasses().Rows)
            {
                cbClasses.Items.Add(row["Name"]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ValidateIsOpenToAddApp();
            _SaveApp();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcAddApp.SelectedTab = tpApplicationInfo;
        }

        private void _ProceduresToUpdate()
        {
            lblTitle.Text = "Update Local Driving License Applications";
            this.Text = "Update Local Driving License Applications";
            btnSave.Text = "Update";
            btnSave.Enabled = false;
            btnNext.Enabled = true;
            ctrlFilterPersonalInfo.SelectFilterIndex(2);
            ctrlFilterPersonalInfo.EnablingFiltering(false);
            lblIDTitle.Visible = true;
            lblID.Visible = true;
            _AppID = _App.ID;
            lblID.Text = _AppID.ToString();
            lblDate.Text = _App.AppDate.ToShortDateString();
            lblFees.Text = _App.Fees.ToString();
            lblUser.Text = clsUser.Find(_App.UserID).UserName;
            cbClasses.Text = clsLicenseClass.Find(_App.LicenseClassID).Name;
        }

        private void _LoadData()
        {
            _FillClasses();
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add Local Driving License Applications";
                this.Text = "Add Local Driving License Applications";
                lblID.Visible = false;
                lblIDTitle.Visible = false;
                _App = new clsLocalDrivingLicenseApplication();
                ctrlFilterPersonalInfo.SelectFilterIndex(2);
                cbClasses.SelectedIndex = 0;
                int ClassID = clsLicenseClass.Find(cbClasses.Text).ID;
                lblFees.Text = clsApplicationType.Find(1).Fees.ToString();
                lblDate.Text = DateTime.Now.ToShortDateString();
                lblUser.Text = clsUser.Find(clsUtil.UserID).UserName;
                return;
            }

            _App = clsLocalDrivingLicenseApplication.Find(_AppID);

            if (_App == null)
            {
                MessageBox.Show("This form will be closed because No Application with ID = " + _AppID);
                this.Close();
                return;
            }
            _ProceduresToUpdate();
            ctrlFilterPersonalInfo.LoadPersonInfo(_App.PersonID);
        }

        private void frmAddEditLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _EnablingEnteringAppInfo()
        {
            if (ctrlFilterPersonalInfo.IsFound)
            {
                btnNext.Enabled = true;
                if (_Mode == enMode.AddNew)
                {
                    btnSave.Enabled = true;
                }
            }
            else
            {
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                tcAddApp.SelectedTab = tpPersonalInfo;
            }
        }

        private void ctrlFilterPersonalInfo_OnPersonFound(int obj)
        {
            _EnablingEnteringAppInfo();
        }

        private void _SaveApp()
        {
            if (!_IsOpenToAddApp)
            {
                MessageBox.Show($"Choose another license class, the selected Person Already have an active application for the selected class ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            _App.PersonID = ctrlFilterPersonalInfo.PersonID;
            _App.UserID = clsUtil.UserID;
            _App.LicenseClassID = clsLicenseClass.Find(cbClasses.Text).ID;
            _App.Fees = Single.Parse(lblFees.Text);

            if (_App.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _Mode = enMode.Update;
                _ProceduresToUpdate();
            }
            else
            {
                MessageBox.Show("Data Is not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void tpApplicationInfo_Enter(object sender, EventArgs e)
        {
            _EnablingEnteringAppInfo();
        }

        private void _ValidateIsOpenToAddApp()
        {
            string NationalNo = clsPerson.Find(ctrlFilterPersonalInfo.PersonID).NationalNo;
            string ClassName = cbClasses.Text;
            _IsOpenToAddApp = clsLocalDrivingLicenseApplication.IsOpenToAddApp(NationalNo, ClassName);
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = !(cbClasses.Text == clsLicenseClass.Find(_App.LicenseClassID).Name);
            }
        }
    }
}