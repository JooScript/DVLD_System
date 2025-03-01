namespace DVLDWindowsFormsApp
{
    partial class frmChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.liLogInInfo = new DVLDWindowsFormsApp.ctrlLogInInfo();
            this.piPersonInfo = new DVLDWindowsFormsApp.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Current Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Confirm Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(177, 425);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(142, 20);
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Location = new System.Drawing.Point(177, 462);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(142, 20);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(177, 497);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(142, 20);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(509, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(612, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // liLogInInfo
            // 
            this.liLogInInfo.Location = new System.Drawing.Point(39, 308);
            this.liLogInInfo.Name = "liLogInInfo";
            this.liLogInInfo.Size = new System.Drawing.Size(616, 107);
            this.liLogInInfo.TabIndex = 8;
            // 
            // piPersonInfo
            // 
            this.piPersonInfo.Location = new System.Drawing.Point(12, 12);
            this.piPersonInfo.Name = "piPersonInfo";
            this.piPersonInfo.Size = new System.Drawing.Size(675, 290);
            this.piPersonInfo.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 531);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.liLogInInfo);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.piPersonInfo);
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonInfo piPersonInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private ctrlLogInInfo liLogInInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}