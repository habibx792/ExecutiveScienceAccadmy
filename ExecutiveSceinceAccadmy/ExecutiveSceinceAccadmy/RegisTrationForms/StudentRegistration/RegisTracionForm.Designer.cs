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
            btnRegistation.BackColor = Color.Black;
            btnRegistation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistation.ForeColor = Color.White;
            btnRegistation.Location = new Point(1351, 1014);
            btnRegistation.Margin = new Padding(4, 5, 4, 5);
            btnRegistation.Name = "btnRegistation";
            btnRegistation.Size = new Size(198, 90);
            btnRegistation.TabIndex = 0;
            btnRegistation.Text = "Register";
            btnRegistation.UseVisualStyleBackColor = false;
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
            pnPreq.Location = new Point(37, 80);
            pnPreq.Margin = new Padding(4, 5, 4, 5);
            pnPreq.Name = "pnPreq";
            pnPreq.Size = new Size(1512, 201);
            pnPreq.TabIndex = 1;
            pnPreq.Paint += pnPreq_Paint;
            // 
            // lblRegiDate
            // 
            lblRegiDate.AutoSize = true;
            lblRegiDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegiDate.Location = new Point(1020, 124);
            lblRegiDate.Margin = new Padding(4, 0, 4, 0);
            lblRegiDate.Name = "lblRegiDate";
            lblRegiDate.Size = new Size(151, 23);
            lblRegiDate.TabIndex = 26;
            lblRegiDate.Text = "Registration Date";
            // 
            // dtpRegis
            // 
            dtpRegis.Location = new Point(1176, 115);
            dtpRegis.Margin = new Padding(4, 5, 4, 5);
            dtpRegis.Name = "dtpRegis";
            dtpRegis.Size = new Size(256, 30);
            dtpRegis.TabIndex = 25;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClass.Location = new Point(33, 126);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(49, 23);
            lblClass.TabIndex = 24;
            lblClass.Text = "Class";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomain.Location = new Point(575, 124);
            lblDomain.Margin = new Padding(4, 0, 4, 0);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(73, 23);
            lblDomain.TabIndex = 23;
            lblDomain.Text = "Domain";
            // 
            // cmbDomain
            // 
            cmbDomain.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDomain.AutoCompleteSource = AutoCompleteSource.HistoryList;
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Location = new Point(721, 124);
            cmbDomain.Margin = new Padding(4, 5, 4, 5);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(295, 31);
            cmbDomain.TabIndex = 1;
            // 
            // rdSuple
            // 
            rdSuple.AutoSize = true;
            rdSuple.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdSuple.Location = new Point(1020, 49);
            rdSuple.Margin = new Padding(4, 5, 4, 5);
            rdSuple.Name = "rdSuple";
            rdSuple.Size = new Size(155, 27);
            rdSuple.TabIndex = 4;
            rdSuple.TabStop = true;
            rdSuple.Text = "Supplementary";
            rdSuple.UseVisualStyleBackColor = true;
            // 
            // rdPrim
            // 
            rdPrim.AutoSize = true;
            rdPrim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdPrim.Location = new Point(575, 49);
            rdPrim.Margin = new Padding(4, 5, 4, 5);
            rdPrim.Name = "rdPrim";
            rdPrim.Size = new Size(164, 27);
            rdPrim.TabIndex = 5;
            rdPrim.TabStop = true;
            rdPrim.Text = "Primary Student";
            rdPrim.UseVisualStyleBackColor = true;
            rdPrim.CheckedChanged += rdPrim_CheckedChanged;
            // 
            // rdRTS
            // 
            rdRTS.AutoSize = true;
            rdRTS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdRTS.Location = new Point(356, 49);
            rdRTS.Margin = new Padding(4, 5, 4, 5);
            rdRTS.Name = "rdRTS";
            rdRTS.Size = new Size(131, 27);
            rdRTS.TabIndex = 6;
            rdRTS.TabStop = true;
            rdRTS.Text = "RTS Student";
            rdRTS.UseVisualStyleBackColor = true;
            // 
            // rdReg
            // 
            rdReg.AutoSize = true;
            rdReg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdReg.Location = new Point(21, 49);
            rdReg.Margin = new Padding(4, 5, 4, 5);
            rdReg.Name = "rdReg";
            rdReg.Size = new Size(162, 27);
            rdReg.TabIndex = 7;
            rdReg.TabStop = true;
            rdReg.Text = "Regular Student";
            rdReg.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            cmbClass.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbClass.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbClass.Location = new Point(170, 129);
            cmbClass.Margin = new Padding(4, 5, 4, 5);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(340, 31);
            cmbClass.TabIndex = 11;
            // 
            // txtStdFatherName
            // 
            txtStdFatherName.Location = new Point(721, 34);
            txtStdFatherName.Margin = new Padding(4, 5, 4, 5);
            txtStdFatherName.Name = "txtStdFatherName";
            txtStdFatherName.PlaceholderText = "Student Father Name";
            txtStdFatherName.Size = new Size(295, 30);
            txtStdFatherName.TabIndex = 0;
            txtStdFatherName.TextChanged += textBox1_TextChanged;
            // 
            // txtStdCNIC
            // 
            txtStdCNIC.Location = new Point(179, 141);
            txtStdCNIC.Margin = new Padding(4, 5, 4, 5);
            txtStdCNIC.Name = "txtStdCNIC";
            txtStdCNIC.PlaceholderText = "Enter Studetn CNIC";
            txtStdCNIC.Size = new Size(331, 30);
            txtStdCNIC.TabIndex = 16;
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(179, 34);
            txtStdName.Margin = new Padding(4, 5, 4, 5);
            txtStdName.Name = "txtStdName";
            txtStdName.PlaceholderText = "Enter Student Name";
            txtStdName.Size = new Size(331, 30);
            txtStdName.TabIndex = 17;
            txtStdName.TextChanged += textBox3_TextChanged;
            // 
            // txtFatherCNIC
            // 
            txtFatherCNIC.Location = new Point(1185, 34);
            txtFatherCNIC.Margin = new Padding(4, 5, 4, 5);
            txtFatherCNIC.Name = "txtFatherCNIC";
            txtFatherCNIC.PlaceholderText = "Enter Father CNIC";
            txtFatherCNIC.Size = new Size(278, 30);
            txtFatherCNIC.TabIndex = 19;
            txtFatherCNIC.TextChanged += textBox5_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(114, 18);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1579, 135);
            pnLogo.TabIndex = 25;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(510, 35);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // pnMainPn
            // 
            pnMainPn.BackColor = Color.RoyalBlue;
            pnMainPn.Controls.Add(pnAccadminc);
            pnMainPn.Controls.Add(pnPreq);
            pnMainPn.Controls.Add(pnPerMain);
            pnMainPn.Controls.Add(pnPerson);
            pnMainPn.Controls.Add(btnRegistation);
            pnMainPn.Location = new Point(114, 150);
            pnMainPn.Margin = new Padding(4, 5, 4, 5);
            pnMainPn.Name = "pnMainPn";
            pnMainPn.Size = new Size(1579, 1140);
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
            pnAccadminc.Location = new Point(37, 688);
            pnAccadminc.Margin = new Padding(4, 5, 4, 5);
            pnAccadminc.Name = "pnAccadminc";
            pnAccadminc.Size = new Size(1512, 314);
            pnAccadminc.TabIndex = 53;
            // 
            // cmbBoard
            // 
            cmbBoard.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBoard.FormattingEnabled = true;
            cmbBoard.Items.AddRange(new object[] { "Primary ", "FSD Board", "Lahore Board", "Islamabad Board" });
            cmbBoard.Location = new Point(671, 242);
            cmbBoard.Margin = new Padding(4, 5, 4, 5);
            cmbBoard.Name = "cmbBoard";
            cmbBoard.Size = new Size(219, 31);
            cmbBoard.TabIndex = 57;
            // 
            // cmbPrvDeg
            // 
            cmbPrvDeg.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPrvDeg.FormattingEnabled = true;
            cmbPrvDeg.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbPrvDeg.Location = new Point(179, 113);
            cmbPrvDeg.Margin = new Padding(4, 5, 4, 5);
            cmbPrvDeg.Name = "cmbPrvDeg";
            cmbPrvDeg.Size = new Size(239, 31);
            cmbPrvDeg.TabIndex = 56;
            // 
            // cmbPassingYear
            // 
            cmbPassingYear.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPassingYear.FormattingEnabled = true;
            cmbPassingYear.Items.AddRange(new object[] { "" });
            cmbPassingYear.Location = new Point(174, 233);
            cmbPassingYear.Margin = new Padding(4, 5, 4, 5);
            cmbPassingYear.Name = "cmbPassingYear";
            cmbPassingYear.Size = new Size(244, 31);
            cmbPassingYear.TabIndex = 55;
            // 
            // lblDegYear
            // 
            lblDegYear.AutoSize = true;
            lblDegYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDegYear.Location = new Point(19, 235);
            lblDegYear.Margin = new Padding(4, 0, 4, 0);
            lblDegYear.Name = "lblDegYear";
            lblDegYear.Size = new Size(107, 23);
            lblDegYear.TabIndex = 54;
            lblDegYear.Text = "Passing Year";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(675, 35);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(124, 32);
            label20.TabIndex = 43;
            label20.Text = "Accadmic";
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSchool.Location = new Point(899, 251);
            lblSchool.Margin = new Padding(4, 0, 4, 0);
            lblSchool.Name = "lblSchool";
            lblSchool.Size = new Size(82, 23);
            lblSchool.TabIndex = 52;
            lblSchool.Text = "Institute ";
            // 
            // txtTotalMark
            // 
            txtTotalMark.Location = new Point(1281, 103);
            txtTotalMark.Margin = new Padding(4, 5, 4, 5);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.PlaceholderText = "Enter Total Marks";
            txtTotalMark.Size = new Size(208, 30);
            txtTotalMark.TabIndex = 26;
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(985, 250);
            txtSchool.Margin = new Padding(4, 5, 4, 5);
            txtSchool.Name = "txtSchool";
            txtSchool.PlaceholderText = "Enter Institue Name";
            txtSchool.Size = new Size(504, 30);
            txtSchool.TabIndex = 51;
            // 
            // lblObtainMark
            // 
            lblObtainMark.AutoSize = true;
            lblObtainMark.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObtainMark.Location = new Point(899, 118);
            lblObtainMark.Margin = new Padding(4, 0, 4, 0);
            lblObtainMark.Name = "lblObtainMark";
            lblObtainMark.Size = new Size(59, 23);
            lblObtainMark.TabIndex = 27;
            lblObtainMark.Text = "Marks";
            lblObtainMark.Click += label3_Click;
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.BackColor = Color.RoyalBlue;
            lblRollNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRollNo.Location = new Point(465, 123);
            lblRollNo.Margin = new Padding(4, 0, 4, 0);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(179, 23);
            lblRollNo.TabIndex = 28;
            lblRollNo.Text = "Registration Number";
            // 
            // lblBoard
            // 
            lblBoard.AutoSize = true;
            lblBoard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoard.Location = new Point(473, 251);
            lblBoard.Margin = new Padding(4, 0, 4, 0);
            lblBoard.Name = "lblBoard";
            lblBoard.Size = new Size(142, 23);
            lblBoard.TabIndex = 49;
            lblBoard.Text = "Education Board";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeg.Location = new Point(21, 115);
            lblDeg.Margin = new Padding(4, 0, 4, 0);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(121, 23);
            lblDeg.TabIndex = 29;
            lblDeg.Text = "Previous Class";
            // 
            // txtObtainedMarks
            // 
            txtObtainedMarks.Location = new Point(985, 107);
            txtObtainedMarks.Margin = new Padding(4, 5, 4, 5);
            txtObtainedMarks.Name = "txtObtainedMarks";
            txtObtainedMarks.PlaceholderText = "Enter Obtain Marks";
            txtObtainedMarks.Size = new Size(229, 30);
            txtObtainedMarks.TabIndex = 45;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMarks.Location = new Point(1223, 109);
            lblTotalMarks.Margin = new Padding(4, 0, 4, 0);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(49, 23);
            lblTotalMarks.TabIndex = 37;
            lblTotalMarks.Text = "Total";
            // 
            // txtPrevReg
            // 
            txtPrevReg.Location = new Point(671, 113);
            txtPrevReg.Margin = new Padding(4, 5, 4, 5);
            txtPrevReg.Name = "txtPrevReg";
            txtPrevReg.PlaceholderText = "Prvious Registraion Number";
            txtPrevReg.Size = new Size(219, 30);
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
            pnPerMain.Location = new Point(37, 290);
            pnPerMain.Margin = new Padding(4, 5, 4, 5);
            pnPerMain.Name = "pnPerMain";
            pnPerMain.Size = new Size(1512, 391);
            pnPerMain.TabIndex = 42;
            // 
            // txtStdContact
            // 
            txtStdContact.Location = new Point(1185, 230);
            txtStdContact.Margin = new Padding(4, 5, 4, 5);
            txtStdContact.Name = "txtStdContact";
            txtStdContact.PlaceholderText = "Enter Student Contact";
            txtStdContact.Size = new Size(278, 30);
            txtStdContact.TabIndex = 49;
            txtStdContact.TextChanged += textBox1_TextChanged_2;
            // 
            // lblStdContact
            // 
            lblStdContact.AutoSize = true;
            lblStdContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdContact.Location = new Point(1038, 239);
            lblStdContact.Margin = new Padding(4, 0, 4, 0);
            lblStdContact.Name = "lblStdContact";
            lblStdContact.Size = new Size(138, 23);
            lblStdContact.TabIndex = 50;
            lblStdContact.Text = "student Contact";
            // 
            // cmbFatherJob
            // 
            cmbFatherJob.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFatherJob.FormattingEnabled = true;
            cmbFatherJob.Items.AddRange(new object[] { "Labour", "Doctor", "Teacher", "Army", "Other" });
            cmbFatherJob.Location = new Point(179, 313);
            cmbFatherJob.Margin = new Padding(4, 5, 4, 5);
            cmbFatherJob.Name = "cmbFatherJob";
            cmbFatherJob.Size = new Size(331, 31);
            cmbFatherJob.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 47;
            label2.Text = "Student City";
            label2.Click += label2_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(721, 314);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Residential City";
            txtCity.Size = new Size(295, 30);
            txtCity.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1039, 322);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 45;
            label1.Text = "Student Address";
            // 
            // txtStdAddress
            // 
            txtStdAddress.Location = new Point(1185, 314);
            txtStdAddress.Name = "txtStdAddress";
            txtStdAddress.PlaceholderText = "Enter Student Address";
            txtStdAddress.Size = new Size(278, 30);
            txtStdAddress.TabIndex = 29;
            // 
            // lblGend
            // 
            lblGend.AutoSize = true;
            lblGend.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGend.Location = new Point(575, 141);
            lblGend.Margin = new Padding(4, 0, 4, 0);
            lblGend.Name = "lblGend";
            lblGend.Size = new Size(68, 23);
            lblGend.TabIndex = 44;
            lblGend.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(721, 141);
            cmbGender.Margin = new Padding(4, 5, 4, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(295, 31);
            cmbGender.TabIndex = 43;
            // 
            // txtFatherContact
            // 
            txtFatherContact.Location = new Point(179, 230);
            txtFatherContact.Margin = new Padding(4, 5, 4, 5);
            txtFatherContact.Name = "txtFatherContact";
            txtFatherContact.PlaceholderText = "Enter Father Mobile Number";
            txtFatherContact.Size = new Size(331, 30);
            txtFatherContact.TabIndex = 23;
            // 
            // txtWatsApp
            // 
            txtWatsApp.Location = new Point(721, 230);
            txtWatsApp.Margin = new Padding(4, 5, 4, 5);
            txtWatsApp.Name = "txtWatsApp";
            txtWatsApp.PlaceholderText = "Enter Watsapp Number";
            txtWatsApp.Size = new Size(295, 30);
            txtWatsApp.TabIndex = 21;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(1185, 141);
            dtpDOB.Margin = new Padding(4, 5, 4, 5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(278, 30);
            dtpDOB.TabIndex = 42;
            // 
            // lblFatherMob
            // 
            lblFatherMob.AutoSize = true;
            lblFatherMob.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatherMob.Location = new Point(9, 242);
            lblFatherMob.Margin = new Padding(4, 0, 4, 0);
            lblFatherMob.Name = "lblFatherMob";
            lblFatherMob.Size = new Size(159, 23);
            lblFatherMob.TabIndex = 30;
            lblFatherMob.Text = "Father Mobile No :";
            // 
            // lblStdCNIC
            // 
            lblStdCNIC.AutoSize = true;
            lblStdCNIC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdCNIC.Location = new Point(19, 141);
            lblStdCNIC.Margin = new Padding(4, 0, 4, 0);
            lblStdCNIC.Name = "lblStdCNIC";
            lblStdCNIC.Size = new Size(119, 23);
            lblStdCNIC.TabIndex = 31;
            lblStdCNIC.Text = "Student CNIC";
            // 
            // lblFathCnic
            // 
            lblFathCnic.AutoSize = true;
            lblFathCnic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFathCnic.Location = new Point(1038, 35);
            lblFathCnic.Margin = new Padding(4, 0, 4, 0);
            lblFathCnic.Name = "lblFathCnic";
            lblFathCnic.Size = new Size(105, 23);
            lblFathCnic.TabIndex = 40;
            lblFathCnic.Text = "Father CNIC";
            // 
            // lblStdName
            // 
            lblStdName.AutoSize = true;
            lblStdName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdName.Location = new Point(19, 46);
            lblStdName.Margin = new Padding(4, 0, 4, 0);
            lblStdName.Name = "lblStdName";
            lblStdName.Size = new Size(126, 23);
            lblStdName.TabIndex = 32;
            lblStdName.Text = "Student Name";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDob.Location = new Point(1038, 147);
            lblDob.Margin = new Padding(4, 0, 4, 0);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(118, 23);
            lblDob.TabIndex = 39;
            lblDob.Text = "Date Of Birth";
            // 
            // lblFatherName
            // 
            lblFatherName.AutoSize = true;
            lblFatherName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatherName.Location = new Point(575, 46);
            lblFatherName.Margin = new Padding(4, 0, 4, 0);
            lblFatherName.Name = "lblFatherName";
            lblFatherName.Size = new Size(112, 23);
            lblFatherName.TabIndex = 33;
            lblFatherName.Text = "Father Name";
            // 
            // lblWatsap
            // 
            lblWatsap.AutoSize = true;
            lblWatsap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWatsap.Location = new Point(575, 230);
            lblWatsap.Margin = new Padding(4, 0, 4, 0);
            lblWatsap.Name = "lblWatsap";
            lblWatsap.Size = new Size(154, 23);
            lblWatsap.TabIndex = 34;
            lblWatsap.Text = "WatsApp Number";
            // 
            // lblFathOcc
            // 
            lblFathOcc.AutoSize = true;
            lblFathOcc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFathOcc.Location = new Point(4, 316);
            lblFathOcc.Margin = new Padding(4, 0, 4, 0);
            lblFathOcc.Name = "lblFathOcc";
            lblFathOcc.Size = new Size(156, 23);
            lblFathOcc.TabIndex = 35;
            lblFathOcc.Text = "Father Occupation";
            // 
            // pnPerson
            // 
            pnPerson.BackColor = Color.LightGreen;
            pnPerson.Controls.Add(label19);
            pnPerson.Location = new Point(0, 0);
            pnPerson.Margin = new Padding(4, 5, 4, 5);
            pnPerson.Name = "pnPerson";
            pnPerson.Size = new Size(1579, 70);
            pnPerson.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(570, 14);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(439, 32);
            label19.TabIndex = 1;
            label19.Text = "Personal And Education  Information";
            // 
            // pnHide
            // 
            pnHide.Location = new Point(57, 1014);
            pnHide.Margin = new Padding(4, 5, 4, 5);
            pnHide.Name = "pnHide";
            pnHide.Size = new Size(32, 153);
            pnHide.TabIndex = 27;
            // 
            // RegisTracionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1781, 1055);
            Controls.Add(pnHide);
            Controls.Add(pnMainPn);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
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