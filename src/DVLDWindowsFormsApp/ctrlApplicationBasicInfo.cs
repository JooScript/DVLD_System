using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsFormsApp
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private int _ID;

        public void LoadInfo(int ID)
        {
            this._ID = ID;
            clsApplication App = clsApplication.Find(_ID);
            lblID.Text = App.ID.ToString();
            lblStatus.Text = App.Status.ToString();
            lblFees.Text = App.PaidFees.ToString();
            lblType.Text = clsApplicationType.Find(App.AppTypeID).Title;
            clsPerson Person = clsPerson.Find(App.PersonID);
            lblApplicant.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblDate.Text = App.Date.ToShortDateString();
            lblStatusDate.Text = App.LastStatusDate.ToShortDateString();
            lblUser.Text = clsUser.Find(App.UserID).UserName;
        }

        private void llPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsApplication App = clsApplication.Find(_ID);
            clsPerson Person = clsPerson.Find(App.PersonID);
            frmPersonDetails frm = new frmPersonDetails(Person.PersonID);
            frm.ShowDialog();
            LoadInfo(_ID);
        }

    }
}
