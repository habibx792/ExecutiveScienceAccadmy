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
            btnRegistation.Location = new Point(1051, 661);
            btnRegistation.Name = "btnRegistation";
            btnRegistation.Size = new Size(154, 59);
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
            pnPreq.Location = new Point(29, 52);
            pnPreq.Name = "pnPreq";
            pnPreq.Size = new Size(1176, 131);
            pnPreq.TabIndex = 1;
            pnPreq.Paint += pnPreq_Paint;
            // 
            // lblRegiDate
            // 
            lblRegiDate.AutoSize = true;
            lblRegiDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegiDate.Location = new Point(793, 81);
            lblRegiDate.Name = "lblRegiDate";
            lblRegiDate.Size = new Size(116, 17);
            lblRegiDate.TabIndex = 26;
            lblRegiDate.Text = "Registration Date";
            // 
            // dtpRegis
            // 
            dtpRegis.Location = new Point(915, 75);
            dtpRegis.Name = "dtpRegis";
            dtpRegis.Size = new Size(200, 23);
            dtpRegis.TabIndex = 25;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClass.Location = new Point(26, 82);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(39, 17);
            lblClass.TabIndex = 24;
            lblClass.Text = "Class";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomain.Location = new Point(447, 81);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(57, 17);
            lblDomain.TabIndex = 23;
            lblDomain.Text = "Domain";
            // 
            // cmbDomain
            // 
            cmbDomain.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDomain.AutoCompleteSource = AutoCompleteSource.HistoryList;
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Location = new Point(561, 81);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(230, 23);
            cmbDomain.TabIndex = 1;
            // 
            // rdSuple
            // 
            rdSuple.AutoSize = true;
            rdSuple.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdSuple.Location = new Point(793, 32);
            rdSuple.Name = "rdSuple";
            rdSuple.Size = new Size(120, 21);
            rdSuple.TabIndex = 4;
            rdSuple.TabStop = true;
            rdSuple.Text = "Supplementary";
            rdSuple.UseVisualStyleBackColor = true;
            // 
            // rdPrim
            // 
            rdPrim.AutoSize = true;
            rdPrim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdPrim.Location = new Point(447, 32);
            rdPrim.Name = "rdPrim";
            rdPrim.Size = new Size(127, 21);
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
            rdRTS.Location = new Point(277, 32);
            rdRTS.Name = "rdRTS";
            rdRTS.Size = new Size(101, 21);
            rdRTS.TabIndex = 6;
            rdRTS.TabStop = true;
            rdRTS.Text = "RTS Student";
            rdRTS.UseVisualStyleBackColor = true;
            // 
            // rdReg
            // 
            rdReg.AutoSize = true;
            rdReg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdReg.Location = new Point(16, 32);
            rdReg.Name = "rdReg";
            rdReg.Size = new Size(125, 21);
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
            cmbClass.Location = new Point(132, 84);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(265, 23);
            cmbClass.TabIndex = 11;
            // 
            // txtStdFatherName
            // 
            txtStdFatherName.Location = new Point(561, 22);
            txtStdFatherName.Name = "txtStdFatherName";
            txtStdFatherName.PlaceholderText = "Student Father Name";
            txtStdFatherName.Size = new Size(230, 23);
            txtStdFatherName.TabIndex = 0;
            txtStdFatherName.TextChanged += textBox1_TextChanged;
            // 
            // txtStdCNIC
            // 
            txtStdCNIC.Location = new Point(139, 92);
            txtStdCNIC.Name = "txtStdCNIC";
            txtStdCNIC.PlaceholderText = "Enter Studetn CNIC";
            txtStdCNIC.Size = new Size(258, 23);
            txtStdCNIC.TabIndex = 16;
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(139, 22);
            txtStdName.Name = "txtStdName";
            txtStdName.PlaceholderText = "Enter Student Name";
            txtStdName.Size = new Size(258, 23);
            txtStdName.TabIndex = 17;
            txtStdName.TextChanged += textBox3_TextChanged;
            // 
            // txtFatherCNIC
            // 
            txtFatherCNIC.Location = new Point(922, 22);
            txtFatherCNIC.Name = "txtFatherCNIC";
            txtFatherCNIC.PlaceholderText = "Enter Father CNIC";
            txtFatherCNIC.Size = new Size(217, 23);
            txtFatherCNIC.TabIndex = 19;
            txtFatherCNIC.TextChanged += textBox5_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
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
            pnMainPn.BackColor = Color.RoyalBlue;
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
            cmbBoard.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBoard.FormattingEnabled = true;
            cmbBoard.Items.AddRange(new object[] { "Primary ", "FSD Board", "Lahore Board", "Islamabad Board" });
            cmbBoard.Location = new Point(522, 158);
            cmbBoard.Name = "cmbBoard";
            cmbBoard.Size = new Size(171, 23);
            cmbBoard.TabIndex = 57;
            // 
            // cmbPrvDeg
            // 
            cmbPrvDeg.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPrvDeg.FormattingEnabled = true;
            cmbPrvDeg.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbPrvDeg.Location = new Point(139, 74);
            cmbPrvDeg.Name = "cmbPrvDeg";
            cmbPrvDeg.Size = new Size(187, 23);
            cmbPrvDeg.TabIndex = 56;
            // 
            // cmbPassingYear
            // 
            cmbPassingYear.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPassingYear.FormattingEnabled = true;
            cmbPassingYear.Items.AddRange(new object[] { "" });
            cmbPassingYear.Location = new Point(135, 152);
            cmbPassingYear.Name = "cmbPassingYear";
            cmbPassingYear.Size = new Size(191, 23);
            cmbPassingYear.TabIndex = 55;
            // 
            // lblDegYear
            // 
            lblDegYear.AutoSize = true;
            lblDegYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDegYear.Location = new Point(15, 153);
            lblDegYear.Name = "lblDegYear";
            lblDegYear.Size = new Size(85, 17);
            lblDegYear.TabIndex = 54;
            lblDegYear.Text = "Passing Year";
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
            lblSchool.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSchool.Location = new Point(699, 164);
            lblSchool.Name = "lblSchool";
            lblSchool.Size = new Size(64, 17);
            lblSchool.TabIndex = 52;
            lblSchool.Text = "Institute ";
            // 
            // txtTotalMark
            // 
            txtTotalMark.Location = new Point(996, 67);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.PlaceholderText = "Enter Total Marks";
            txtTotalMark.Size = new Size(163, 23);
            txtTotalMark.TabIndex = 26;
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(766, 163);
            txtSchool.Name = "txtSchool";
            txtSchool.PlaceholderText = "Enter Institue Name";
            txtSchool.Size = new Size(393, 23);
            txtSchool.TabIndex = 51;
            // 
            // lblObtainMark
            // 
            lblObtainMark.AutoSize = true;
            lblObtainMark.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObtainMark.Location = new Point(699, 77);
            lblObtainMark.Name = "lblObtainMark";
            lblObtainMark.Size = new Size(45, 17);
            lblObtainMark.TabIndex = 27;
            lblObtainMark.Text = "Marks";
            lblObtainMark.Click += label3_Click;
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.BackColor = Color.RoyalBlue;
            lblRollNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRollNo.Location = new Point(362, 80);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(137, 17);
            lblRollNo.TabIndex = 28;
            lblRollNo.Text = "Registration Number";
            // 
            // lblBoard
            // 
            lblBoard.AutoSize = true;
            lblBoard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoard.Location = new Point(368, 164);
            lblBoard.Name = "lblBoard";
            lblBoard.Size = new Size(109, 17);
            lblBoard.TabIndex = 49;
            lblBoard.Text = "Education Board";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeg.Location = new Point(16, 75);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(96, 17);
            lblDeg.TabIndex = 29;
            lblDeg.Text = "Previous Class";
            // 
            // txtObtainedMarks
            // 
            txtObtainedMarks.Location = new Point(766, 70);
            txtObtainedMarks.Name = "txtObtainedMarks";
            txtObtainedMarks.PlaceholderText = "Enter Obtain Marks";
            txtObtainedMarks.Size = new Size(179, 23);
            txtObtainedMarks.TabIndex = 45;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMarks.Location = new Point(951, 71);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(39, 17);
            lblTotalMarks.TabIndex = 37;
            lblTotalMarks.Text = "Total";
            // 
            // txtPrevReg
            // 
            txtPrevReg.Location = new Point(522, 74);
            txtPrevReg.Name = "txtPrevReg";
            txtPrevReg.PlaceholderText = "Prvious Registraion Number";
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
            txtStdContact.Location = new Point(922, 150);
            txtStdContact.Name = "txtStdContact";
            txtStdContact.PlaceholderText = "Enter Student Contact";
            txtStdContact.Size = new Size(217, 23);
            txtStdContact.TabIndex = 49;
            txtStdContact.TextChanged += textBox1_TextChanged_2;
            // 
            // lblStdContact
            // 
            lblStdContact.AutoSize = true;
            lblStdContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdContact.Location = new Point(807, 156);
            lblStdContact.Name = "lblStdContact";
            lblStdContact.Size = new Size(106, 17);
            lblStdContact.TabIndex = 50;
            lblStdContact.Text = "student Contact";
            // 
            // cmbFatherJob
            // 
            cmbFatherJob.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFatherJob.FormattingEnabled = true;
            cmbFatherJob.Items.AddRange(new object[] { "Labour", "Doctor", "Teacher", "Army", "Other" });
            cmbFatherJob.Location = new Point(139, 204);
            cmbFatherJob.Name = "cmbFatherJob";
            cmbFatherJob.Size = new Size(258, 23);
            cmbFatherJob.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(447, 206);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 47;
            label2.Text = "Student City";
            label2.Click += label2_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(561, 205);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Residential City";
            txtCity.Size = new Size(230, 23);
            txtCity.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(808, 210);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 45;
            label1.Text = "Student Address";
            // 
            // txtStdAddress
            // 
            txtStdAddress.Location = new Point(922, 205);
            txtStdAddress.Margin = new Padding(2);
            txtStdAddress.Name = "txtStdAddress";
            txtStdAddress.PlaceholderText = "Enter Student Address";
            txtStdAddress.Size = new Size(217, 23);
            txtStdAddress.TabIndex = 29;
            // 
            // lblGend
            // 
            lblGend.AutoSize = true;
            lblGend.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGend.Location = new Point(447, 92);
            lblGend.Name = "lblGend";
            lblGend.Size = new Size(52, 17);
            lblGend.TabIndex = 44;
            lblGend.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(561, 92);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(230, 23);
            cmbGender.TabIndex = 43;
            // 
            // txtFatherContact
            // 
            txtFatherContact.Location = new Point(139, 150);
            txtFatherContact.Name = "txtFatherContact";
            txtFatherContact.PlaceholderText = "Enter Father Mobile Number";
            txtFatherContact.Size = new Size(258, 23);
            txtFatherContact.TabIndex = 23;
            // 
            // txtWatsApp
            // 
            txtWatsApp.Location = new Point(561, 150);
            txtWatsApp.Name = "txtWatsApp";
            txtWatsApp.PlaceholderText = "Enter Watsapp Number";
            txtWatsApp.Size = new Size(230, 23);
            txtWatsApp.TabIndex = 21;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(922, 92);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(217, 23);
            dtpDOB.TabIndex = 42;
            // 
            // lblFatherMob
            // 
            lblFatherMob.AutoSize = true;
            lblFatherMob.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatherMob.Location = new Point(7, 158);
            lblFatherMob.Name = "lblFatherMob";
            lblFatherMob.Size = new Size(124, 17);
            lblFatherMob.TabIndex = 30;
            lblFatherMob.Text = "Father Mobile No :";
            // 
            // lblStdCNIC
            // 
            lblStdCNIC.AutoSize = true;
            lblStdCNIC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdCNIC.Location = new Point(15, 92);
            lblStdCNIC.Name = "lblStdCNIC";
            lblStdCNIC.Size = new Size(90, 17);
            lblStdCNIC.TabIndex = 31;
            lblStdCNIC.Text = "Student CNIC";
            // 
            // lblFathCnic
            // 
            lblFathCnic.AutoSize = true;
            lblFathCnic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFathCnic.Location = new Point(807, 23);
            lblFathCnic.Name = "lblFathCnic";
            lblFathCnic.Size = new Size(81, 17);
            lblFathCnic.TabIndex = 40;
            lblFathCnic.Text = "Father CNIC";
            // 
            // lblStdName
            // 
            lblStdName.AutoSize = true;
            lblStdName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStdName.Location = new Point(15, 30);
            lblStdName.Name = "lblStdName";
            lblStdName.Size = new Size(96, 17);
            lblStdName.TabIndex = 32;
            lblStdName.Text = "Student Name";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDob.Location = new Point(807, 96);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(90, 17);
            lblDob.TabIndex = 39;
            lblDob.Text = "Date Of Birth";
            // 
            // lblFatherName
            // 
            lblFatherName.AutoSize = true;
            lblFatherName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatherName.Location = new Point(447, 30);
            lblFatherName.Name = "lblFatherName";
            lblFatherName.Size = new Size(87, 17);
            lblFatherName.TabIndex = 33;
            lblFatherName.Text = "Father Name";
            // 
            // lblWatsap
            // 
            lblWatsap.AutoSize = true;
            lblWatsap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWatsap.Location = new Point(447, 150);
            lblWatsap.Name = "lblWatsap";
            lblWatsap.Size = new Size(117, 17);
            lblWatsap.TabIndex = 34;
            lblWatsap.Text = "WatsApp Number";
            // 
            // lblFathOcc
            // 
            lblFathOcc.AutoSize = true;
            lblFathOcc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFathOcc.Location = new Point(3, 206);
            lblFathOcc.Name = "lblFathOcc";
            lblFathOcc.Size = new Size(121, 17);
            lblFathOcc.TabIndex = 35;
            lblFathOcc.Text = "Father Occupation";
            // 
            // pnPerson
            // 
            pnPerson.BackColor = Color.LightGreen;
            pnPerson.Controls.Add(label19);
            pnPerson.Location = new Point(0, 3);
            pnPerson.Name = "pnPerson";
            pnPerson.Size = new Size(1225, 43);
            pnPerson.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(443, 9);
            label19.Name = "label19";
            label19.Size = new Size(327, 25);
            label19.TabIndex = 1;
            label19.Text = "Person And Education  Information";
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
            BackColor = Color.RoyalBlue;
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