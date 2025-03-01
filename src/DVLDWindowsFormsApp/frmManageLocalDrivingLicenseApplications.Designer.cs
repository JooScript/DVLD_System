namespace DVLDWindowsFormsApp
{
    partial class frmManageLocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAllApps = new System.Windows.Forms.DataGridView();
            this.AppsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miShowApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.miIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.miEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.miCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.miSechduleTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.miVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApps)).BeginInit();
            this.AppsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(213, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving License Applications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By:";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(86, 227);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(141, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(693, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Applications";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAllApps
            // 
            this.dgvAllApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllApps.ContextMenuStrip = this.AppsContextMenuStrip;
            this.dgvAllApps.Location = new System.Drawing.Point(15, 260);
            this.dgvAllApps.Name = "dgvAllApps";
            this.dgvAllApps.Size = new System.Drawing.Size(773, 227);
            this.dgvAllApps.TabIndex = 5;
            // 
            // AppsContextMenuStrip
            // 
            this.AppsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShowApplication,
            this.toolStripMenuItem1,
            this.miEditApplication,
            this.miDeleteApplication,
            this.toolStripMenuItem2,
            this.miCancelApplication,
            this.toolStripMenuItem3,
            this.miSechduleTasks,
            this.toolStripMenuItem4,
            this.miIssueDrivingLicense,
            this.toolStripMenuItem5,
            this.miShowLicense,
            this.toolStripMenuItem7,
            this.miShowPersonLicenseHistory});
            this.AppsContextMenuStrip.Name = "AppsContextMenuStrip";
            this.AppsContextMenuStrip.Size = new System.Drawing.Size(226, 216);
            this.AppsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AppsContextMenuStrip_Opening);
            // 
            // miShowApplication
            // 
            this.miShowApplication.Name = "miShowApplication";
            this.miShowApplication.Size = new System.Drawing.Size(225, 22);
            this.miShowApplication.Text = "Show Application Details";
            this.miShowApplication.Click += new System.EventHandler(this.miShowApplication_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // miIssueDrivingLicense
            // 
            this.miIssueDrivingLicense.Name = "miIssueDrivingLicense";
            this.miIssueDrivingLicense.Size = new System.Drawing.Size(225, 22);
            this.miIssueDrivingLicense.Text = "Issue Driving License";
            this.miIssueDrivingLicense.Click += new System.EventHandler(this.miIssueDrivingLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(222, 6);
            // 
            // miShowPersonLicenseHistory
            // 
            this.miShowPersonLicenseHistory.Image = global::DVLDWindowsFormsApp.Properties.Resources.History;
            this.miShowPersonLicenseHistory.Name = "miShowPersonLicenseHistory";
            this.miShowPersonLicenseHistory.Size = new System.Drawing.Size(225, 22);
            this.miShowPersonLicenseHistory.Text = "Show Person License History";
            this.miShowPersonLicenseHistory.Click += new System.EventHandler(this.miShowPersonLicenseHistory_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 498);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 16);
            this.lblRecords.TabIndex = 6;
            this.lblRecords.Text = "Records:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(730, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(233, 228);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(111, 20);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbStatus.Location = new System.Drawing.Point(233, 228);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(111, 21);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // miEditApplication
            // 
            this.miEditApplication.Image = global::DVLDWindowsFormsApp.Properties.Resources.Edit;
            this.miEditApplication.Name = "miEditApplication";
            this.miEditApplication.Size = new System.Drawing.Size(225, 22);
            this.miEditApplication.Text = "Edit Application";
            this.miEditApplication.Click += new System.EventHandler(this.miEditApplication_Click);
            // 
            // miDeleteApplication
            // 
            this.miDeleteApplication.Image = global::DVLDWindowsFormsApp.Properties.Resources.Delete;
            this.miDeleteApplication.Name = "miDeleteApplication";
            this.miDeleteApplication.Size = new System.Drawing.Size(225, 22);
            this.miDeleteApplication.Text = "Delete Application";
            this.miDeleteApplication.Click += new System.EventHandler(this.miDeleteApplication_Click);
            // 
            // miCancelApplication
            // 
            this.miCancelApplication.Image = global::DVLDWindowsFormsApp.Properties.Resources.Cancel;
            this.miCancelApplication.Name = "miCancelApplication";
            this.miCancelApplication.Size = new System.Drawing.Size(225, 22);
            this.miCancelApplication.Text = "Cancel Application";
            this.miCancelApplication.Click += new System.EventHandler(this.miCancelApplication_Click);
            // 
            // miSechduleTasks
            // 
            this.miSechduleTasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVisionTest,
            this.miWrittenTest,
            this.miStreetTest});
            this.miSechduleTasks.Image = global::DVLDWindowsFormsApp.Properties.Resources.Schedule;
            this.miSechduleTasks.Name = "miSechduleTasks";
            this.miSechduleTasks.Size = new System.Drawing.Size(225, 22);
            this.miSechduleTasks.Text = "Sechdule Tests";
            // 
            // miVisionTest
            // 
            this.miVisionTest.Image = global::DVLDWindowsFormsApp.Properties.Resources.Eye;
            this.miVisionTest.Name = "miVisionTest";
            this.miVisionTest.Size = new System.Drawing.Size(180, 22);
            this.miVisionTest.Text = "Vision Test";
            this.miVisionTest.Click += new System.EventHandler(this.miVisionTest_Click);
            // 
            // miWrittenTest
            // 
            this.miWrittenTest.Image = global::DVLDWindowsFormsApp.Properties.Resources.Writing;
            this.miWrittenTest.Name = "miWrittenTest";
            this.miWrittenTest.Size = new System.Drawing.Size(180, 22);
            this.miWrittenTest.Text = "Written Test";
            this.miWrittenTest.Click += new System.EventHandler(this.miWrittenTest_Click);
            // 
            // miStreetTest
            // 
            this.miStreetTest.Image = global::DVLDWindowsFormsApp.Properties.Resources.Car;
            this.miStreetTest.Name = "miStreetTest";
            this.miStreetTest.Size = new System.Drawing.Size(180, 22);
            this.miStreetTest.Text = "Street Test";
            this.miStreetTest.Click += new System.EventHandler(this.miStreetTest_Click);
            // 
            // miShowLicense
            // 
            this.miShowLicense.Image = global::DVLDWindowsFormsApp.Properties.Resources.License;
            this.miShowLicense.Name = "miShowLicense";
            this.miShowLicense.Size = new System.Drawing.Size(225, 22);
            this.miShowLicense.Text = "Show License";
            this.miShowLicense.Click += new System.EventHandler(this.miShowLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLDWindowsFormsApp.Properties.Resources.Docss;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllApps);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmManageLocalDrivingLicenseApplications";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApps)).EndInit();
            this.AppsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAllApps;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip AppsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miShowApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miEditApplication;
        private System.Windows.Forms.ToolStripMenuItem miDeleteApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miSechduleTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem miIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem miShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem miShowPersonLicenseHistory;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem miVisionTest;
        private System.Windows.Forms.ToolStripMenuItem miWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem miStreetTest;
    }
}