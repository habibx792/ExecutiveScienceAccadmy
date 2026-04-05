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
            btnAdmin = new Button();
            pnMain = new Panel();
            stdBoard = new Button();
            btnTeacherBoard = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.Highlight;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(127, 21);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(240, 100);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin Dashboard";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(255, 128, 128);
            pnMain.Controls.Add(stdBoard);
            pnMain.Controls.Add(btnTeacherBoard);
            pnMain.Controls.Add(btnAdmin);
            pnMain.Location = new Point(18, 77);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(513, 368);
            pnMain.TabIndex = 6;
            // 
            // stdBoard
            // 
            stdBoard.BackColor = SystemColors.Highlight;
            stdBoard.FlatAppearance.BorderSize = 0;
            stdBoard.FlatStyle = FlatStyle.Flat;
            stdBoard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            stdBoard.ForeColor = Color.White;
            stdBoard.Location = new Point(127, 134);
            stdBoard.Name = "stdBoard";
            stdBoard.Size = new Size(240, 100);
            stdBoard.TabIndex = 6;
            stdBoard.Text = "Student Dashboard";
            stdBoard.UseVisualStyleBackColor = false;
            stdBoard.Click += stdBoard_Click;
            // 
            // btnTeacherBoard
            // 
            btnTeacherBoard.BackColor = SystemColors.Highlight;
            btnTeacherBoard.FlatAppearance.BorderSize = 0;
            btnTeacherBoard.FlatStyle = FlatStyle.Flat;
            btnTeacherBoard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTeacherBoard.ForeColor = Color.White;
            btnTeacherBoard.Location = new Point(127, 246);
            btnTeacherBoard.Name = "btnTeacherBoard";
            btnTeacherBoard.Size = new Size(240, 100);
            btnTeacherBoard.TabIndex = 7;
            btnTeacherBoard.Text = "Teacher Dashboard";
            btnTeacherBoard.UseVisualStyleBackColor = false;
            btnTeacherBoard.Click += btnTeacherBoard_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(255, 128, 128);
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(18, 9);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(513, 73);
            pnLogo.TabIndex = 7;
            pnLogo.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(37, 14);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 31;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(548, 459);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Name = "Form1";
            Text = "Main Dashboard";
            Load += Form1_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }
        private Button btnAdmin;
        private Panel pnMain;
        private Panel pnLogo;
        private Button stdBoard;
        private Button btnTeacherBoard;
        private Label label6;
    }
}
