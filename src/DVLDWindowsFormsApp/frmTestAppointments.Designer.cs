namespace DVLDWindowsFormsApp
{
    partial class frmTestAppointments
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
            this.pcTitlePic = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllAppointments = new System.Windows.Forms.DataGridView();
            this.AppointmentsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLDWindowsFormsApp.ctrlDrivingLicenseApplicationInfo();
            this.ctrlApplicationBasicInfo1 = new DVLDWindowsFormsApp.ctrlApplicationBasicInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pcTitlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).BeginInit();
            this.AppointmentsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcTitlePic
            // 
            this.pcTitlePic.Image = global::DVLDWindowsFormsApp.Properties.Resources.Car;
            this.pcTitlePic.Location = new System.Drawing.Point(339, 0);
            this.pcTitlePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcTitlePic.Name = "pcTitlePic";
            this.pcTitlePic.Size = new System.Drawing.Size(204, 108);
            this.pcTitlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcTitlePic.TabIndex = 2;
            this.pcTitlePic.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(213, 112);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(379, 52);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Test Appointment";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(783, 562);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Schedule Test";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 569);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appointments:";
            // 
            // dgvAllAppointments
            // 
            this.dgvAllAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAppointments.ContextMenuStrip = this.AppointmentsMenuStrip;
            this.dgvAllAppointments.Location = new System.Drawing.Point(20, 602);
            this.dgvAllAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAllAppointments.Name = "dgvAllAppointments";
            this.dgvAllAppointments.ReadOnly = true;
            this.dgvAllAppointments.RowHeadersWidth = 51;
            this.dgvAllAppointments.Size = new System.Drawing.Size(879, 246);
            this.dgvAllAppointments.TabIndex = 6;
            // 
            // AppointmentsMenuStrip
            // 
            this.AppointmentsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AppointmentsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEdit,
            this.miTakeTest});
            this.AppointmentsMenuStrip.Name = "AppointmentsMenuStrip";
            this.AppointmentsMenuStrip.Size = new System.Drawing.Size(211, 80);
            this.AppointmentsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AppointmentsMenuStrip_Opening);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(210, 24);
            this.miEdit.Text = "Edit";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miTakeTest
            // 
            this.miTakeTest.Name = "miTakeTest";
            this.miTakeTest.Size = new System.Drawing.Size(210, 24);
            this.miTakeTest.Text = "Take Test";
            this.miTakeTest.Click += new System.EventHandler(this.miTakeTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(799, 855);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(16, 859);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(85, 20);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "Records:";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(67, 151);
            this.ctrlDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(809, 106);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(16, 251);
            this.ctrlApplicationBasicInfo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(891, 314);
            this.ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 922);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAllAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcTitlePic);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcTitlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).EndInit();
            this.AppointmentsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.PictureBox pcTitlePic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ContextMenuStrip AppointmentsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miTakeTest;
    }
}