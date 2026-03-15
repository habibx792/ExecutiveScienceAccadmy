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
            lbLogo = new Label();
            btnMark = new Button();
            btnSujectWise = new Button();
            pnMain = new Panel();
            btnUpAtt = new Button();
            btnDashBoad = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(13, 47);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(760, 135);
            pnLogo.TabIndex = 11;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(65, 42);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // btnMark
            // 
            btnMark.Location = new Point(57, 63);
            btnMark.Margin = new Padding(4, 5, 4, 5);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(294, 74);
            btnMark.TabIndex = 24;
            btnMark.Text = "Class Wise";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnSujectWise
            // 
            btnSujectWise.Location = new Point(417, 63);
            btnSujectWise.Margin = new Padding(4, 5, 4, 5);
            btnSujectWise.Name = "btnSujectWise";
            btnSujectWise.Size = new Size(301, 74);
            btnSujectWise.TabIndex = 20;
            btnSujectWise.Text = "Suject Wise";
            btnSujectWise.UseVisualStyleBackColor = true;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnMark);
            pnMain.Controls.Add(btnUpAtt);
            pnMain.Controls.Add(btnSujectWise);
            pnMain.Controls.Add(btnDashBoad);
            pnMain.Location = new Point(13, 175);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(760, 427);
            pnMain.TabIndex = 26;
            // 
            // btnUpAtt
            // 
            btnUpAtt.Location = new Point(57, 169);
            btnUpAtt.Margin = new Padding(4, 5, 4, 5);
            btnUpAtt.Name = "btnUpAtt";
            btnUpAtt.Size = new Size(297, 75);
            btnUpAtt.TabIndex = 23;
            btnUpAtt.Text = "Teacher Attendance";
            btnUpAtt.UseVisualStyleBackColor = true;
            btnUpAtt.Click += btnUpAtt_Click;
            // 
            // btnDashBoad
            // 
            btnDashBoad.Location = new Point(413, 169);
            btnDashBoad.Margin = new Padding(4, 5, 4, 5);
            btnDashBoad.Name = "btnDashBoad";
            btnDashBoad.Size = new Size(305, 81);
            btnDashBoad.TabIndex = 22;
            btnDashBoad.Text = "Attendance DashBoard";
            btnDashBoad.UseVisualStyleBackColor = true;
            btnDashBoad.Click += btnDashBoad_Click;
            // 
            // attendanceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(790, 636);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label lbLogo;
        private Button btnMark;
        private Button btnSujectWise;
        private Panel pnMain;
        private Button btnUpAtt;
        private Button btnDashBoad;
    }
}