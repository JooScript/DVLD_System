using BusinessLayer;
using DVLDWindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class frmTestAppointments : Form
    {
        public enum enType
        {
            Vision = 1,
            Writing = 2,
            Street = 3
        };

        enType _TestType;
        private int _LocalAppID;
        private DataTable _AppointmentsDataTable = new DataTable();
        public frmTestAppointments(enType Type, int LocalAppID)
        {
            InitializeComponent();
            this._TestType = Type;
            this._LocalAppID = LocalAppID;
        }

        private void _RefreshAppointmentsList()
        {
            _AppointmentsDataTable = clsAppointment.GetAllAppointments(_LocalAppID, (int)_TestType);
            dgvAllAppointments.DataSource = _AppointmentsDataTable;
            lblRecords.Text = $"#Records: {dgvAllAppointments.Rows.Count}";
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            switch (_TestType)
            {
                case enType.Vision:
                    {
                        lblTitle.Text = "Vision Test Appointment";
                        this.Text = "Vision Test Appointment";
                        pcTitlePic.Image = Resources.Eye;
                        break;
                    }
                case enType.Writing:
                    {
                        lblTitle.Text = "Writing Test Appointment";
                        this.Text = "Writing Test Appointment";
                        pcTitlePic.Image = Resources.Docss;
                        break;
                    }
                case enType.Street:
                    {
                        lblTitle.Text = "Street Test Appointment";
                        this.Text = "Street Test Appointment";
                        pcTitlePic.Image = Resources.Car;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            ctrlDrivingLicenseApplicationInfo1.LoadInfo(_LocalAppID);
            ctrlApplicationBasicInfo1.LoadInfo(clsLocalDrivingLicenseApplication.Find(_LocalAppID).GeneralAppID);
            _RefreshAppointmentsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsAppointment.IsAppointmentActive(_LocalAppID, (int)_TestType))
            {
                MessageBox.Show("Person already have an active appointment for this test, you cannot add new appoointment", "EROOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsAppointment.IsTestPassed(_LocalAppID, (int)_TestType))
            {
                MessageBox.Show("This Person Passed This Test Before, You can only retake faild test", "EROOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest.Retake = clsAppointment.IsPastAppointmentExist(_LocalAppID, (int)_TestType);
            frmScheduleTest frm = new frmScheduleTest(_TestType, _LocalAppID, -1);
            frm.ShowDialog();
            _RefreshAppointmentsList();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_TestType, _LocalAppID, (int)dgvAllAppointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAppointmentsList();
        }

        private void miTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest(_TestType, _LocalAppID, (int)dgvAllAppointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            ctrlDrivingLicenseApplicationInfo1.LoadInfo(_LocalAppID);
            _RefreshAppointmentsList();
        }

        private void AppointmentsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dgvAllAppointments.CurrentRow.Cells[3].Value)
            {
                miEdit.Enabled = false;
                miTakeTest.Enabled = false;
            }
            else
            {
                miEdit.Enabled = true;
                miTakeTest.Enabled = true;
            }
        }
    }
}
