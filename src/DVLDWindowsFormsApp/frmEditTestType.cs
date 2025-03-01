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
    public partial class frmEditTestType : Form
    {

        int _TestTypeID;
        clsTestType _TestType = new clsTestType();

        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveTestType();
        }

        private void _SaveTestType()
        {
            _TestType.Title = txtTitle.Text;
            _TestType.Title = txtDescription.Text;
            if (float.TryParse(txtFees.Text.ToString(), out float Fees))
            {
                _TestType.Fees = Fees;
            }
            else
            {
                MessageBox.Show("Fees Should Be A Number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _TestTypeID = _TestType.ID;
                lblID.Text = _TestType.ID.ToString();
            }
            else
            {
                MessageBox.Show("Data Is not Saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void _LoadData()
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show("This form will be closed because No Test Type with ID = " + _TestTypeID);
                this.Close();
                return;
            }

            lblID.Text = _TestType.ID.ToString();
            txtTitle.Text = _TestType.Title.ToString();
            txtDescription.Text = _TestType.Description.ToString();
            txtFees.Text = _TestType.Fees.ToString();
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtTitle.Focus();
                errorProvider1.SetError(txtDescription, "Description Should not be blank");
                btnSave.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
                btnSave.Enabled = true;
            }
        }
    }
}
