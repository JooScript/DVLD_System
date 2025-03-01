namespace DVLDWindowsFormsApp
{
    partial class frmReplacementForDamagedLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.llHistory = new System.Windows.Forms.LinkLabel();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlFLInfo = new DVLDWindowsFormsApp.ctrlFilterLicenseInfo();
            this.ctrlRLAppInfo = new DVLDWindowsFormsApp.ctrlReplacementLicenseAppInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replacement For Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLost);
            this.groupBox1.Controls.Add(this.rbDamaged);
            this.groupBox1.Location = new System.Drawing.Point(452, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For:";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Checked = true;
            this.rbLost.Location = new System.Drawing.Point(6, 40);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(85, 17);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Tag = "4";
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(6, 19);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(111, 17);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.Tag = "3";
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(468, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(549, 552);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 36);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue Replacement";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // llHistory
            // 
            this.llHistory.AutoSize = true;
            this.llHistory.Location = new System.Drawing.Point(12, 552);
            this.llHistory.Name = "llHistory";
            this.llHistory.Size = new System.Drawing.Size(114, 13);
            this.llHistory.TabIndex = 5;
            this.llHistory.TabStop = true;
            this.llHistory.Text = "Show Licenses History";
            this.llHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHistory_LinkClicked);
            // 
            // llInfo
            // 
            this.llInfo.AutoSize = true;
            this.llInfo.Location = new System.Drawing.Point(146, 552);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(120, 13);
            this.llInfo.TabIndex = 6;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "Show New License Info";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // ctrlFLInfo
            // 
            this.ctrlFLInfo.Location = new System.Drawing.Point(12, 37);
            this.ctrlFLInfo.Name = "ctrlFLInfo";
            this.ctrlFLInfo.Size = new System.Drawing.Size(616, 390);
            this.ctrlFLInfo.TabIndex = 0;
            this.ctrlFLInfo.OnLicenseFound += new System.Action<int>(this.ctrlFLInfo_OnLicenseFound);
            this.ctrlFLInfo.OnLicenseNotFound += new System.Action<int>(this.ctrlFLInfo_OnLicenseNotFound);
            // 
            // ctrlRLAppInfo
            // 
            this.ctrlRLAppInfo.Location = new System.Drawing.Point(6, 433);
            this.ctrlRLAppInfo.Name = "ctrlRLAppInfo";
            this.ctrlRLAppInfo.Size = new System.Drawing.Size(612, 113);
            this.ctrlRLAppInfo.TabIndex = 7;
            // 
            // frmReplacementForDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 594);
            this.Controls.Add(this.ctrlRLAppInfo);
            this.Controls.Add(this.llInfo);
            this.Controls.Add(this.llHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFLInfo);
            this.Name = "frmReplacementForDamagedLicense";
            this.Text = "Replacement For Damaged License";
            this.Load += new System.EventHandler(this.frmReplacementForDamagedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterLicenseInfo ctrlFLInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel llHistory;
        private System.Windows.Forms.LinkLabel llInfo;
        private ctrlReplacementLicenseAppInfo ctrlRLAppInfo;
    }
}