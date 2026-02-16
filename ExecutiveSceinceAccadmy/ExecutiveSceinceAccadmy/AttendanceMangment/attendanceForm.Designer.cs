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
            btnRts = new Button();
            btnMark = new Button();
            btnSujectWise = new Button();
            pnMain = new Panel();
            btnSum = new Button();
            btnUpAtt = new Button();
            btnDashBoad = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
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
            // btnRts
            // 
            btnRts.Location = new Point(587, 41);
            btnRts.Name = "btnRts";
            btnRts.Size = new Size(237, 130);
            btnRts.TabIndex = 25;
            btnRts.Text = "RTC Class Wise";
            btnRts.UseVisualStyleBackColor = true;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(44, 41);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(229, 130);
            btnMark.TabIndex = 24;
            btnMark.Text = "Class Wise";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnSujectWise
            // 
            btnSujectWise.Location = new Point(324, 41);
            btnSujectWise.Name = "btnSujectWise";
            btnSujectWise.Size = new Size(221, 130);
            btnSujectWise.TabIndex = 20;
            btnSujectWise.Text = "Suject Wise";
            btnSujectWise.UseVisualStyleBackColor = true;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnMark);
            pnMain.Controls.Add(btnRts);
            pnMain.Controls.Add(btnSum);
            pnMain.Controls.Add(btnUpAtt);
            pnMain.Controls.Add(btnSujectWise);
            pnMain.Controls.Add(btnDashBoad);
            pnMain.Location = new Point(239, 173);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(873, 408);
            pnMain.TabIndex = 26;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(44, 234);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(229, 130);
            btnSum.TabIndex = 21;
            btnSum.Text = "Show Summary";
            btnSum.UseVisualStyleBackColor = true;
            // 
            // btnUpAtt
            // 
            btnUpAtt.Location = new Point(314, 234);
            btnUpAtt.Name = "btnUpAtt";
            btnUpAtt.Size = new Size(231, 130);
            btnUpAtt.TabIndex = 23;
            btnUpAtt.Text = "Update Attedance";
            btnUpAtt.UseVisualStyleBackColor = true;
            // 
            // btnDashBoad
            // 
            btnDashBoad.Location = new Point(587, 234);
            btnDashBoad.Name = "btnDashBoad";
            btnDashBoad.Size = new Size(237, 130);
            btnDashBoad.TabIndex = 22;
            btnDashBoad.Text = "Attendance DashBoard";
            btnDashBoad.UseVisualStyleBackColor = true;
            // 
            // attendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 648);
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
        private Label lbLogo;
        private Button btnRts;
        private Button btnMark;
        private Button btnSujectWise;
        private Panel pnMain;
        private Button btnSum;
        private Button btnUpAtt;
        private Button btnDashBoad;
    }
}