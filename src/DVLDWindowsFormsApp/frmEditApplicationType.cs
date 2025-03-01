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
    public partial class frmEditApplicationType : Form
    {
        int _ApplicationTypeID;
        clsApplicationType _ApplicationType = new clsApplicationType();

        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SaveApplicationType()
        {
            _ApplicationType.Title = txtTitle.Text;
            if (float.TryParse(txtFees.Text.ToString(), out float Fees))
            {
                _ApplicationType.Fees = Fees;
            }
            else
            {
                MessageBox.Show("Fees Should Be A Number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _ApplicationTypeID = _ApplicationType.ID;
                lblID.Text = _ApplicationType.ID.ToString();
            }
            else
            {
                MessageBox.Show("Data Is not Saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveApplicationType();
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                e.Cancel = true;
                txtFees.Focus();
                errorProvider1.SetError(txtFees, "Fees Should not be blank");
                btnSave.Enabled = false;
            }
            else if (!(float.TryParse(txtFees.Text.ToString(), out float Fees)))
            {
                e.Cancel = true;
                txtFees.Focus();
                errorProvider1.SetError(txtFees, "Fees Should Be A Number");
                btnSave.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, "");
                btnSave.Enabled = true;
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                e.Cancel = true;
                txtTitle.Focus();
                errorProvider1.SetError(txtTitle, "Title Should not be blank");
                btnSave.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "");
                btnSave.Enabled = true;
            }
        }

        private void _LoadData()
        {
            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if (_ApplicationType == null)
            {
                MessageBox.Show("This form will be closed because No Application Type with ID = " + _ApplicationTypeID);
                this.Close();
                return;
            }

            lblID.Text = _ApplicationType.ID.ToString();
            txtTitle.Text = _ApplicationType.Title.ToString();
            txtFees.Text = _ApplicationType.Fees.ToString();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
