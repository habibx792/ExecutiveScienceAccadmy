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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            rdSal = new RadioButton();
            rdPercent = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtTeachName.Location = new Point(189, 307);
            txtTeachName.Name = "txtTeachName";
            txtTeachName.Size = new Size(272, 34);
            txtTeachName.TabIndex = 1;
            // 
            // txtTeachCnic
            // 
            txtTeachCnic.Location = new Point(189, 368);
            txtTeachCnic.Name = "txtTeachCnic";
            txtTeachCnic.Size = new Size(272, 34);
            txtTeachCnic.TabIndex = 13;
            txtTeachCnic.TextChanged += textBox4_TextChanged;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(730, 307);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(272, 36);
            cmbCity.TabIndex = 20;
            // 
            // cmbQualification
            // 
            cmbQualification.FormattingEnabled = true;
            cmbQualification.Location = new Point(730, 487);
            cmbQualification.Name = "cmbQualification";
            cmbQualification.Size = new Size(272, 36);
            cmbQualification.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 498);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 23;
            label5.Text = "Qualification";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(536, 360);
            label9.Name = "label9";
            label9.Size = new Size(49, 28);
            label9.TabIndex = 28;
            label9.Text = "City";
            // 
            // txtFatherCnic
            // 
            txtFatherCnic.Location = new Point(189, 492);
            txtFatherCnic.Name = "txtFatherCnic";
            txtFatherCnic.Size = new Size(272, 34);
            txtFatherCnic.TabIndex = 26;
            // 
            // txtFaterName
            // 
            txtFaterName.Location = new Point(191, 425);
            txtFaterName.Name = "txtFaterName";
            txtFaterName.Size = new Size(270, 34);
            txtFaterName.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 420);
            label11.Name = "label11";
            label11.Size = new Size(133, 28);
            label11.TabIndex = 30;
            label11.Text = "Father Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 360);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 31;
            label12.Text = "Cnic";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 495);
            label13.Name = "label13";
            label13.Size = new Size(123, 28);
            label13.TabIndex = 32;
            label13.Text = "Father CNIC";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(730, 425);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(272, 34);
            txtAddress.TabIndex = 33;
            txtAddress.TextChanged += textBox8_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(536, 300);
            label14.Name = "label14";
            label14.Size = new Size(88, 28);
            label14.TabIndex = 34;
            label14.Text = "Country";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdPercent);
            panel1.Controls.Add(rdSal);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dataGridView1);
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
            panel1.Location = new Point(24, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 643);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 300);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1060, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(867, 542);
            button1.Name = "button1";
            button1.Size = new Size(135, 71);
            button1.TabIndex = 30;
            button1.Text = "Hire";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(730, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 36);
            comboBox1.TabIndex = 35;
            // 
            // rdSal
            // 
            rdSal.AutoSize = true;
            rdSal.Location = new Point(710, 240);
            rdSal.Name = "rdSal";
            rdSal.Size = new Size(109, 32);
            rdSal.TabIndex = 36;
            rdSal.TabStop = true;
            rdSal.Text = "Salaried";
            rdSal.UseVisualStyleBackColor = true;
            // 
            // rdPercent
            // 
            rdPercent.AutoSize = true;
            rdPercent.Location = new Point(222, 240);
            rdPercent.Name = "rdPercent";
            rdPercent.Size = new Size(138, 32);
            rdPercent.TabIndex = 37;
            rdPercent.TabStop = true;
            rdPercent.Text = "Percentage";
            rdPercent.UseVisualStyleBackColor = true;
            // 
            // HireingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 701);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "HireingForm";
            Text = "HireingForm";
            Load += HireingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private RadioButton rdPercent;
        private RadioButton rdSal;
    }
}