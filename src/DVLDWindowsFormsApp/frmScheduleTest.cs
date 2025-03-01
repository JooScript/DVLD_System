using BusinessLayer;
using DVLDWindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDWindowsFormsApp.frmTestAppointments;

namespace DVLDWindowsFormsApp
{
    public partial class frmScheduleTest : Form
    {
        private enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        private enMode _Mode;
        clsAppointment _Appointment;
        frmTestAppointments.enType _Type;
        private int _LocalAppID;
        private int _AppointmentID;
        public static bool Retake = false;

        public frmScheduleTest(frmTestAppointments.enType Type, int LocalAppID, int AppointmentID)
        {
            InitializeComponent();
            this._Type = Type;
            this._LocalAppID = LocalAppID;
            this._AppointmentID = AppointmentID;
            _Mode = _AppointmentID == -1 ? enMode.AddNew : enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _Appointment = new clsAppointment();
                dtpDate.Value = DateTime.Now;
            }
            else
            {
                _Appointment = clsAppointment.Find(_AppointmentID);
                dtpDate.Value = _Appointment.AppointmentDate;
            }

            dtpDate.MinDate = DateTime.Today;
            clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(_LocalAppID);
            clsPerson Person = clsPerson.Find(App.PersonID);
            lblID.Text = _LocalAppID.ToString();
            lblClass.Text = clsLicenseClass.Find(App.LicenseClassID).Name;
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblTrial.Text = clsLocalDrivingLicenseApplication.GetSpecificTestTrials(_LocalAppID,(int) _Type).ToString();
            lblFees.Text = clsTestType.Find((int)_Type).Fees.ToString();
            gbRetakeTest.Enabled = Retake;
            lblRFees.Text = Retake ? "5" : "0";
            lblTotalFees.Text = (clsTestType.Find((int)_Type).Fees + int.Parse(lblRFees.Text.ToString())).ToString();

            switch (_Type)
            {
                case enType.Vision:
                    {
                        pbMainPic.Image = Resources.Eye;
                        break;
                    }
                case enType.Writing:
                    {
                        pbMainPic.Image = Resources.Docss;
                        break;
                    }
                case enType.Street:
                    {
                        pbMainPic.Image = Resources.Car;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Appointment.TestTypeID = (int)_Type;
            _Appointment.LocalDrivingLicenseApplicationID = _LocalAppID;
            _Appointment.AppointmentDate = dtpDate.Value;
            _Appointment.Fees = Single.Parse(lblTotalFees.Text.ToString());
            _Appointment.UserID = clsUtil.UserID;
            _Appointment.IsLocked = false;

            if (_Appointment.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Is not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
