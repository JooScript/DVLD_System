namespace DVLDWindowsFormsApp
{
    partial class frmDetainedLicensesList
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
            this.lblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dgvLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbRelease = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 607);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(98, 25);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(399, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detained Licenses List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDWindowsFormsApp.Properties.Resources.handcuffs;
            this.pictureBox1.Location = new System.Drawing.Point(475, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbFilter.Location = new System.Drawing.Point(116, 226);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(175, 24);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // dgvLicenses
            // 
            this.dgvLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicenses.Location = new System.Drawing.Point(17, 264);
            this.dgvLicenses.Name = "dgvLicenses";
            this.dgvLicenses.ReadOnly = true;
            this.dgvLicenses.RowHeadersWidth = 51;
            this.dgvLicenses.RowTemplate.Height = 24;
            this.dgvLicenses.Size = new System.Drawing.Size(1157, 340);
            this.dgvLicenses.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiRelease});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 106);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 6);
            // 
            // tsmiRelease
            // 
            this.tsmiRelease.Name = "tsmiRelease";
            this.tsmiRelease.Size = new System.Drawing.Size(264, 24);
            this.tsmiRelease.Text = "Release Detained License";
            this.tsmiRelease.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(1099, 216);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 42);
            this.btnDetain.TabIndex = 6;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(1018, 216);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 42);
            this.btnRelease.TabIndex = 7;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1099, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(297, 226);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(143, 22);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbRelease
            // 
            this.cbRelease.FormattingEnabled = true;
            this.cbRelease.Items.AddRange(new object[] {
            "All",
            "Released",
            "Detained"});
            this.cbRelease.Location = new System.Drawing.Point(297, 226);
            this.cbRelease.Name = "cbRelease";
            this.cbRelease.Size = new System.Drawing.Size(121, 24);
            this.cbRelease.TabIndex = 10;
            this.cbRelease.SelectedIndexChanged += new System.EventHandler(this.cbRelease_SelectedIndexChanged);
            // 
            // frmDetainedLicensesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 641);
            this.Controls.Add(this.cbRelease);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.dgvLicenses);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecords);
            this.Name = "frmDetainedLicensesList";
            this.Text = "Detained Licenses List";
            this.Load += new System.EventHandler(this.frmDetainedLicensesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.DataGridView dgvLicenses;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbRelease;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelease;
    }
}