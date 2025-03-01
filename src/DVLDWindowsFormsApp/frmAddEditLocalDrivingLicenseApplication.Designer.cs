namespace DVLDWindowsFormsApp
{
    partial class frmAddEditLocalDrivingLicenseApplication
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
            this.tcAddApp = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFilterPersonalInfo = new DVLDWindowsFormsApp.ctrlFilterPersonalInfo();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblFees = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcAddApp.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAddApp
            // 
            this.tcAddApp.Controls.Add(this.tpPersonalInfo);
            this.tcAddApp.Controls.Add(this.tpApplicationInfo);
            this.tcAddApp.Location = new System.Drawing.Point(12, 43);
            this.tcAddApp.Name = "tcAddApp";
            this.tcAddApp.SelectedIndex = 0;
            this.tcAddApp.Size = new System.Drawing.Size(698, 430);
            this.tcAddApp.TabIndex = 0;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlFilterPersonalInfo);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(690, 404);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(608, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFilterPersonalInfo
            // 
            this.ctrlFilterPersonalInfo.Location = new System.Drawing.Point(6, 3);
            this.ctrlFilterPersonalInfo.Name = "ctrlFilterPersonalInfo";
            this.ctrlFilterPersonalInfo.Size = new System.Drawing.Size(687, 361);
            this.ctrlFilterPersonalInfo.TabIndex = 0;
            this.ctrlFilterPersonalInfo.OnPersonFound += new System.Action<int>(this.ctrlFilterPersonalInfo_OnPersonFound);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.lblFees);
            this.tpApplicationInfo.Controls.Add(this.cbClasses);
            this.tpApplicationInfo.Controls.Add(this.lblUser);
            this.tpApplicationInfo.Controls.Add(this.lblDate);
            this.tpApplicationInfo.Controls.Add(this.lblID);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Controls.Add(this.lblIDTitle);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(690, 404);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            this.tpApplicationInfo.Enter += new System.EventHandler(this.tpApplicationInfo_Enter);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(208, 205);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(59, 20);
            this.lblFees.TabIndex = 10;
            this.lblFees.Text = "?????";
            // 
            // cbClasses
            // 
            this.cbClasses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(205, 154);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(204, 21);
            this.cbClasses.TabIndex = 9;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(201, 254);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 20);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "?????";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(201, 107);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "?????";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(201, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 20);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "?????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date:";
            // 
            // lblIDTitle
            // 
            this.lblIDTitle.AutoSize = true;
            this.lblIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTitle.Location = new System.Drawing.Point(54, 58);
            this.lblIDTitle.Name = "lblIDTitle";
            this.lblIDTitle.Size = new System.Drawing.Size(33, 20);
            this.lblIDTitle.TabIndex = 0;
            this.lblIDTitle.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Local Driving License Applications";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(543, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(624, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 504);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcAddApp);
            this.Name = "frmAddEditLocalDrivingLicenseApplication";
            this.Text = "Add Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddEditLocalDrivingLicenseApplication_Load);
            this.tcAddApp.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddApp;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Label lblTitle;
        private ctrlFilterPersonalInfo ctrlFilterPersonalInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIDTitle;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFees;
    }
}