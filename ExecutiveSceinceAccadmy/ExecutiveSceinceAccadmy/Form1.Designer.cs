namespace ExecutiveSceinceAccadmy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            btnStdReg = new Button();
            btnResult = new Button();
            btnAdmin = new Button();
            BtnAttend = new Button();
            btnReport = new Button();
            BtnFeeSub = new Button();
            pnMain = new Panel();
            stdBoard = new Button();
            btnTeacherBoard = new Button();
            btnExpense = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnStdReg
            // 
            btnStdReg.BackColor = Color.FromArgb(0, 120, 215);
            btnStdReg.FlatAppearance.BorderSize = 0;
            btnStdReg.FlatStyle = FlatStyle.Flat;
            btnStdReg.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnStdReg.ForeColor = Color.White;
            btnStdReg.Location = new Point(39, 46);
            btnStdReg.Margin = new Padding(4, 5, 4, 5);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(309, 153);
            btnStdReg.TabIndex = 0;
            btnStdReg.Text = "Registration";
            btnStdReg.UseVisualStyleBackColor = false;
            btnStdReg.Click += btnStdReg_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(0, 120, 215);
            btnResult.FlatAppearance.BorderSize = 0;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnResult.ForeColor = Color.White;
            btnResult.Location = new Point(386, 414);
            btnResult.Margin = new Padding(4, 5, 4, 5);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(309, 153);
            btnResult.TabIndex = 1;
            btnResult.Text = "Result Management";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(0, 120, 215);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(39, 414);
            btnAdmin.Margin = new Padding(4, 5, 4, 5);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(309, 153);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin Dashboard";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // BtnAttend
            // 
            BtnAttend.BackColor = Color.FromArgb(0, 120, 215);
            BtnAttend.FlatAppearance.BorderSize = 0;
            BtnAttend.FlatStyle = FlatStyle.Flat;
            BtnAttend.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnAttend.ForeColor = Color.White;
            BtnAttend.Location = new Point(39, 230);
            BtnAttend.Margin = new Padding(4, 5, 4, 5);
            BtnAttend.Name = "BtnAttend";
            BtnAttend.Size = new Size(309, 153);
            BtnAttend.TabIndex = 3;
            BtnAttend.Text = "Attendance";
            BtnAttend.UseVisualStyleBackColor = false;
            BtnAttend.Click += BtnAttend_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(0, 120, 215);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(721, 230);
            btnReport.Margin = new Padding(4, 5, 4, 5);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(309, 153);
            btnReport.TabIndex = 4;
            btnReport.Text = "Academy Reports";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // BtnFeeSub
            // 
            BtnFeeSub.BackColor = Color.FromArgb(0, 120, 215);
            BtnFeeSub.FlatAppearance.BorderSize = 0;
            BtnFeeSub.FlatStyle = FlatStyle.Flat;
            BtnFeeSub.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnFeeSub.ForeColor = Color.White;
            BtnFeeSub.Location = new Point(386, 46);
            BtnFeeSub.Margin = new Padding(4, 5, 4, 5);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(309, 153);
            BtnFeeSub.TabIndex = 5;
            BtnFeeSub.Text = "Fee Management";
            BtnFeeSub.UseVisualStyleBackColor = false;
            BtnFeeSub.Click += BtnFeeSub_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(255, 128, 128);
            pnMain.Controls.Add(btnStdReg);
            pnMain.Controls.Add(BtnFeeSub);
            pnMain.Controls.Add(stdBoard);
            pnMain.Controls.Add(btnTeacherBoard);
            pnMain.Controls.Add(BtnAttend);
            pnMain.Controls.Add(btnResult);
            pnMain.Controls.Add(btnReport);
            pnMain.Controls.Add(btnExpense);
            pnMain.Controls.Add(btnAdmin);
            pnMain.Location = new Point(42, 168);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1062, 613);
            pnMain.TabIndex = 6;
            // 
            // stdBoard
            // 
            stdBoard.BackColor = Color.FromArgb(0, 120, 215);
            stdBoard.FlatAppearance.BorderSize = 0;
            stdBoard.FlatStyle = FlatStyle.Flat;
            stdBoard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            stdBoard.ForeColor = Color.White;
            stdBoard.Location = new Point(386, 230);
            stdBoard.Margin = new Padding(4, 5, 4, 5);
            stdBoard.Name = "stdBoard";
            stdBoard.Size = new Size(309, 153);
            stdBoard.TabIndex = 6;
            stdBoard.Text = "Student Dashboard";
            stdBoard.UseVisualStyleBackColor = false;
            stdBoard.Click += stdBoard_Click;
            // 
            // btnTeacherBoard
            // 
            btnTeacherBoard.BackColor = Color.FromArgb(0, 120, 215);
            btnTeacherBoard.FlatAppearance.BorderSize = 0;
            btnTeacherBoard.FlatStyle = FlatStyle.Flat;
            btnTeacherBoard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTeacherBoard.ForeColor = Color.White;
            btnTeacherBoard.Location = new Point(721, 46);
            btnTeacherBoard.Margin = new Padding(4, 5, 4, 5);
            btnTeacherBoard.Name = "btnTeacherBoard";
            btnTeacherBoard.Size = new Size(309, 153);
            btnTeacherBoard.TabIndex = 7;
            btnTeacherBoard.Text = "Teacher Dashboard";
            btnTeacherBoard.UseVisualStyleBackColor = false;
            btnTeacherBoard.Click += btnTeacherBoard_Click;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.FromArgb(0, 120, 215);
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(721, 404);
            btnExpense.Margin = new Padding(4, 5, 4, 5);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(309, 153);
            btnExpense.TabIndex = 8;
            btnExpense.Text = "Expense Management";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(255, 128, 128);
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(42, 64);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1062, 103);
            pnLogo.TabIndex = 7;
            pnLogo.Paint += panel2_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(141, 26);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(776, 54);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            lbLogo.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 805);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Main Dashboard";
            Load += Form1_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private Button btnStdReg;
        private Button btnResult;
        private Button btnAdmin;
        private Button BtnAttend;
        private Button btnReport;
        private Button BtnFeeSub;
        private Panel pnMain;
        private Panel pnLogo;
        private Label lbLogo;
        private Button stdBoard;
        private Button btnExpense;
        private Button btnTeacherBoard;
    }
}
