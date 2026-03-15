namespace ExecutiveSceinceAccadmy.TeacherMangement
{
    partial class HireingForm
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
            label4 = new Label();
            txtTeachName = new TextBox();
            txtTeachCnic = new TextBox();
            cmbCity = new ComboBox();
            cmbQualification = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            txtFatherCnic = new TextBox();
            txtFaterName = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtAddress = new TextBox();
            label14 = new Label();
            panel1 = new Panel();
            chkSenior = new CheckBox();
            lblsalType = new Label();
            txtType = new TextBox();
            label2 = new Label();
            rdPercent = new RadioButton();
            rdSal = new RadioButton();
            cmbCountry = new ComboBox();
            btnHire = new Button();
            dtTeacherSubject = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTeacherSubject).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 25);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 10;
            // 
            // txtTeachName
            // 
            txtTeachName.Location = new Point(175, 343);
            txtTeachName.Name = "txtTeachName";
            txtTeachName.Size = new Size(272, 34);
            txtTeachName.TabIndex = 1;
            // 
            // txtTeachCnic
            // 
            txtTeachCnic.Location = new Point(175, 404);
            txtTeachCnic.Name = "txtTeachCnic";
            txtTeachCnic.Size = new Size(272, 34);
            txtTeachCnic.TabIndex = 13;
            txtTeachCnic.TextChanged += textBox4_TextChanged;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(704, 406);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(272, 36);
            cmbCity.TabIndex = 20;
            // 
            // cmbQualification
            // 
            cmbQualification.FormattingEnabled = true;
            cmbQualification.Location = new Point(704, 527);
            cmbQualification.Name = "cmbQualification";
            cmbQualification.Size = new Size(272, 36);
            cmbQualification.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 547);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 23;
            label5.Text = "Qualification";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(530, 409);
            label9.Name = "label9";
            label9.Size = new Size(49, 28);
            label9.TabIndex = 28;
            label9.Text = "City";
            // 
            // txtFatherCnic
            // 
            txtFatherCnic.Location = new Point(175, 528);
            txtFatherCnic.Name = "txtFatherCnic";
            txtFatherCnic.Size = new Size(272, 34);
            txtFatherCnic.TabIndex = 26;
            // 
            // txtFaterName
            // 
            txtFaterName.Location = new Point(177, 461);
            txtFaterName.Name = "txtFaterName";
            txtFaterName.Size = new Size(270, 34);
            txtFaterName.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 456);
            label11.Name = "label11";
            label11.Size = new Size(133, 28);
            label11.TabIndex = 30;
            label11.Text = "Father Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 396);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 31;
            label12.Text = "Cnic";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 531);
            label13.Name = "label13";
            label13.Size = new Size(123, 28);
            label13.TabIndex = 32;
            label13.Text = "Father CNIC";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(704, 474);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(272, 34);
            txtAddress.TabIndex = 33;
            txtAddress.TextChanged += textBox8_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(530, 349);
            label14.Name = "label14";
            label14.Size = new Size(88, 28);
            label14.TabIndex = 34;
            label14.Text = "Country";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(chkSenior);
            panel1.Controls.Add(lblsalType);
            panel1.Controls.Add(txtType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rdPercent);
            panel1.Controls.Add(rdSal);
            panel1.Controls.Add(cmbCountry);
            panel1.Controls.Add(btnHire);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dtTeacherSubject);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtFaterName);
            panel1.Controls.Add(txtFatherCnic);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbQualification);
            panel1.Controls.Add(cmbCity);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTeachCnic);
            panel1.Controls.Add(txtTeachName);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 721);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // chkSenior
            // 
            chkSenior.AutoSize = true;
            chkSenior.Location = new Point(175, 288);
            chkSenior.Name = "chkSenior";
            chkSenior.Size = new Size(173, 32);
            chkSenior.TabIndex = 41;
            chkSenior.Text = "Senior Teacher";
            chkSenior.UseVisualStyleBackColor = true;
            // 
            // lblsalType
            // 
            lblsalType.AutoSize = true;
            lblsalType.Location = new Point(530, 596);
            lblsalType.Name = "lblsalType";
            lblsalType.Size = new Size(69, 28);
            lblsalType.TabIndex = 40;
            lblsalType.Text = "salary";
            // 
            // txtType
            // 
            txtType.Location = new Point(704, 590);
            txtType.Name = "txtType";
            txtType.Size = new Size(272, 34);
            txtType.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 467);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 38;
            label2.Text = "Address";
            // 
            // rdPercent
            // 
            rdPercent.AutoSize = true;
            rdPercent.Location = new Point(530, 287);
            rdPercent.Name = "rdPercent";
            rdPercent.Size = new Size(138, 32);
            rdPercent.TabIndex = 37;
            rdPercent.TabStop = true;
            rdPercent.Text = "Percentage";
            rdPercent.UseVisualStyleBackColor = true;
            rdPercent.CheckedChanged += rdPercent_CheckedChanged;
            // 
            // rdSal
            // 
            rdSal.AutoSize = true;
            rdSal.Location = new Point(867, 287);
            rdSal.Name = "rdSal";
            rdSal.Size = new Size(109, 32);
            rdSal.TabIndex = 36;
            rdSal.TabStop = true;
            rdSal.Text = "Salaried";
            rdSal.UseVisualStyleBackColor = true;
            rdSal.CheckedChanged += rdSal_CheckedChanged;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(704, 341);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(272, 36);
            cmbCountry.TabIndex = 35;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // btnHire
            // 
            btnHire.Location = new Point(841, 649);
            btnHire.Name = "btnHire";
            btnHire.Size = new Size(135, 71);
            btnHire.TabIndex = 30;
            btnHire.Text = "Hire";
            btnHire.UseVisualStyleBackColor = true;
            btnHire.Click += btnHire_Click;
            // 
            // dtTeacherSubject
            // 
            dtTeacherSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTeacherSubject.Location = new Point(0, 0);
            dtTeacherSubject.Name = "dtTeacherSubject";
            dtTeacherSubject.RowHeadersWidth = 51;
            dtTeacherSubject.Size = new Size(1066, 236);
            dtTeacherSubject.TabIndex = 3;
            dtTeacherSubject.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 336);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // HireingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1130, 745);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "HireingForm";
            Text = "HireingForm";
            Load += HireingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtTeacherSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox txtTeachName;
        private TextBox txtTeachCnic;
        private ComboBox cmbCity;
        private ComboBox cmbQualification;
        private Label label5;
        private Label label9;
        private TextBox txtFatherCnic;
        private TextBox txtFaterName;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtAddress;
        private Label label14;
        private Panel panel1;
        private DataGridView dtTeacherSubject;
        private Label label1;
        private ComboBox cmbCountry;
        private Button btnHire;
        private RadioButton rdPercent;
        private RadioButton rdSal;
        private Label lblsalType;
        private TextBox txtType;
        private Label label2;
        private CheckBox chkSenior;
    }
}