namespace DVLDWindowsFormsApp
{
    partial class frmScheduleTest
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
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.gbRetakeTest = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbMainPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRFees = new System.Windows.Forms.Label();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.gbTest.SuspendLayout();
            this.gbRetakeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.lblFees);
            this.gbTest.Controls.Add(this.dtpDate);
            this.gbTest.Controls.Add(this.lblTrial);
            this.gbTest.Controls.Add(this.lblName);
            this.gbTest.Controls.Add(this.lblClass);
            this.gbTest.Controls.Add(this.lblID);
            this.gbTest.Controls.Add(this.label7);
            this.gbTest.Controls.Add(this.label6);
            this.gbTest.Controls.Add(this.label5);
            this.gbTest.Controls.Add(this.label4);
            this.gbTest.Controls.Add(this.label3);
            this.gbTest.Controls.Add(this.label2);
            this.gbTest.Controls.Add(this.label1);
            this.gbTest.Controls.Add(this.pbMainPic);
            this.gbTest.Controls.Add(this.btnSave);
            this.gbTest.Controls.Add(this.gbRetakeTest);
            this.gbTest.Location = new System.Drawing.Point(12, 12);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(377, 479);
            this.gbTest.TabIndex = 0;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test";
            // 
            // gbRetakeTest
            // 
            this.gbRetakeTest.Controls.Add(this.lblTotalFees);
            this.gbRetakeTest.Controls.Add(this.lblRID);
            this.gbRetakeTest.Controls.Add(this.lblRFees);
            this.gbRetakeTest.Controls.Add(this.label10);
            this.gbRetakeTest.Controls.Add(this.label9);
            this.gbRetakeTest.Controls.Add(this.label8);
            this.gbRetakeTest.Location = new System.Drawing.Point(6, 338);
            this.gbRetakeTest.Name = "gbRetakeTest";
            this.gbRetakeTest.Size = new System.Drawing.Size(365, 106);
            this.gbRetakeTest.TabIndex = 0;
            this.gbRetakeTest.TabStop = false;
            this.gbRetakeTest.Text = "Retake Test";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(296, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(163, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbMainPic
            // 
            this.pbMainPic.Image = global::DVLDWindowsFormsApp.Properties.Resources.Car;
            this.pbMainPic.Location = new System.Drawing.Point(134, 19);
            this.pbMainPic.Name = "pbMainPic";
            this.pbMainPic.Size = new System.Drawing.Size(100, 90);
            this.pbMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPic.TabIndex = 0;
            this.pbMainPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "D.L AppID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trials:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(90, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Schedule Test";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(110, 168);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "???";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(110, 197);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(31, 16);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "???";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(110, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "???";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.Location = new System.Drawing.Point(110, 255);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(31, 16);
            this.lblTrial.TabIndex = 11;
            this.lblTrial.Text = "???";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(126, 279);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 13;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(110, 313);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(31, 16);
            this.lblFees.TabIndex = 14;
            this.lblFees.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "R.Test.App.ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "R.App.Fees:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total Fees:";
            // 
            // lblRFees
            // 
            this.lblRFees.AutoSize = true;
            this.lblRFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFees.Location = new System.Drawing.Point(141, 31);
            this.lblRFees.Name = "lblRFees";
            this.lblRFees.Size = new System.Drawing.Size(31, 16);
            this.lblRFees.TabIndex = 12;
            this.lblRFees.Text = "???";
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.Location = new System.Drawing.Point(141, 72);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(33, 16);
            this.lblRID.TabIndex = 13;
            this.lblRID.Text = "N/A";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(305, 32);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(31, 16);
            this.lblTotalFees.TabIndex = 14;
            this.lblTotalFees.Text = "???";
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbTest);
            this.Name = "frmScheduleTest";
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            this.gbRetakeTest.ResumeLayout(false);
            this.gbRetakeTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRetakeTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbMainPic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblRFees;
    }
}