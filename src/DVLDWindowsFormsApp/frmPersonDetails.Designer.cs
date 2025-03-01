namespace DVLDWindowsFormsApp
{
    partial class frmPersonDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.piPersonInfo = new DVLDWindowsFormsApp.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(245, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Person Info";
            // 
            // piPersonInfo
            // 
            this.piPersonInfo.Location = new System.Drawing.Point(2, 43);
            this.piPersonInfo.Name = "piPersonInfo";
            this.piPersonInfo.Size = new System.Drawing.Size(688, 288);
            this.piPersonInfo.TabIndex = 1;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 343);
            this.Controls.Add(this.piPersonInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPersonDetails";
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlPersonInfo piPersonInfo;
    }
}