namespace ExecutiveSceinceAccadmy.RegisTrationForms.StudentRegistration
{
    partial class RegisTracionForm
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
            btnRegistation = new Button();
            pnPreq = new Panel();
            lblRegiDate = new Label();
            dtpRegis = new DateTimePicker();
            lblClass = new Label();
            lblDomain = new Label();
            cmbDomain = new ComboBox();
            rdSuple = new RadioButton();
            rdPrim = new RadioButton();
            rdRTS = new RadioButton();
            rdReg = new RadioButton();
            cmbClass = new ComboBox();
            txtStdFatherName = new TextBox();
            txtStdCNIC = new TextBox();
            txtStdName = new TextBox();
            txtFatherCNIC = new TextBox();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMainPn = new Panel();
            pnAccadminc = new Panel();
            cmbBoard = new ComboBox();
            cmbPrvDeg = new ComboBox();
            cmbPassingYear = new ComboBox();
            lblDegYear = new Label();
            label20 = new Label();
            lblSchool = new Label();
            txtTotalMark = new TextBox();
            txtSchool = new TextBox();
            lblObtainMark = new Label();
            lblRollNo = new Label();
            lblBoard = new Label();
            lblDeg = new Label();
            txtObtainedMarks = new TextBox();
            lblTotalMarks = new Label();
            txtPrevReg = new TextBox();
            pnPerMain = new Panel();
            txtStdContact = new TextBox();
            lblStdContact = new Label();
            cmbFatherJob = new ComboBox();
            label2 = new Label();
            txtCity = new TextBox();
            label1 = new Label();
            txtStdAddress = new TextBox();
            lblGend = new Label();
            cmbGender = new ComboBox();
            txtFatherContact = new TextBox();
            txtWatsApp = new TextBox();
            dtpDOB = new DateTimePicker();
            lblFatherMob = new Label();
            lblStdCNIC = new Label();
            lblFathCnic = new Label();
            lblStdName = new Label();
            lblDob = new Label();
            lblFatherName = new Label();
            lblWatsap = new Label();
            lblFathOcc = new Label();
            pnPerson = new Panel();
            label19 = new Label();
            pnHide = new Panel();
            pnPreq.SuspendLayout();
            pnLogo.SuspendLayout();
            pnMainPn.SuspendLayout();
            pnAccadminc.SuspendLayout();
            pnPerMain.SuspendLayout();
            pnPerson.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistation
            // 
            btnRegistation.Location = new Point(1051, 661);
            btnRegistation.Name = "btnRegistation";
            btnRegistation.Size = new Size(154, 59);
            btnRegistation.TabIndex = 0;
            btnRegistation.Text = "Register";
            btnRegistation.UseVisualStyleBackColor = true;
            btnRegistation.Click += btnRegistation_Click;
            // 
            // pnPreq
            // 
            pnPreq.Controls.Add(lblRegiDate);
            pnPreq.Controls.Add(dtpRegis);
            pnPreq.Controls.Add(lblClass);
            pnPreq.Controls.Add(lblDomain);
            pnPreq.Controls.Add(cmbDomain);
            pnPreq.Controls.Add(rdSuple);
            pnPreq.Controls.Add(rdPrim);
            pnPreq.Controls.Add(rdRTS);
            pnPreq.Controls.Add(rdReg);
            pnPreq.Controls.Add(cmbClass);
            pnPreq.Location = new Point(29, 52);
            pnPreq.Name = "pnPreq";
            pnPreq.Size = new Size(1176, 131);
            pnPreq.TabIndex = 1;
            pnPreq.Paint += pnPreq_Paint;
            // 
            // lblRegiDate
            // 
            lblRegiDate.AutoSize = true;
            lblRegiDate.Location = new Point(795, 92);
            lblRegiDate.Name = "lblRegiDate";
            lblRegiDate.Size = new Size(97, 15);
            lblRegiDate.TabIndex = 26;
            lblRegiDate.Text = "Registration Date";
            // 
            // dtpRegis
            // 
            dtpRegis.Location = new Point(922, 87);
            dtpRegis.Name = "dtpRegis";
            dtpRegis.Size = new Size(200, 23);
            dtpRegis.TabIndex = 25;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(72, 87);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(34, 15);
            lblClass.TabIndex = 24;
            lblClass.Text = "Class";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Location = new Point(463, 87);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(49, 15);
            lblDomain.TabIndex = 23;
            lblDomain.Text = "Domain";
            // 
            // cmbDomain
            // 
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Items.AddRange(new object[] { "Primary", "Medical", "Computer", "Non-Medical", "Arts" });
            cmbDomain.Location = new Point(525, 84);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(156, 23);
            cmbDomain.TabIndex = 1;
            // 
            // rdSuple
            // 
            rdSuple.AutoSize = true;
            rdSuple.Location = new Point(957, 32);
            rdSuple.Name = "rdSuple";
            rdSuple.Size = new Size(105, 19);
            rdSuple.TabIndex = 4;
            rdSuple.TabStop = true;
            rdSuple.Text = "Supplementary";
            rdSuple.UseVisualStyleBackColor = true;
            // 
            // rdPrim
            // 
            rdPrim.AutoSize = true;
            rdPrim.Location = new Point(547, 32);
            rdPrim.Name = "rdPrim";
            rdPrim.Size = new Size(110, 19);
            rdPrim.TabIndex = 5;
            rdPrim.TabStop = true;
            rdPrim.Text = "Primary Student";
            rdPrim.UseVisualStyleBackColor = true;
            // 
            // rdRTS
            // 
            rdRTS.AutoSize = true;
            rdRTS.Location = new Point(296, 32);
            rdRTS.Name = "rdRTS";
            rdRTS.Size = new Size(88, 19);
            rdRTS.TabIndex = 6;
            rdRTS.TabStop = true;
            rdRTS.Text = "RTS Student";
            rdRTS.UseVisualStyleBackColor = true;
            // 
            // rdReg
            // 
            rdReg.AutoSize = true;
            rdReg.Location = new Point(72, 32);
            rdReg.Name = "rdReg";
            rdReg.Size = new Size(109, 19);
            rdReg.TabIndex = 7;
            rdReg.TabStop = true;
            rdReg.Text = "Regular Student";
            rdReg.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbClass.Location = new Point(125, 84);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(154, 23);
            cmbClass.TabIndex = 11;
            // 
            // txtStdFatherName
            // 
            txtStdFatherName.Location = new Point(571, 22);
            txtStdFatherName.Name = "txtStdFatherName";
            txtStdFatherName.Size = new Size(206, 23);
            txtStdFatherName.TabIndex = 0;
            txtStdFatherName.TextChanged += textBox1_TextChanged;
            // 
            // txtStdCNIC
            // 
            txtStdCNIC.Location = new Point(139, 92);
            txtStdCNIC.Name = "txtStdCNIC";
            txtStdCNIC.Size = new Size(250, 23);
            txtStdCNIC.TabIndex = 16;
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(130, 22);
            txtStdName.Name = "txtStdName";
            txtStdName.Size = new Size(250, 23);
            txtStdName.TabIndex = 17;
            txtStdName.TextAlign = HorizontalAlignment.Center;
            txtStdName.TextChanged += textBox3_TextChanged;
            // 
            // txtFatherCNIC
            // 
            txtFatherCNIC.Location = new Point(921, 22);
            txtFatherCNIC.Name = "txtFatherCNIC";
            txtFatherCNIC.Size = new Size(209, 23);
            txtFatherCNIC.TabIndex = 19;
            txtFatherCNIC.TextChanged += textBox5_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(89, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1228, 88);
            pnLogo.TabIndex = 25;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(397, 23);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // pnMainPn
            // 
            pnMainPn.Controls.Add(pnAccadminc);
            pnMainPn.Controls.Add(pnPreq);
            pnMainPn.Controls.Add(pnPerMain);
            pnMainPn.Controls.Add(pnPerson);
            pnMainPn.Controls.Add(btnRegistation);
            pnMainPn.Location = new Point(89, 106);
            pnMainPn.Name = "pnMainPn";
            pnMainPn.Size = new Size(1228, 735);
            pnMainPn.TabIndex = 26;
            pnMainPn.Paint += pnMainPn_Paint;
            // 
            // pnAccadminc
            // 
            pnAccadminc.Controls.Add(cmbBoard);
            pnAccadminc.Controls.Add(cmbPrvDeg);
            pnAccadminc.Controls.Add(cmbPassingYear);
            pnAccadminc.Controls.Add(lblDegYear);
            pnAccadminc.Controls.Add(label20);
            pnAccadminc.Controls.Add(lblSchool);
            pnAccadminc.Controls.Add(txtTotalMark);
            pnAccadminc.Controls.Add(txtSchool);
            pnAccadminc.Controls.Add(lblObtainMark);
            pnAccadminc.Controls.Add(lblRollNo);
            pnAccadminc.Controls.Add(lblBoard);
            pnAccadminc.Controls.Add(lblDeg);
            pnAccadminc.Controls.Add(txtObtainedMarks);
            pnAccadminc.Controls.Add(lblTotalMarks);
            pnAccadminc.Controls.Add(txtPrevReg);
            pnAccadminc.Location = new Point(29, 449);
            pnAccadminc.Name = "pnAccadminc";
            pnAccadminc.Size = new Size(1176, 205);
            pnAccadminc.TabIndex = 53;
            // 
            // cmbBoard
            // 
            cmbBoard.FormattingEnabled = true;
            cmbBoard.Items.AddRange(new object[] { "Primary ", "FSD Board", "Lahore Board", "Islamabad Board" });
            cmbBoard.Location = new Point(511, 158);
            cmbBoard.Name = "cmbBoard";
            cmbBoard.Size = new Size(167, 23);
            cmbBoard.TabIndex = 57;
            // 
            // cmbPrvDeg
            // 
            cmbPrvDeg.FormattingEnabled = true;
            cmbPrvDeg.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbPrvDeg.Location = new Point(116, 77);
            cmbPrvDeg.Name = "cmbPrvDeg";
            cmbPrvDeg.Size = new Size(187, 23);
            cmbPrvDeg.TabIndex = 56;
            // 
            // cmbPassingYear
            // 
            cmbPassingYear.FormattingEnabled = true;
            cmbPassingYear.Items.AddRange(new object[] { "2000", "2001", "2002", "2004", "2005", "2006", "2007", "2008", "2009", "2010" });
            cmbPassingYear.Location = new Point(112, 155);
            cmbPassingYear.Name = "cmbPassingYear";
            cmbPassingYear.Size = new Size(167, 23);
            cmbPassingYear.TabIndex = 55;
            // 
            // lblDegYear
            // 
            lblDegYear.AutoSize = true;
            lblDegYear.Location = new Point(54, 155);
            lblDegYear.Name = "lblDegYear";
            lblDegYear.Size = new Size(29, 15);
            lblDegYear.TabIndex = 54;
            lblDegYear.Text = "Year";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(525, 23);
            label20.Name = "label20";
            label20.Size = new Size(96, 25);
            label20.TabIndex = 43;
            label20.Text = "Accadmic";
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Location = new Point(699, 155);
            lblSchool.Name = "lblSchool";
            lblSchool.Size = new Size(43, 15);
            lblSchool.TabIndex = 52;
            lblSchool.Text = "School";
            // 
            // txtTotalMark
            // 
            txtTotalMark.Location = new Point(969, 64);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(190, 23);
            txtTotalMark.TabIndex = 26;
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(766, 147);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(393, 23);
            txtSchool.TabIndex = 51;
            // 
            // lblObtainMark
            // 
            lblObtainMark.AutoSize = true;
            lblObtainMark.Location = new Point(699, 77);
            lblObtainMark.Name = "lblObtainMark";
            lblObtainMark.Size = new Size(39, 15);
            lblObtainMark.TabIndex = 27;
            lblObtainMark.Text = "Marks";
            lblObtainMark.Click += label3_Click;
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.Location = new Point(467, 77);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(52, 15);
            lblRollNo.TabIndex = 28;
            lblRollNo.Text = "Roll No :";
            // 
            // lblBoard
            // 
            lblBoard.AutoSize = true;
            lblBoard.Location = new Point(467, 161);
            lblBoard.Name = "lblBoard";
            lblBoard.Size = new Size(38, 15);
            lblBoard.TabIndex = 49;
            lblBoard.Text = "Board";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Location = new Point(39, 77);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(44, 15);
            lblDeg.TabIndex = 29;
            lblDeg.Text = "Degree";
            // 
            // txtObtainedMarks
            // 
            txtObtainedMarks.Location = new Point(744, 70);
            txtObtainedMarks.Name = "txtObtainedMarks";
            txtObtainedMarks.Size = new Size(180, 23);
            txtObtainedMarks.TabIndex = 45;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Location = new Point(930, 73);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(33, 15);
            lblTotalMarks.TabIndex = 37;
            lblTotalMarks.Text = "Total";
            // 
            // txtPrevReg
            // 
            txtPrevReg.Location = new Point(522, 74);
            txtPrevReg.Name = "txtPrevReg";
            txtPrevReg.Size = new Size(171, 23);
            txtPrevReg.TabIndex = 44;
            // 
            // pnPerMain
            // 
            pnPerMain.Controls.Add(txtStdContact);
            pnPerMain.Controls.Add(lblStdContact);
            pnPerMain.Controls.Add(cmbFatherJob);
            pnPerMain.Controls.Add(label2);
            pnPerMain.Controls.Add(txtCity);
            pnPerMain.Controls.Add(label1);
            pnPerMain.Controls.Add(txtStdAddress);
            pnPerMain.Controls.Add(lblGend);
            pnPerMain.Controls.Add(cmbGender);
            pnPerMain.Controls.Add(txtStdName);
            pnPerMain.Controls.Add(txtFatherCNIC);
            pnPerMain.Controls.Add(txtStdFatherName);
            pnPerMain.Controls.Add(txtStdCNIC);
            pnPerMain.Controls.Add(txtFatherContact);
            pnPerMain.Controls.Add(txtWatsApp);
            pnPerMain.Controls.Add(dtpDOB);
            pnPerMain.Controls.Add(lblFatherMob);
            pnPerMain.Controls.Add(lblStdCNIC);
            pnPerMain.Controls.Add(lblFathCnic);
            pnPerMain.Controls.Add(lblStdName);
            pnPerMain.Controls.Add(lblDob);
            pnPerMain.Controls.Add(lblFatherName);
            pnPerMain.Controls.Add(lblWatsap);
            pnPerMain.Controls.Add(lblFathOcc);
            pnPerMain.Location = new Point(29, 189);
            pnPerMain.Name = "pnPerMain";
            pnPerMain.Size = new Size(1176, 255);
            pnPerMain.TabIndex = 42;
            // 
            // txtStdContact
            // 
            txtStdContact.Location = new Point(933, 150);
            txtStdContact.Name = "txtStdContact";
            txtStdContact.Size = new Size(206, 23);
            txtStdContact.TabIndex = 49;
            txtStdContact.TextChanged += textBox1_TextChanged_2;
            // 
            // lblStdContact
            // 
            lblStdContact.AutoSize = true;
            lblStdContact.Location = new Point(832, 158);
            lblStdContact.Name = "lblStdContact";
            lblStdContact.Size = new Size(92, 15);
            lblStdContact.TabIndex = 50;
            lblStdContact.Text = "student Contact";
            // 
            // cmbFatherJob
            // 
            cmbFatherJob.FormattingEnabled = true;
            cmbFatherJob.Items.AddRange(new object[] { "Labour", "Doctor", "Teacher", "Army", "Other" });
            cmbFatherJob.Location = new Point(147, 219);
            cmbFatherJob.Name = "cmbFatherJob";
            cmbFatherJob.Size = new Size(209, 23);
            cmbFatherJob.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 209);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 47;
            label2.Text = "City";
            label2.Click += label2_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(569, 205);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(209, 23);
            txtCity.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(832, 205);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 45;
            label1.Text = "Address";
            // 
            // txtStdAddress
            // 
            txtStdAddress.Location = new Point(930, 205);
            txtStdAddress.Margin = new Padding(2);
            txtStdAddress.Name = "txtStdAddress";
            txtStdAddress.Size = new Size(209, 23);
            txtStdAddress.TabIndex = 29;
            // 
            // lblGend
            // 
            lblGend.AutoSize = true;
            lblGend.Location = new Point(478, 92);
            lblGend.Name = "lblGend";
            lblGend.Size = new Size(45, 15);
            lblGend.TabIndex = 44;
            lblGend.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(571, 92);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(206, 23);
            cmbGender.TabIndex = 43;
            // 
            // txtFatherContact
            // 
            txtFatherContact.Location = new Point(130, 150);
            txtFatherContact.Name = "txtFatherContact";
            txtFatherContact.Size = new Size(250, 23);
            txtFatherContact.TabIndex = 23;
            // 
            // txtWatsApp
            // 
            txtWatsApp.Location = new Point(571, 163);
            txtWatsApp.Name = "txtWatsApp";
            txtWatsApp.Size = new Size(206, 23);
            txtWatsApp.TabIndex = 21;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(921, 92);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(209, 23);
            dtpDOB.TabIndex = 42;
            // 
            // lblFatherMob
            // 
            lblFatherMob.AutoSize = true;
            lblFatherMob.Location = new Point(7, 158);
            lblFatherMob.Name = "lblFatherMob";
            lblFatherMob.Size = new Size(105, 15);
            lblFatherMob.TabIndex = 30;
            lblFatherMob.Text = "Father Mobile No :";
            // 
            // lblStdCNIC
            // 
            lblStdCNIC.AutoSize = true;
            lblStdCNIC.Location = new Point(42, 100);
            lblStdCNIC.Name = "lblStdCNIC";
            lblStdCNIC.Size = new Size(79, 15);
            lblStdCNIC.TabIndex = 31;
            lblStdCNIC.Text = "Student CNIC";
            // 
            // lblFathCnic
            // 
            lblFathCnic.AutoSize = true;
            lblFathCnic.Location = new Point(832, 30);
            lblFathCnic.Name = "lblFathCnic";
            lblFathCnic.Size = new Size(71, 15);
            lblFathCnic.TabIndex = 40;
            lblFathCnic.Text = "Father CNIC";
            // 
            // lblStdName
            // 
            lblStdName.AutoSize = true;
            lblStdName.Location = new Point(29, 30);
            lblStdName.Name = "lblStdName";
            lblStdName.Size = new Size(83, 15);
            lblStdName.TabIndex = 32;
            lblStdName.Text = "Student Name";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(841, 100);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(31, 15);
            lblDob.TabIndex = 39;
            lblDob.Text = "DOB";
            // 
            // lblFatherName
            // 
            lblFatherName.AutoSize = true;
            lblFatherName.Location = new Point(468, 30);
            lblFatherName.Name = "lblFatherName";
            lblFatherName.Size = new Size(75, 15);
            lblFatherName.TabIndex = 33;
            lblFatherName.Text = "Father Name";
            // 
            // lblWatsap
            // 
            lblWatsap.AutoSize = true;
            lblWatsap.Location = new Point(447, 158);
            lblWatsap.Name = "lblWatsap";
            lblWatsap.Size = new Size(55, 15);
            lblWatsap.TabIndex = 34;
            lblWatsap.Text = "WatsApp";
            // 
            // lblFathOcc
            // 
            lblFathOcc.AutoSize = true;
            lblFathOcc.Location = new Point(16, 219);
            lblFathOcc.Name = "lblFathOcc";
            lblFathOcc.Size = new Size(105, 15);
            lblFathOcc.TabIndex = 35;
            lblFathOcc.Text = "Father Occupation";
            // 
            // pnPerson
            // 
            pnPerson.Controls.Add(label19);
            pnPerson.Location = new Point(29, 3);
            pnPerson.Name = "pnPerson";
            pnPerson.Size = new Size(1176, 43);
            pnPerson.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(443, 9);
            label19.Name = "label19";
            label19.Size = new Size(322, 25);
            label19.TabIndex = 1;
            label19.Text = "Person Information And Education";
            // 
            // pnHide
            // 
            pnHide.Location = new Point(44, 661);
            pnHide.Name = "pnHide";
            pnHide.Size = new Size(25, 100);
            pnHide.TabIndex = 27;
            // 
            // RegisTracionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 847);
            Controls.Add(pnHide);
            Controls.Add(pnMainPn);
            Controls.Add(pnLogo);
            Name = "RegisTracionForm";
            Text = "RegisTracionForm";
            Load += RegisTracionForm_Load;
            pnPreq.ResumeLayout(false);
            pnPreq.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnMainPn.ResumeLayout(false);
            pnAccadminc.ResumeLayout(false);
            pnAccadminc.PerformLayout();
            pnPerMain.ResumeLayout(false);
            pnPerMain.PerformLayout();
            pnPerson.ResumeLayout(false);
            pnPerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistation;
        private Panel pnPreq;
        private TextBox txtStdFatherName;
        private ComboBox cmbDomain;
        private RadioButton rdSuple;
        private RadioButton rdPrim;
        private RadioButton rdRTS;
        private ComboBox cmbClass;
        private TextBox txtStdCNIC;
        private TextBox txtStdName;
        private TextBox txtFatherCNIC;
        private Label lblDomain;
        private Label lblClass;
        private Panel pnLogo;
        private Label lbLogo;
        private Label lblRegiDate;
        private DateTimePicker dtpRegis;
        private Panel pnMainPn;
        private Label lblFathCnic;
        private Label lblDob;
        private Label lblTotalMarks;
        private Label lblFathOcc;
        private Label lblWatsap;
        private Label lblFatherName;
        private Label lblStdName;
        private Label lblStdCNIC;
        private Label lblFatherMob;
        private Label lblDeg;
        private Label lblRollNo;
        private Label lblObtainMark;
        private TextBox txtTotalMark;
        private TextBox txtWatsApp;
        private TextBox txtFatherContact;
        private DateTimePicker dtpDOB;
        private Panel pnPerson;
        private Label label19;
        private Panel pnPerMain;
        private Label lblBoard;
        private TextBox txtObtainedMarks;
        private TextBox txtPrevReg;
        private Label label20;
        private Panel pnAccadminc;
        private Label lblSchool;
        private TextBox txtSchool;
        private RadioButton rdReg;
        private Panel pnHide;
        private Label lblGend;
        private ComboBox cmbGender;
        private ComboBox cmbPassingYear;
        private Label lblDegYear;
        private Label label2;
        private TextBox txtCity;
        private Label label1;
        private TextBox txtStdAddress;
        private ComboBox cmbFatherJob;
        private TextBox txtStdContact;
        private Label lblStdContact;
        private ComboBox cmbPrvDeg;
        private ComboBox cmbBoard;
    }
}