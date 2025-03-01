namespace DVLDWindowsFormsApp
{
    partial class frmRenewLocalLicense
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
            this.ctrlFLInfo = new DVLDWindowsFormsApp.ctrlFilterLicenseInfo();
            this.ctrlANLicenseInfo = new DVLDWindowsFormsApp.ctrlAppNewLicenseInfo();
            this.tnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.llLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llHistory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(164, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew License Application";
            // 
            // ctrlFLInfo
            // 
            this.ctrlFLInfo.Location = new System.Drawing.Point(12, 28);
            this.ctrlFLInfo.Name = "ctrlFLInfo";
            this.ctrlFLInfo.Size = new System.Drawing.Size(616, 390);
            this.ctrlFLInfo.TabIndex = 1;
            this.ctrlFLInfo.OnLicenseFound += new System.Action<int>(this.ctrlFLInfo_OnLicenseFound);
            this.ctrlFLInfo.OnLicenseNotFound += new System.Action<int>(this.ctrlFLInfo_OnLicenseNotFound);
            // 
            // ctrlANLicenseInfo
            // 
            this.ctrlANLicenseInfo.Location = new System.Drawing.Point(60, 414);
            this.ctrlANLicenseInfo.Name = "ctrlANLicenseInfo";
            this.ctrlANLicenseInfo.Size = new System.Drawing.Size(509, 269);
            this.ctrlANLicenseInfo.TabIndex = 2;
            // 
            // tnClose
            // 
            this.tnClose.Location = new System.Drawing.Point(462, 689);
            this.tnClose.Name = "tnClose";
            this.tnClose.Size = new System.Drawing.Size(75, 23);
            this.tnClose.TabIndex = 3;
            this.tnClose.Text = "Close";
            this.tnClose.UseVisualStyleBackColor = true;
            this.tnClose.Click += new System.EventHandler(this.tnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Location = new System.Drawing.Point(543, 689);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 4;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // llLicenseInfo
            // 
            this.llLicenseInfo.AutoSize = true;
            this.llLicenseInfo.Enabled = false;
            this.llLicenseInfo.Location = new System.Drawing.Point(127, 686);
            this.llLicenseInfo.Name = "llLicenseInfo";
            this.llLicenseInfo.Size = new System.Drawing.Size(125, 13);
            this.llLicenseInfo.TabIndex = 5;
            this.llLicenseInfo.TabStop = true;
            this.llLicenseInfo.Text = "Show New Licenses Info";
            this.llLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseInfo_LinkClicked);
            // 
            // llHistory
            // 
            this.llHistory.AutoSize = true;
            this.llHistory.Enabled = false;
            this.llHistory.Location = new System.Drawing.Point(12, 686);
            this.llHistory.Name = "llHistory";
            this.llHistory.Size = new System.Drawing.Size(109, 13);
            this.llHistory.TabIndex = 6;
            this.llHistory.TabStop = true;
            this.llHistory.Text = "Show License History";
            this.llHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHistory_LinkClicked);
            // 
            // frmRenewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 717);
            this.Controls.Add(this.llHistory);
            this.Controls.Add(this.llLicenseInfo);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.tnClose);
            this.Controls.Add(this.ctrlFLInfo);
            this.Controls.Add(this.ctrlANLicenseInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewLocalLicense";
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlFilterLicenseInfo ctrlFLInfo;
        private ctrlAppNewLicenseInfo ctrlANLicenseInfo;
        private System.Windows.Forms.Button tnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.LinkLabel llLicenseInfo;
        private System.Windows.Forms.LinkLabel llHistory;
    }
}