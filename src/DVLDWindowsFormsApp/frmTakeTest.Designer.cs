namespace DVLDWindowsFormsApp
{
    partial class frmTakeTest
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pbMainPic = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTrials = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblTestID);
            this.gbMain.Controls.Add(this.lblFees);
            this.gbMain.Controls.Add(this.lblDate);
            this.gbMain.Controls.Add(this.lblTrials);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.lblClass);
            this.gbMain.Controls.Add(this.lblAppID);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.lblTitle);
            this.gbMain.Controls.Add(this.pbMainPic);
            this.gbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(391, 381);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Test";
            // 
            // pbMainPic
            // 
            this.pbMainPic.Image = global::DVLDWindowsFormsApp.Properties.Resources.Car;
            this.pbMainPic.Location = new System.Drawing.Point(133, 19);
            this.pbMainPic.Name = "pbMainPic";
            this.pbMainPic.Size = new System.Drawing.Size(100, 103);
            this.pbMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPic.TabIndex = 0;
            this.pbMainPic.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(92, 125);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Scheduled Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "D.L.App.ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trials:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Test ID:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.Location = new System.Drawing.Point(97, 169);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(31, 16);
            this.lblAppID.TabIndex = 9;
            this.lblAppID.Text = "???";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(97, 199);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(31, 16);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "???";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 229);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "???";
            // 
            // lblTrials
            // 
            this.lblTrials.AutoSize = true;
            this.lblTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrials.Location = new System.Drawing.Point(97, 259);
            this.lblTrials.Name = "lblTrials";
            this.lblTrials.Size = new System.Drawing.Size(31, 16);
            this.lblTrials.TabIndex = 12;
            this.lblTrials.Text = "???";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(97, 289);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 16);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "???";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(97, 319);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(31, 16);
            this.lblFees.TabIndex = 14;
            this.lblFees.Text = "???";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.Location = new System.Drawing.Point(97, 349);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(106, 16);
            this.lblTestID.TabIndex = 15;
            this.lblTestID.Text = "Not Taken Yet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Result:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notes:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(103, 412);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(48, 17);
            this.rbPass.TabIndex = 20;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Location = new System.Drawing.Point(157, 411);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(41, 17);
            this.rbFail.TabIndex = 21;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(100, 438);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(179, 39);
            this.txtNotes.TabIndex = 22;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 518);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbMain);
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.PictureBox pbMainPic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTrials;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.TextBox txtNotes;
    }
}