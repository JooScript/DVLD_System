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
    public partial class ctrlFilterPersonalInfo : UserControl
    {
        public ctrlFilterPersonalInfo()
        {
            InitializeComponent();
        }

        private bool _IsFound = false;

        public bool IsFound
        {
            get
            {
                return _IsFound;
            }
        }

        public int PersonID
        {
            get
            {
                return piPersonInfo.PersonID;
            }
        }

        public event Action<int> OnPersonFound;

        protected virtual void PersonFound(int PersonID)
        {
            Action<int> handler = OnPersonFound;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        private void _FiringPersonFoundEvent()
        {
            if (OnPersonFound != null)
            {
                PersonFound(piPersonInfo.PersonID);
            }
        }

        private void PersonID_DataBack(object sender, int PersonID)
        {
            if (PersonID != -1)
            {
                piPersonInfo.LoadPersonInfo(PersonID);
                cbFilter.SelectedIndex = 2;
                txtFilter.Text = PersonID.ToString();
                _IsFound = true;
                _FiringPersonFoundEvent();
            }
            else
            {
                piPersonInfo.ConvertToDefault();
                _IsFound = false;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += PersonID_DataBack;
            frm.ShowDialog();
        }

        public void SelectFilterIndex(int Index)
        {
            cbFilter.SelectedIndex = Index;
        }

        public void EnablingFiltering(bool EnablingMode)
        {
            gbFilter.Enabled = EnablingMode;
        }

        public void LoadPersonInfo(int PersonID)
        {
            piPersonInfo.LoadPersonInfo(PersonID);
            _IsFound = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPerson Person = new clsPerson();

            if (cbFilter.SelectedIndex == 1)
            {
                Person = clsPerson.Find(txtFilter.Text);
            }

            if (cbFilter.SelectedIndex == 2)
            {
                if (int.TryParse(txtFilter.Text, out int Result))
                {
                    Person = clsPerson.Find(Result);
                }
                else
                {
                    Person = null;
                }

            }

            if (Person != null)
            {
                piPersonInfo.LoadPersonInfo(Person.PersonID);
                _IsFound = true;
                _FiringPersonFoundEvent();
            }
            else
            {
                piPersonInfo.ConvertToDefault();
                _IsFound = false;
            }
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedIndex)
            {
                case 1:
                case 2:
                    {
                        txtFilter.Visible = true;
                        break;
                    }
                default:
                    {
                        txtFilter.Visible = false;
                        break;
                    }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
    }
}
