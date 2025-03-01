namespace DVLDWindowsFormsApp
{
    partial class ctrlFilterLicenseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicense = new DVLDWindowsFormsApp.ctrlDriverLicense();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(189, 4);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Size = new System.Drawing.Size(385, 78);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(269, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(128, 32);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(132, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // ctrlDriverLicense
            // 
            this.ctrlDriverLicense.Location = new System.Drawing.Point(0, 70);
            this.ctrlDriverLicense.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlDriverLicense.Name = "ctrlDriverLicense";
            this.ctrlDriverLicense.Size = new System.Drawing.Size(821, 409);
            this.ctrlDriverLicense.TabIndex = 0;
            // 
            // ctrlFilterLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlDriverLicense);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrlFilterLicenseInfo";
            this.Size = new System.Drawing.Size(821, 480);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicense ctrlDriverLicense;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
