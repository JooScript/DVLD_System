namespace DVLDWindowsFormsApp
{
    partial class frmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            this.AddUserTabControl = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlFilterPersonalInfo = new DVLDWindowsFormsApp.ctrlFilterPersonalInfo();
            this.AddUserTabControl.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserTabControl
            // 
            this.AddUserTabControl.Controls.Add(this.tpPersonalInfo);
            this.AddUserTabControl.Controls.Add(this.tpLoginInfo);
            this.AddUserTabControl.Location = new System.Drawing.Point(12, 51);
            this.AddUserTabControl.Name = "AddUserTabControl";
            this.AddUserTabControl.SelectedIndex = 0;
            this.AddUserTabControl.Size = new System.Drawing.Size(708, 441);
            this.AddUserTabControl.TabIndex = 0;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.ctrlFilterPersonalInfo);
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(700, 415);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personl Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(612, 375);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.cbIsActive);
            this.tpLoginInfo.Controls.Add(this.lblUserName);
            this.tpLoginInfo.Controls.Add(this.lblPassword);
            this.tpLoginInfo.Controls.Add(this.lblConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(700, 415);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Tag = "";
            this.tpLoginInfo.Text = "LogIn Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            this.tpLoginInfo.Enter += new System.EventHandler(this.tpLoginInfo_Enter);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(161, 44);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(47, 16);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "?????";
            this.lblUserID.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(161, 93);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 20);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(161, 189);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(161, 216);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(76, 17);
            this.cbIsActive.TabIndex = 4;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            this.cbIsActive.CheckedChanged += new System.EventHandler(this.cbIsActive_CheckedChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(70, 93);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(76, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 191);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(135, 16);
            this.lblConfirmPassword.TabIndex = 1;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.Location = new System.Drawing.Point(92, 44);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(63, 16);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID:";
            this.lblUserIDTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(285, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add User";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(645, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(532, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ctrlFilterPersonalInfo
            // 
            this.ctrlFilterPersonalInfo.Location = new System.Drawing.Point(7, 8);
            this.ctrlFilterPersonalInfo.Name = "ctrlFilterPersonalInfo";
            this.ctrlFilterPersonalInfo.Size = new System.Drawing.Size(687, 361);
            this.ctrlFilterPersonalInfo.TabIndex = 3;
            this.ctrlFilterPersonalInfo.OnPersonFound += new System.Action<int>(this.ctrlFilterPersonalInfo_OnPersonFound);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.AddUserTabControl);
            this.Name = "frmAddEditUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.AddUserTabControl.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AddUserTabControl;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private ctrlFilterPersonalInfo ctrlFilterPersonalInfo;
    }
}