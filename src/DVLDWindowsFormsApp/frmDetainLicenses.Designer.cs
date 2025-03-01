namespace DVLDWindowsFormsApp
{
    partial class frmDetainLicense
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
            this.ctrlFilterLI = new DVLDWindowsFormsApp.ctrlFilterLicenseInfo();
            this.ctrlDInfo = new DVLDWindowsFormsApp.ctrlDetainInfo();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lllHistory = new System.Windows.Forms.LinkLabel();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(269, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License";
            // 
            // ctrlFilterLI
            // 
            this.ctrlFilterLI.Location = new System.Drawing.Point(16, 50);
            this.ctrlFilterLI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlFilterLI.Name = "ctrlFilterLI";
            this.ctrlFilterLI.Size = new System.Drawing.Size(821, 480);
            this.ctrlFilterLI.TabIndex = 1;
            this.ctrlFilterLI.OnLicenseFound += new System.Action<int>(this.ctrlFilterLI_OnLicenseFound);
            this.ctrlFilterLI.OnLicenseNotFound += new System.Action<int>(this.ctrlFilterLI_OnLicenseNotFound);
            // 
            // ctrlDInfo
            // 
            this.ctrlDInfo.Location = new System.Drawing.Point(112, 523);
            this.ctrlDInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlDInfo.Name = "ctrlDInfo";
            this.ctrlDInfo.Size = new System.Drawing.Size(552, 210);
            this.ctrlDInfo.TabIndex = 2;
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(719, 741);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(100, 28);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(611, 741);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lllHistory
            // 
            this.lllHistory.AutoSize = true;
            this.lllHistory.Location = new System.Drawing.Point(12, 737);
            this.lllHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lllHistory.Name = "lllHistory";
            this.lllHistory.Size = new System.Drawing.Size(135, 16);
            this.lllHistory.TabIndex = 5;
            this.lllHistory.TabStop = true;
            this.lllHistory.Text = "Show Lisence History";
            this.lllHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllHistory_LinkClicked);
            // 
            // llInfo
            // 
            this.llInfo.AutoSize = true;
            this.llInfo.Location = new System.Drawing.Point(165, 737);
            this.llInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(114, 16);
            this.llInfo.TabIndex = 6;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "Show License Info";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 772);
            this.Controls.Add(this.llInfo);
            this.Controls.Add(this.lllHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.ctrlFilterLI);
            this.Controls.Add(this.ctrlDInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlFilterLicenseInfo ctrlFilterLI;
        private ctrlDetainInfo ctrlDInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lllHistory;
        private System.Windows.Forms.LinkLabel llInfo;
    }
}