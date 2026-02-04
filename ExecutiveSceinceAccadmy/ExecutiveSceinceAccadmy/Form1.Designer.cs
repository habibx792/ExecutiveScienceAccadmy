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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStdReg = new Button();
            btnResult = new Button();
            btnAdmin = new Button();
            BtnAttend = new Button();
            btnReport = new Button();
            BtnFeeSub = new Button();
            pnMain = new Panel();
            btnExpense = new Button();
            btnTeacherBoard = new Button();
            stdBoard = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            lblMain = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnStdReg
            // 
            btnStdReg.BackColor = Color.Black;
            btnStdReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdReg.ForeColor = Color.Blue;
            btnStdReg.Location = new Point(27, 30);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(349, 129);
            btnStdReg.TabIndex = 0;
            btnStdReg.Text = " Registration Mangement";
            btnStdReg.UseVisualStyleBackColor = false;
            btnStdReg.Click += btnStdReg_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Black;
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.Blue;
            btnResult.Location = new Point(421, 188);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(349, 129);
            btnResult.TabIndex = 1;
            btnResult.Text = "Result Mangement";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Black;
            btnAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Blue;
            btnAdmin.Location = new Point(790, 342);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(348, 129);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin DashBoad";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // BtnAttend
            // 
            BtnAttend.BackColor = Color.Black;
            BtnAttend.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAttend.ForeColor = Color.Blue;
            BtnAttend.Location = new Point(28, 179);
            BtnAttend.Name = "BtnAttend";
            BtnAttend.Size = new Size(348, 129);
            BtnAttend.TabIndex = 3;
            BtnAttend.Text = "Attendance Mangement";
            BtnAttend.UseVisualStyleBackColor = false;
            BtnAttend.Click += BtnAttend_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Black;
            btnReport.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.Blue;
            btnReport.Location = new Point(421, 342);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(349, 129);
            btnReport.TabIndex = 4;
            btnReport.Text = "Accadmy Reports";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // BtnFeeSub
            // 
            BtnFeeSub.BackColor = Color.Black;
            BtnFeeSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFeeSub.ForeColor = Color.Blue;
            BtnFeeSub.Location = new Point(421, 30);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(340, 129);
            BtnFeeSub.TabIndex = 5;
            BtnFeeSub.Text = "Fee Management";
            BtnFeeSub.UseVisualStyleBackColor = false;
            BtnFeeSub.Click += BtnFeeSub_Click;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnExpense);
            pnMain.Controls.Add(btnTeacherBoard);
            pnMain.Controls.Add(stdBoard);
            pnMain.Controls.Add(btnStdReg);
            pnMain.Controls.Add(BtnFeeSub);
            pnMain.Controls.Add(btnResult);
            pnMain.Controls.Add(btnReport);
            pnMain.Controls.Add(btnAdmin);
            pnMain.Controls.Add(BtnAttend);
            pnMain.Location = new Point(114, 153);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1155, 483);
            pnMain.TabIndex = 6;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.Black;
            btnExpense.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.Blue;
            btnExpense.Location = new Point(28, 342);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(348, 129);
            btnExpense.TabIndex = 8;
            btnExpense.Text = "Expense Mangement";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnTeacherBoard
            // 
            btnTeacherBoard.BackColor = Color.Black;
            btnTeacherBoard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherBoard.ForeColor = Color.Blue;
            btnTeacherBoard.Location = new Point(790, 179);
            btnTeacherBoard.Name = "btnTeacherBoard";
            btnTeacherBoard.Size = new Size(348, 129);
            btnTeacherBoard.TabIndex = 7;
            btnTeacherBoard.Text = "Teacher DashBoard";
            btnTeacherBoard.UseVisualStyleBackColor = false;
            btnTeacherBoard.Click += btnTeacherBoard_Click;
            // 
            // stdBoard
            // 
            stdBoard.BackColor = Color.Black;
            stdBoard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdBoard.ForeColor = Color.Blue;
            stdBoard.Location = new Point(790, 30);
            stdBoard.Name = "stdBoard";
            stdBoard.Size = new Size(348, 129);
            stdBoard.TabIndex = 6;
            stdBoard.Text = "Student DashBoard";
            stdBoard.UseVisualStyleBackColor = false;
            stdBoard.Click += stdBoard_Click;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(114, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1155, 88);
            pnLogo.TabIndex = 7;
            pnLogo.Paint += panel2_Paint;
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
            lbLogo.Click += label1_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(636, 103);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(141, 32);
            lblMain.TabIndex = 8;
            lblMain.Text = "Main Panel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1357, 648);
            Controls.Add(lblMain);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Name = "Form1";
            Load += Form1_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

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
        private Label lblMain;
    }
}
