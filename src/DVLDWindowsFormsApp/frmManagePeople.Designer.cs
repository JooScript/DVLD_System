namespace DVLDWindowsFormsApp
{
    partial class frmManagePeople
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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ManagePeopleMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAllPeople = new System.Windows.Forms.DataGridView();
            this.dgvMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addPesonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.ManagePeopleMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.dgvMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(499, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage People";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(1169, 195);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 42);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1169, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManagePeopleMenuStrip
            // 
            this.ManagePeopleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ManagePeopleMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManagePeopleMenuStrip.Name = "ManagePeopleMenuStrip";
            this.ManagePeopleMenuStrip.Size = new System.Drawing.Size(1256, 24);
            this.ManagePeopleMenuStrip.TabIndex = 4;
            this.ManagePeopleMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem1,
            this.deletePersonToolStripMenuItem,
            this.toolStripMenuItem1,
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // findPersonToolStripMenuItem
            // 
            this.findPersonToolStripMenuItem.Name = "findPersonToolStripMenuItem";
            this.findPersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findPersonToolStripMenuItem.Text = "Find Person";
            this.findPersonToolStripMenuItem.Click += new System.EventHandler(this.findPersonToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editPersonToolStripMenuItem.Text = "Add Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem1
            // 
            this.editPersonToolStripMenuItem1.Name = "editPersonToolStripMenuItem1";
            this.editPersonToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editPersonToolStripMenuItem1.Text = "Edit Person";
            this.editPersonToolStripMenuItem1.Click += new System.EventHandler(this.editPersonToolStripMenuItem1_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDWindowsFormsApp.Properties.Resources.People;
            this.pictureBox1.Location = new System.Drawing.Point(536, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 487);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(78, 16);
            this.lblRecords.TabIndex = 6;
            this.lblRecords.Text = "#Records:";
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.ContextMenuStrip = this.dgvMenuStrip;
            this.dgvAllPeople.Location = new System.Drawing.Point(12, 244);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.Size = new System.Drawing.Size(1244, 230);
            this.dgvAllPeople.TabIndex = 7;
            // 
            // dgvMenuStrip
            // 
            this.dgvMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addPesonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.dgvMenuStrip.Name = "contextMenuStrip1";
            this.dgvMenuStrip.Size = new System.Drawing.Size(142, 148);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // addPesonToolStripMenuItem
            // 
            this.addPesonToolStripMenuItem.Name = "addPesonToolStripMenuItem";
            this.addPesonToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addPesonToolStripMenuItem.Text = "Add Peson";
            this.addPesonToolStripMenuItem.Click += new System.EventHandler(this.addPesonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editToolStripMenuItem.Text = "Edit ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilter.Location = new System.Drawing.Point(86, 211);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(147, 21);
            this.cbFilter.TabIndex = 8;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(239, 211);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(155, 21);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 515);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvAllPeople);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagePeopleMenuStrip);
            this.MainMenuStrip = this.ManagePeopleMenuStrip;
            this.Name = "frmManagePeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            this.ManagePeopleMenuStrip.ResumeLayout(false);
            this.ManagePeopleMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.dgvMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip ManagePeopleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllPeople;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ContextMenuStrip dgvMenuStrip;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addPesonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}