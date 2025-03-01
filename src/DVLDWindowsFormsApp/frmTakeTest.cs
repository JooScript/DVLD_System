using BusinessLayer;
using DVLDWindowsFormsApp.Properties;
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
using static DVLDWindowsFormsApp.frmTestAppointments;

namespace DVLDWindowsFormsApp
{
    public partial class frmTakeTest : Form
    {

        private clsTest _Test = new clsTest();
        private clsAppointment _Appointment;
        private frmTestAppointments.enType _Type;
        private int _LocalAppID;
        private int _AppointmentID;

        public frmTakeTest(frmTestAppointments.enType Type, int LocalAppID, int AppointmentID)
        {
            InitializeComponent();
            this._Type = Type;
            this._LocalAppID = LocalAppID;
            this._AppointmentID = AppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
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
                        return;
                    }
            }

            _Appointment = clsAppointment.Find(_AppointmentID);
            clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(_LocalAppID);
            clsPerson Person = clsPerson.Find(App.PersonID);
            lblAppID.Text = App.ID.ToString();
            lblClass.Text = clsLicenseClass.Find(App.LicenseClassID).Name;
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblTrials.Text = clsLocalDrivingLicenseApplication.GetSpecificTestTrials(_LocalAppID, (int)_Type).ToString();
            lblDate.Text = _Appointment.AppointmentDate.ToShortDateString();
            lblFees.Text = _Appointment.Fees.ToString();
            rbFail.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Test.AppointmentID = _Appointment.ID;
            _Test.Result = rbPass.Checked;
            _Test.Notes = txtNotes.Text;
            _Test.UserID = clsUtil.UserID;
            _Appointment.IsLocked = true;

            if (_Test.Save() && _Appointment.Save())
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
