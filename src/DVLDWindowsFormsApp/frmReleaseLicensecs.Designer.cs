namespace DVLDWindowsFormsApp
{
    partial class frmReleaseLicense
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
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llHistory = new System.Windows.Forms.LinkLabel();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlFilterLI = new DVLDWindowsFormsApp.ctrlFilterLicenseInfo();
            this.ctrlRDInfo = new DVLDWindowsFormsApp.ctrlReleasedDetainedInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(210, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Detained License";
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(759, 814);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 31);
            this.btnRelease.TabIndex = 3;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(678, 814);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llHistory
            // 
            this.llHistory.AutoSize = true;
            this.llHistory.Location = new System.Drawing.Point(38, 819);
            this.llHistory.Name = "llHistory";
            this.llHistory.Size = new System.Drawing.Size(142, 16);
            this.llHistory.TabIndex = 5;
            this.llHistory.TabStop = true;
            this.llHistory.Text = "Show Licenses History";
            this.llHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHistory_LinkClicked);
            // 
            // llInfo
            // 
            this.llInfo.AutoSize = true;
            this.llInfo.Location = new System.Drawing.Point(213, 819);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(114, 16);
            this.llInfo.TabIndex = 6;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "Show License Info";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // ctrlFilterLI
            // 
            this.ctrlFilterLI.Location = new System.Drawing.Point(13, 27);
            this.ctrlFilterLI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlFilterLI.Name = "ctrlFilterLI";
            this.ctrlFilterLI.Size = new System.Drawing.Size(821, 480);
            this.ctrlFilterLI.TabIndex = 0;
            this.ctrlFilterLI.OnLicenseFound += new System.Action<int>(this.ctrlFilterLI_OnLicenseFound);
            this.ctrlFilterLI.OnLicenseNotFound += new System.Action<int>(this.ctrlFilterLI_OnLicenseNotFound);
            // 
            // ctrlRDInfo
            // 
            this.ctrlRDInfo.Location = new System.Drawing.Point(41, 504);
            this.ctrlRDInfo.Name = "ctrlRDInfo";
            this.ctrlRDInfo.Size = new System.Drawing.Size(745, 312);
            this.ctrlRDInfo.TabIndex = 2;
            // 
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 856);
            this.Controls.Add(this.ctrlFilterLI);
            this.Controls.Add(this.llInfo);
            this.Controls.Add(this.llHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.ctrlRDInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmReleaseLicense";
            this.Text = "Release License";
            this.Load += new System.EventHandler(this.frmReleaseLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterLicenseInfo ctrlFilterLI;
        private System.Windows.Forms.Label label1;
        private ctrlReleasedDetainedInfo ctrlRDInfo;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llHistory;
        private System.Windows.Forms.LinkLabel llInfo;
    }
}