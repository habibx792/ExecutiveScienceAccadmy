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
        {
            pnLogo = new Panel();
            label1 = new Label();
            btnMark = new Button();
            btnSujectWise = new Button();
            pnMain = new Panel();
            btnTeacherAttendRep = new Button();
            btnUpAtt = new Button();
            btnDashBoad = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label1);
            pnLogo.Location = new Point(10, 9);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(591, 88);
            pnLogo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 70, 140);
            label1.Location = new Point(87, 26);
            label1.Name = "label1";
            label1.Size = new Size(426, 45);
            label1.TabIndex = 14;
            label1.Text = "Executive Science Academy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMark
            // 
            btnMark.BackColor = SystemColors.Highlight;
            btnMark.ForeColor = Color.White;
            btnMark.Location = new Point(44, 41);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(229, 48);
            btnMark.TabIndex = 24;
            btnMark.Text = "Class Wise";
            btnMark.UseVisualStyleBackColor = false;
            btnMark.Click += btnMark_Click;
            // 
            // btnSujectWise
            // 
            btnSujectWise.BackColor = SystemColors.Highlight;
            btnSujectWise.ForeColor = Color.White;
            btnSujectWise.Location = new Point(44, 187);
            btnSujectWise.Name = "btnSujectWise";
            btnSujectWise.Size = new Size(234, 48);
            btnSujectWise.TabIndex = 20;
            btnSujectWise.Text = "Suject Wise";
            btnSujectWise.UseVisualStyleBackColor = false;
            btnSujectWise.Click += btnSujectWise_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnTeacherAttendRep);
            pnMain.Controls.Add(btnMark);
            pnMain.Controls.Add(btnUpAtt);
            pnMain.Controls.Add(btnSujectWise);
            pnMain.Controls.Add(btnDashBoad);
            pnMain.Location = new Point(10, 93);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(591, 278);
            pnMain.TabIndex = 26;
            // 
            // btnTeacherAttendRep
            // 
            btnTeacherAttendRep.BackColor = SystemColors.Highlight;
            btnTeacherAttendRep.ForeColor = Color.White;
            btnTeacherAttendRep.Location = new Point(44, 110);
            btnTeacherAttendRep.Name = "btnTeacherAttendRep";
            btnTeacherAttendRep.Size = new Size(231, 49);
            btnTeacherAttendRep.TabIndex = 25;
            btnTeacherAttendRep.Text = "Teacher Attendce Report";
            btnTeacherAttendRep.UseVisualStyleBackColor = false;
            btnTeacherAttendRep.Click += btnTeacherAttendRep_Click;
            // 
            // btnUpAtt
            // 
            btnUpAtt.BackColor = SystemColors.Highlight;
            btnUpAtt.ForeColor = Color.White;
            btnUpAtt.Location = new Point(321, 41);
            btnUpAtt.Name = "btnUpAtt";
            btnUpAtt.Size = new Size(231, 49);
            btnUpAtt.TabIndex = 23;
            btnUpAtt.Text = "Teacher Attendance";
            btnUpAtt.UseVisualStyleBackColor = false;
            btnUpAtt.Click += btnUpAtt_Click;
            // 
            // btnDashBoad
            // 
            btnDashBoad.BackColor = SystemColors.Highlight;
            btnDashBoad.ForeColor = Color.White;
            btnDashBoad.Location = new Point(321, 110);
            btnDashBoad.Name = "btnDashBoad";
            btnDashBoad.Size = new Size(237, 53);
            btnDashBoad.TabIndex = 22;
            btnDashBoad.Text = "Attendance DashBoard";
            btnDashBoad.UseVisualStyleBackColor = false;
            btnDashBoad.Click += btnDashBoad_Click;
            // 
            // attendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(614, 384);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Name = "attendanceForm";
            Text = "attendanceForm";
            Load += attendanceForm_Load;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel pnLogo;
        private Button btnMark;
        private Button btnSujectWise;
        private Panel pnMain;
        private Button btnUpAtt;
        private Button btnDashBoad;
        private Label label1;
        private Button btnTeacherAttendRep;
    }
}