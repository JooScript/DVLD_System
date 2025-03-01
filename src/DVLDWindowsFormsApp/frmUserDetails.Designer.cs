namespace DVLDWindowsFormsApp
{
    partial class frmUserDetails
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
            this.piPersonInfo = new DVLDWindowsFormsApp.ctrlPersonInfo();
            this.liLogInInfo = new DVLDWindowsFormsApp.ctrlLogInInfo();
            this.SuspendLayout();
            // 
            // piPersonInfo
            // 
            this.piPersonInfo.Location = new System.Drawing.Point(12, 12);
            this.piPersonInfo.Name = "piPersonInfo";
            this.piPersonInfo.Size = new System.Drawing.Size(675, 290);
            this.piPersonInfo.TabIndex = 0;
            // 
            // liLogInInfo
            // 
            this.liLogInInfo.Location = new System.Drawing.Point(40, 308);
            this.liLogInInfo.Name = "liLogInInfo";
            this.liLogInInfo.Size = new System.Drawing.Size(613, 107);
            this.liLogInInfo.TabIndex = 1;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 419);
            this.Controls.Add(this.liLogInInfo);
            this.Controls.Add(this.piPersonInfo);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo piPersonInfo;
        private ctrlLogInInfo liLogInInfo;
    }
}