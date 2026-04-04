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
            btnUpAtt = new Button();
            btnDashBoad = new Button();
            btnTeacherAttendRep = new Button();
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 26);
            label1.Name = "label1";
            label1.Size = new Size(426, 45);
            label1.TabIndex = 14;
            label1.Text = "Executive Science Academy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(44, 41);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(229, 48);
            btnMark.TabIndex = 24;
            btnMark.Text = "Class Wise";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnSujectWise
            // 
            btnSujectWise.Location = new Point(324, 41);
            btnSujectWise.Name = "btnSujectWise";
            btnSujectWise.Size = new Size(234, 48);
            btnSujectWise.TabIndex = 20;
            btnSujectWise.Text = "Suject Wise";
            btnSujectWise.UseVisualStyleBackColor = true;
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
            // btnUpAtt
            // 
            btnUpAtt.Location = new Point(44, 110);
            btnUpAtt.Name = "btnUpAtt";
            btnUpAtt.Size = new Size(231, 49);
            btnUpAtt.TabIndex = 23;
            btnUpAtt.Text = "Teacher Attendance";
            btnUpAtt.UseVisualStyleBackColor = true;
            btnUpAtt.Click += btnUpAtt_Click;
            // 
            // btnDashBoad
            // 
            btnDashBoad.Location = new Point(321, 110);
            btnDashBoad.Name = "btnDashBoad";
            btnDashBoad.Size = new Size(237, 53);
            btnDashBoad.TabIndex = 22;
            btnDashBoad.Text = "Attendance DashBoard";
            btnDashBoad.UseVisualStyleBackColor = true;
            btnDashBoad.Click += btnDashBoad_Click;
            // 
            // btnTeacherAttendRep
            // 
            btnTeacherAttendRep.Location = new Point(44, 186);
            btnTeacherAttendRep.Name = "btnTeacherAttendRep";
            btnTeacherAttendRep.Size = new Size(231, 49);
            btnTeacherAttendRep.TabIndex = 25;
            btnTeacherAttendRep.Text = "Teacher Attendce Report";
            btnTeacherAttendRep.UseVisualStyleBackColor = true;
            btnTeacherAttendRep.Click += btnTeacherAttendRep_Click;
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