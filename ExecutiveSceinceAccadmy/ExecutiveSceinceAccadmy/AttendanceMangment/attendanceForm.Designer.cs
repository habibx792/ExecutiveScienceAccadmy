namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    partial class attendanceForm
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
        {            pnLogo = new Panel();
            lbLogo = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label1 = new Label();
            subject = new Label();
            label3 = new Label();
            label4 = new Label();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(73, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1178, 88);
            pnLogo.TabIndex = 11;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(356, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 23);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(995, 146);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(256, 23);
            comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(673, 146);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(285, 23);
            comboBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(340, 146);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(238, 23);
            comboBox4.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 115);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "Class";
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Location = new Point(340, 115);
            subject.Name = "subject";
            subject.Size = new Size(38, 15);
            subject.TabIndex = 17;
            subject.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 115);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(995, 115);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // attendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 648);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(subject);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(pnLogo);
            Name = "attendanceForm";
            Text = "attendanceForm";
            Load += attendanceForm_Load;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel pnLogo;
        private Label lbLogo;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label1;
        private Label subject;
        private Label label3;
        private Label label4;
    }
}