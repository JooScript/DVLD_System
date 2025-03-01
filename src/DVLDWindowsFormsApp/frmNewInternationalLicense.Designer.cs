namespace DVLDWindowsFormsApp
{
    partial class frmNewInternationalLicense
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlILicenseInfo = new DVLDWindowsFormsApp.ctrlInternationalAppLicenseInfo();
            this.ctrlFilterLicenseInfo = new DVLDWindowsFormsApp.ctrlFilterLicenseInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "New International License";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(447, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(528, 609);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 23);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Location = new System.Drawing.Point(12, 615);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.llShowLicenseHistory.TabIndex = 5;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(127, 615);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.llShowLicenseInfo.TabIndex = 6;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // ctrlILicenseInfo
            // 
            this.ctrlILicenseInfo.Location = new System.Drawing.Point(63, 418);
            this.ctrlILicenseInfo.Name = "ctrlILicenseInfo";
            this.ctrlILicenseInfo.Size = new System.Drawing.Size(460, 190);
            this.ctrlILicenseInfo.TabIndex = 2;
            // 
            // ctrlFilterLicenseInfo
            // 
            this.ctrlFilterLicenseInfo.Location = new System.Drawing.Point(2, 32);
            this.ctrlFilterLicenseInfo.Name = "ctrlFilterLicenseInfo";
            this.ctrlFilterLicenseInfo.Size = new System.Drawing.Size(616, 390);
            this.ctrlFilterLicenseInfo.TabIndex = 0;
            this.ctrlFilterLicenseInfo.OnLicenseFound += new System.Action<int>(this.ctrlFilterLicenseInfo_OnLicenseFound);
            this.ctrlFilterLicenseInfo.OnLicenseNotFound += new System.Action<int>(this.ctrlFilterLicenseInfo_OnLicenseNotFound);
            // 
            // frmNewInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 637);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlILicenseInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFilterLicenseInfo);
            this.Name = "frmNewInternationalLicense";
            this.Text = "New International License";
            this.Load += new System.EventHandler(this.frmNewInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterLicenseInfo ctrlFilterLicenseInfo;
        private System.Windows.Forms.Label label1;
        private ctrlInternationalAppLicenseInfo ctrlILicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}