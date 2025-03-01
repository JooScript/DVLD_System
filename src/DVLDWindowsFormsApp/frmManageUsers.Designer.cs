namespace DVLDWindowsFormsApp
{
    partial class frmManageUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.UsersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.adddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.UsersContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(194, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.UsersContextMenuStrip;
            this.dgvAllUsers.Location = new System.Drawing.Point(12, 246);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.Size = new System.Drawing.Size(609, 316);
            this.dgvAllUsers.TabIndex = 2;
            // 
            // UsersContextMenuStrip
            // 
            this.UsersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.adddToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.pToolStripMenuItem});
            this.UsersContextMenuStrip.Name = "UsersContextMenuStrip";
            this.UsersContextMenuStrip.Size = new System.Drawing.Size(169, 170);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // adddToolStripMenuItem
            // 
            this.adddToolStripMenuItem.Name = "adddToolStripMenuItem";
            this.adddToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.adddToolStripMenuItem.Text = "Add User";
            this.adddToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pToolStripMenuItem.Text = "Phone Call";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 575);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(74, 16);
            this.lblRecords.TabIndex = 3;
            this.lblRecords.Text = "#Records";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(546, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(86, 219);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(146, 21);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(238, 219);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(155, 20);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbIsActive.Location = new System.Drawing.Point(238, 219);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 21);
            this.cbIsActive.TabIndex = 9;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Location = new System.Drawing.Point(546, 214);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 28);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDWindowsFormsApp.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(230, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 603);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.UsersContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip UsersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.Button btnAddUser;
    }
}