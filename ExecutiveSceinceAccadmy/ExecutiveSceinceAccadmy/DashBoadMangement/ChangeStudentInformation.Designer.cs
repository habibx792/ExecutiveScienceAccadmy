namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class ChangeStudentInformation
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
            lblSearch = new Label();
            txtSearchStudent = new TextBox();
            cmbSearchBy = new ComboBox();
            btnSearch = new Button();
            btnLoad = new Button();
            dgvStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStdName = new TextBox();
            txtStdFatherName = new TextBox();
            txtStdCNIC = new TextBox();
            txtFatherCNIC = new TextBox();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbFatherJob = new ComboBox();
            label9 = new Label();
            lblStdContact = new Label();
            lblFatherContact = new Label();
            lblWatsApp = new Label();
            label10 = new Label();
            label11 = new Label();
            txtStdContact = new TextBox();
            txtFatherContact = new TextBox();
            txtWatsApp = new TextBox();
            txtCity = new TextBox();
            txtStdAddress = new RichTextBox();
            label12 = new Label();
            cmbClass = new ComboBox();
            cmbDomain = new ComboBox();
            cmbPrvDeg = new ComboBox();
            cmbBoard = new ComboBox();
            cmbPassingYear = new ComboBox();
            rdReg = new RadioButton();
            rdRTS = new RadioButton();
            rdPrim = new RadioButton();
            rdSuple = new RadioButton();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtPrevReg = new TextBox();
            txtSchool = new TextBox();
            txtObtainedMarks = new TextBox();
            txtTotalMark = new TextBox();
            dtpUpdateDate = new DateTimePicker();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtUpdatedBy = new TextBox();
            label20 = new Label();
            txtChangeReason = new RichTextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            btnClose = new Button();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 18F);
            lblSearch.Location = new Point(432, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(258, 48);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Student";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(300, 92);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(206, 31);
            txtSearchStudent.TabIndex = 2;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "Registration Number", "Student CNIC", "Student Contact", "Student Name" });
            cmbSearchBy.Location = new Point(54, 92);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(182, 33);
            cmbSearchBy.TabIndex = 3;
            cmbSearchBy.Text = "Search By";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(117, 185);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 51);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(343, 185);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(144, 51);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load Students";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToOrderColumns = true;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(539, 51);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(1373, 225);
            dgvStudents.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(447, 290);
            label1.Name = "label1";
            label1.Size = new Size(281, 48);
            label1.TabIndex = 7;
            label1.Text = "Personal Details ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 362);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 8;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 416);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 9;
            label3.Text = "Father Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 468);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 10;
            label4.Text = "Student CNIC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 525);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 11;
            label5.Text = "Father CNIC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 362);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 12;
            label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(505, 416);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 468);
            label8.Name = "label8";
            label8.Size = new Size(156, 25);
            label8.TabIndex = 14;
            label8.Text = "Father Occupation";
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(220, 362);
            txtStdName.Name = "txtStdName";
            txtStdName.Size = new Size(195, 31);
            txtStdName.TabIndex = 15;
            // 
            // txtStdFatherName
            // 
            txtStdFatherName.Location = new Point(220, 410);
            txtStdFatherName.Name = "txtStdFatherName";
            txtStdFatherName.Size = new Size(195, 31);
            txtStdFatherName.TabIndex = 16;
            // 
            // txtStdCNIC
            // 
            txtStdCNIC.Location = new Point(220, 462);
            txtStdCNIC.Name = "txtStdCNIC";
            txtStdCNIC.Size = new Size(195, 31);
            txtStdCNIC.TabIndex = 17;
            // 
            // txtFatherCNIC
            // 
            txtFatherCNIC.Location = new Point(220, 519);
            txtFatherCNIC.Name = "txtFatherCNIC";
            txtFatherCNIC.Size = new Size(195, 31);
            txtFatherCNIC.TabIndex = 18;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(661, 362);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(300, 31);
            dtpDOB.TabIndex = 22;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female ", "Custom" });
            cmbGender.Location = new Point(661, 405);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(300, 33);
            cmbGender.TabIndex = 23;
            // 
            // cmbFatherJob
            // 
            cmbFatherJob.FormattingEnabled = true;
            cmbFatherJob.Items.AddRange(new object[] { "Male", "Female ", "Custom" });
            cmbFatherJob.Location = new Point(661, 460);
            cmbFatherJob.Name = "cmbFatherJob";
            cmbFatherJob.Size = new Size(300, 33);
            cmbFatherJob.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(1102, 290);
            label9.Name = "label9";
            label9.Size = new Size(269, 48);
            label9.TabIndex = 25;
            label9.Text = "Contact Section";
            // 
            // lblStdContact
            // 
            lblStdContact.AutoSize = true;
            lblStdContact.Location = new Point(1011, 362);
            lblStdContact.Name = "lblStdContact";
            lblStdContact.Size = new Size(139, 25);
            lblStdContact.TabIndex = 26;
            lblStdContact.Text = "Student Contact";
            // 
            // lblFatherContact
            // 
            lblFatherContact.AutoSize = true;
            lblFatherContact.Location = new Point(1011, 500);
            lblFatherContact.Name = "lblFatherContact";
            lblFatherContact.Size = new Size(149, 25);
            lblFatherContact.TabIndex = 27;
            lblFatherContact.Text = "Father Mobile No";
            // 
            // lblWatsApp
            // 
            lblWatsApp.AutoSize = true;
            lblWatsApp.Location = new Point(1448, 368);
            lblWatsApp.Name = "lblWatsApp";
            lblWatsApp.Size = new Size(163, 25);
            lblWatsApp.TabIndex = 28;
            lblWatsApp.Text = "Whatsapp Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1022, 425);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 29;
            label10.Text = "Student City";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1448, 443);
            label11.Name = "label11";
            label11.Size = new Size(143, 25);
            label11.TabIndex = 30;
            label11.Text = "Student Address";
            // 
            // txtStdContact
            // 
            txtStdContact.Location = new Point(1174, 359);
            txtStdContact.Name = "txtStdContact";
            txtStdContact.Size = new Size(215, 31);
            txtStdContact.TabIndex = 31;
            // 
            // txtFatherContact
            // 
            txtFatherContact.Location = new Point(1174, 500);
            txtFatherContact.Name = "txtFatherContact";
            txtFatherContact.Size = new Size(215, 31);
            txtFatherContact.TabIndex = 32;
            // 
            // txtWatsApp
            // 
            txtWatsApp.Location = new Point(1657, 364);
            txtWatsApp.Name = "txtWatsApp";
            txtWatsApp.Size = new Size(225, 31);
            txtWatsApp.TabIndex = 33;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(1176, 425);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(213, 31);
            txtCity.TabIndex = 34;
            // 
            // txtStdAddress
            // 
            txtStdAddress.Location = new Point(1657, 440);
            txtStdAddress.Name = "txtStdAddress";
            txtStdAddress.Size = new Size(225, 144);
            txtStdAddress.TabIndex = 35;
            txtStdAddress.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(432, 565);
            label12.Name = "label12";
            label12.Size = new Size(292, 48);
            label12.TabIndex = 36;
            label12.Text = "Academic Details";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(644, 742);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(182, 33);
            cmbClass.TabIndex = 37;
            cmbClass.Text = "Class";
            // 
            // cmbDomain
            // 
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Location = new Point(938, 862);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(182, 33);
            cmbDomain.TabIndex = 38;
            cmbDomain.Text = "Domain";
            // 
            // cmbPrvDeg
            // 
            cmbPrvDeg.FormattingEnabled = true;
            cmbPrvDeg.Location = new Point(938, 803);
            cmbPrvDeg.Name = "cmbPrvDeg";
            cmbPrvDeg.Size = new Size(182, 33);
            cmbPrvDeg.TabIndex = 39;
            cmbPrvDeg.Text = "Previous Class";
            // 
            // cmbBoard
            // 
            cmbBoard.FormattingEnabled = true;
            cmbBoard.Location = new Point(644, 823);
            cmbBoard.Name = "cmbBoard";
            cmbBoard.Size = new Size(182, 33);
            cmbBoard.TabIndex = 40;
            cmbBoard.Text = "Educational Board";
            // 
            // cmbPassingYear
            // 
            cmbPassingYear.FormattingEnabled = true;
            cmbPassingYear.Location = new Point(938, 737);
            cmbPassingYear.Name = "cmbPassingYear";
            cmbPassingYear.Size = new Size(182, 33);
            cmbPassingYear.TabIndex = 41;
            cmbPassingYear.Text = "Passing Year";
            // 
            // rdReg
            // 
            rdReg.AutoSize = true;
            rdReg.Location = new Point(120, 644);
            rdReg.Name = "rdReg";
            rdReg.Size = new Size(162, 29);
            rdReg.TabIndex = 42;
            rdReg.TabStop = true;
            rdReg.Text = "Regular Student";
            rdReg.UseVisualStyleBackColor = true;
            // 
            // rdRTS
            // 
            rdRTS.AutoSize = true;
            rdRTS.Location = new Point(433, 644);
            rdRTS.Name = "rdRTS";
            rdRTS.Size = new Size(132, 29);
            rdRTS.TabIndex = 43;
            rdRTS.TabStop = true;
            rdRTS.Text = "RTS Student";
            rdRTS.UseVisualStyleBackColor = true;
            // 
            // rdPrim
            // 
            rdPrim.AutoSize = true;
            rdPrim.Location = new Point(714, 644);
            rdPrim.Name = "rdPrim";
            rdPrim.Size = new Size(163, 29);
            rdPrim.TabIndex = 44;
            rdPrim.TabStop = true;
            rdPrim.Text = "Primary Student";
            rdPrim.UseVisualStyleBackColor = true;
            // 
            // rdSuple
            // 
            rdSuple.AutoSize = true;
            rdSuple.Location = new Point(1022, 644);
            rdSuple.Name = "rdSuple";
            rdSuple.Size = new Size(157, 29);
            rdSuple.TabIndex = 45;
            rdSuple.TabStop = true;
            rdSuple.Text = "Supplementary";
            rdSuple.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 745);
            label13.Name = "label13";
            label13.Size = new Size(248, 25);
            label13.TabIndex = 46;
            label13.Text = "Previous Registration Number";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(65, 811);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 47;
            label14.Text = "Institute";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(54, 862);
            label15.Name = "label15";
            label15.Size = new Size(139, 25);
            label15.TabIndex = 48;
            label15.Text = "Obtained Marks";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 906);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 49;
            label16.Text = "Total Marks";
            // 
            // txtPrevReg
            // 
            txtPrevReg.Location = new Point(300, 742);
            txtPrevReg.Name = "txtPrevReg";
            txtPrevReg.Size = new Size(238, 31);
            txtPrevReg.TabIndex = 50;
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(300, 792);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(238, 31);
            txtSchool.TabIndex = 51;
            // 
            // txtObtainedMarks
            // 
            txtObtainedMarks.Location = new Point(300, 847);
            txtObtainedMarks.Name = "txtObtainedMarks";
            txtObtainedMarks.Size = new Size(238, 31);
            txtObtainedMarks.TabIndex = 52;
            // 
            // txtTotalMark
            // 
            txtTotalMark.Location = new Point(300, 906);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(238, 31);
            txtTotalMark.TabIndex = 53;
            // 
            // dtpUpdateDate
            // 
            dtpUpdateDate.Location = new Point(1544, 682);
            dtpUpdateDate.Name = "dtpUpdateDate";
            dtpUpdateDate.Size = new Size(300, 31);
            dtpUpdateDate.TabIndex = 54;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1337, 688);
            label17.Name = "label17";
            label17.Size = new Size(112, 25);
            label17.TabIndex = 55;
            label17.Text = "Update Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(906, 513);
            label18.Name = "label18";
            label18.Size = new Size(112, 25);
            label18.TabIndex = 56;
            label18.Text = "Update Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1325, 759);
            label19.Name = "label19";
            label19.Size = new Size(105, 25);
            label19.TabIndex = 57;
            label19.Text = "Updated By";
            // 
            // txtUpdatedBy
            // 
            txtUpdatedBy.Location = new Point(1544, 753);
            txtUpdatedBy.Name = "txtUpdatedBy";
            txtUpdatedBy.Size = new Size(300, 31);
            txtUpdatedBy.TabIndex = 58;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1325, 847);
            label20.Name = "label20";
            label20.Size = new Size(151, 25);
            label20.TabIndex = 59;
            label20.Text = "Reasons/Remarks";
            // 
            // txtChangeReason
            // 
            txtChangeReason.Location = new Point(1544, 811);
            txtChangeReason.Name = "txtChangeReason";
            txtChangeReason.Size = new Size(300, 126);
            txtChangeReason.TabIndex = 60;
            txtChangeReason.Text = "";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(253, 972);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 47);
            btnUpdate.TabIndex = 61;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(492, 972);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 47);
            btnClear.TabIndex = 62;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(714, 972);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 47);
            btnCancel.TabIndex = 63;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(921, 972);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 47);
            btnClose.TabIndex = 64;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F);
            label21.Location = new Point(1337, 577);
            label21.Name = "label21";
            label21.Size = new Size(224, 48);
            label21.TabIndex = 65;
            label21.Text = "Tracking Info";
            // 
            // ChangeStudentInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(label21);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtChangeReason);
            Controls.Add(label20);
            Controls.Add(txtUpdatedBy);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(dtpUpdateDate);
            Controls.Add(txtTotalMark);
            Controls.Add(txtObtainedMarks);
            Controls.Add(txtSchool);
            Controls.Add(txtPrevReg);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(rdSuple);
            Controls.Add(rdPrim);
            Controls.Add(rdRTS);
            Controls.Add(rdReg);
            Controls.Add(cmbPassingYear);
            Controls.Add(cmbBoard);
            Controls.Add(cmbPrvDeg);
            Controls.Add(cmbDomain);
            Controls.Add(cmbClass);
            Controls.Add(label12);
            Controls.Add(txtStdAddress);
            Controls.Add(txtCity);
            Controls.Add(txtWatsApp);
            Controls.Add(txtFatherContact);
            Controls.Add(txtStdContact);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lblWatsApp);
            Controls.Add(lblFatherContact);
            Controls.Add(lblStdContact);
            Controls.Add(label9);
            Controls.Add(cmbFatherJob);
            Controls.Add(cmbGender);
            Controls.Add(dtpDOB);
            Controls.Add(txtFatherCNIC);
            Controls.Add(txtStdCNIC);
            Controls.Add(txtStdFatherName);
            Controls.Add(txtStdName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearchBy);
            Controls.Add(txtSearchStudent);
            Controls.Add(lblSearch);
            Name = "ChangeStudentInformation";
            Text = "ChangeStudentInformation";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearchStudent;
        private ComboBox cmbSearchBy;
        private Button btnSearch;
        private Button btnLoad;
        private DataGridView dgvStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStdName;
        private TextBox txtStdFatherName;
        private TextBox txtStdCNIC;
        private TextBox txtFatherCNIC;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private ComboBox cmbFatherJob;
        private Label label9;
        private Label lblStdContact;
        private Label lblFatherContact;
        private Label lblWatsApp;
        private Label label10;
        private Label label11;
        private TextBox txtStdContact;
        private TextBox txtFatherContact;
        private TextBox txtWatsApp;
        private TextBox txtCity;
        private RichTextBox txtStdAddress;
        private Label label12;
        private ComboBox cmbClass;
        private ComboBox cmbDomain;
        private ComboBox cmbPrvDeg;
        private ComboBox cmbBoard;
        private ComboBox cmbPassingYear;
        private RadioButton rdReg;
        private RadioButton rdRTS;
        private RadioButton rdPrim;
        private RadioButton rdSuple;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtPrevReg;
        private TextBox txtSchool;
        private TextBox txtObtainedMarks;
        private TextBox txtTotalMark;
        private DateTimePicker dtpUpdateDate;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtUpdatedBy;
        private Label label20;
        private RichTextBox txtChangeReason;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnCancel;
        private Button btnClose;
        private Label label21;
    }
}
