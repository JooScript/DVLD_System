namespace DVLDWindowsFormsApp
{
    partial class frmIssueLicense
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ctrlApplicationBasicInfo1 = new DVLDWindowsFormsApp.ctrlApplicationBasicInfo();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLDWindowsFormsApp.ctrlDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(79, 377);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(590, 92);
            this.txtNotes.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(513, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(594, 475);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 23);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(12, 104);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(668, 255);
            this.ctrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(49, 12);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(607, 86);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmIssueLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 507);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Name = "frmIssueLicense";
            this.Text = "Issue License";
            this.Load += new System.EventHandler(this.frmIssueLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}