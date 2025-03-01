namespace DVLDWindowsFormsApp
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationlDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeMenuStrip
            // 
            this.HomeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.peopleToolStripMenuItem1,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.HomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuStrip.Name = "HomeMenuStrip";
            this.HomeMenuStrip.Size = new System.Drawing.Size(1067, 28);
            this.HomeMenuStrip.TabIndex = 0;
            this.HomeMenuStrip.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLisToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem1,
            this.manageTestTypesToolStripMenuItem});
            this.peopleToolStripMenuItem.Image = global::DVLDWindowsFormsApp.Properties.Resources.Report;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.ShowShortcutKeys = false;
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.peopleToolStripMenuItem.Text = "Applications";
            // 
            // drivingLisToolStripMenuItem
            // 
            this.drivingLisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLiToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.replacementForToolStripMenuItem,
            this.toolStripMenuItem4,
            this.releaseDetToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLisToolStripMenuItem.Name = "drivingLisToolStripMenuItem";
            this.drivingLisToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.drivingLisToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLiToolStripMenuItem
            // 
            this.newDrivingLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLiToolStripMenuItem.Name = "newDrivingLiToolStripMenuItem";
            this.newDrivingLiToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.newDrivingLiToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(365, 6);
            // 
            // replacementForToolStripMenuItem
            // 
            this.replacementForToolStripMenuItem.Name = "replacementForToolStripMenuItem";
            this.replacementForToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.replacementForToolStripMenuItem.Text = "Replacement for lost or damaged License";
            this.replacementForToolStripMenuItem.Click += new System.EventHandler(this.replacementForToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(365, 6);
            // 
            // releaseDetToolStripMenuItem
            // 
            this.releaseDetToolStripMenuItem.Name = "releaseDetToolStripMenuItem";
            this.releaseDetToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.releaseDetToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetToolStripMenuItem.Click += new System.EventHandler(this.releaseDetToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationlDrivingLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationlDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.internationlDrivingLicenseApplicationsToolStripMenuItem.Name = "internationlDrivingLicenseApplicationsToolStripMenuItem";
            this.internationlDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.internationlDrivingLicenseApplicationsToolStripMenuItem.Text = "Internationl Driving License Applications";
            this.internationlDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationlDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(271, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetToolStripMenuItem
            // 
            this.manageDetToolStripMenuItem.Name = "manageDetToolStripMenuItem";
            this.manageDetToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.manageDetToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetToolStripMenuItem.Click += new System.EventHandler(this.manageDetToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem1
            // 
            this.manageApplicationsToolStripMenuItem1.Name = "manageApplicationsToolStripMenuItem1";
            this.manageApplicationsToolStripMenuItem1.Size = new System.Drawing.Size(274, 26);
            this.manageApplicationsToolStripMenuItem1.Text = "Manage Applications Types";
            this.manageApplicationsToolStripMenuItem1.Click += new System.EventHandler(this.manageApplicationsToolStripMenuItem1_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem1
            // 
            this.peopleToolStripMenuItem1.Image = global::DVLDWindowsFormsApp.Properties.Resources.People;
            this.peopleToolStripMenuItem1.Name = "peopleToolStripMenuItem1";
            this.peopleToolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.peopleToolStripMenuItem1.Text = "People";
            this.peopleToolStripMenuItem1.Click += new System.EventHandler(this.peopleToolStripMenuItem1_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLDWindowsFormsApp.Properties.Resources.Steering_Wheel;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLDWindowsFormsApp.Properties.Resources.User;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.signOutToolStripMenuItem});
            this.accountToolStripMenuItem.Image = global::DVLDWindowsFormsApp.Properties.Resources.Settings;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.accountToolStripMenuItem.Text = "Account Settings";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.currentToolStripMenuItem.Text = "Current User Info";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DVLDWindowsFormsApp.Properties.Resources.Drive_Cover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HomeMenuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.HomeMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HomeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem replacementForToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem releaseDetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationlDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}

