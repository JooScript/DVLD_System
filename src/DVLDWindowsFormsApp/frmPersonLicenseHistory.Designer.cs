namespace DVLDWindowsFormsApp
{
    partial class frmPersonLicenseHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.tcLicenses = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlPersonInfo1 = new DVLDWindowsFormsApp.ctrlPersonInfo();
            this.showLicenseInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tcLicenses.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecords);
            this.groupBox1.Controls.Add(this.tcLicenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(7, 189);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 16);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "Records:";
            // 
            // tcLicenses
            // 
            this.tcLicenses.Controls.Add(this.tpLocal);
            this.tcLicenses.Controls.Add(this.tpInternational);
            this.tcLicenses.Location = new System.Drawing.Point(6, 21);
            this.tcLicenses.Name = "tcLicenses";
            this.tcLicenses.SelectedIndex = 0;
            this.tcLicenses.Size = new System.Drawing.Size(658, 165);
            this.tcLicenses.TabIndex = 0;
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.dgvLocal);
            this.tpLocal.Location = new System.Drawing.Point(4, 25);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(650, 136);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            this.tpLocal.Enter += new System.EventHandler(this.tpLocal_Enter);
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocal.Location = new System.Drawing.Point(6, 3);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.Size = new System.Drawing.Size(638, 127);
            this.dgvLocal.TabIndex = 0;
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.dgvInternational);
            this.tpInternational.Location = new System.Drawing.Point(4, 25);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(650, 136);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            this.tpInternational.Enter += new System.EventHandler(this.tpInternational_Enter);
            // 
            // dgvInternational
            // 
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInternational.Location = new System.Drawing.Point(6, 6);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.Size = new System.Drawing.Size(638, 124);
            this.dgvInternational.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 557);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(12, 43);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(670, 285);
            this.ctrlPersonInfo1.TabIndex = 1;
            // 
            // showLicenseInfoToolStripMenuItem1
            // 
            this.showLicenseInfoToolStripMenuItem1.Name = "showLicenseInfoToolStripMenuItem1";
            this.showLicenseInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showLicenseInfoToolStripMenuItem1.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem1.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem1_Click);
            // 
            // frmPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 592);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcLicenses.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.tpInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcLicenses;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem1;
    }
}