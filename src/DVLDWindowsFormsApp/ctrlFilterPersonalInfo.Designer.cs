namespace DVLDWindowsFormsApp
{
    partial class ctrlFilterPersonalInfo
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
            this.piPersonInfo = new DVLDWindowsFormsApp.ctrlPersonInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // piPersonInfo
            // 
            this.piPersonInfo.Location = new System.Drawing.Point(3, 69);
            this.piPersonInfo.Name = "piPersonInfo";
            this.piPersonInfo.Size = new System.Drawing.Size(672, 285);
            this.piPersonInfo.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(93, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(516, 56);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(415, 28);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(96, 23);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(334, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.AcceptsTab = true;
            this.txtFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilter.Location = new System.Drawing.Point(252, 27);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(63, 22);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "National No",
            "Person ID"});
            this.cbFilter.Location = new System.Drawing.Point(80, 27);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(166, 24);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // ctrlFilterPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.piPersonInfo);
            this.Name = "ctrlFilterPersonalInfo";
            this.Size = new System.Drawing.Size(687, 361);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo piPersonInfo;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
