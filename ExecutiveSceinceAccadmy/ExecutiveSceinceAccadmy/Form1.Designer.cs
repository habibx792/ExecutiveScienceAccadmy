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
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(0, 120, 215);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(163, 32);
            btnAdmin.Margin = new Padding(4, 5, 4, 5);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(309, 153);
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
            pnMain.Location = new Point(42, 168);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(631, 565);
            pnMain.TabIndex = 6;
            // 
            // stdBoard
            // 
            stdBoard.BackColor = Color.FromArgb(0, 120, 215);
            stdBoard.FlatAppearance.BorderSize = 0;
            stdBoard.FlatStyle = FlatStyle.Flat;
            stdBoard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            stdBoard.ForeColor = Color.White;
            stdBoard.Location = new Point(163, 205);
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
            btnTeacherBoard.Location = new Point(163, 377);
            btnTeacherBoard.Margin = new Padding(4, 5, 4, 5);
            btnTeacherBoard.Name = "btnTeacherBoard";
            btnTeacherBoard.Size = new Size(309, 153);
            btnTeacherBoard.TabIndex = 7;
            btnTeacherBoard.Text = "Teacher Dashboard";
            btnTeacherBoard.UseVisualStyleBackColor = false;
            btnTeacherBoard.Click += btnTeacherBoard_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(255, 128, 128);
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(42, 64);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(631, 103);
            pnLogo.TabIndex = 7;
            pnLogo.Paint += panel2_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(38, 21);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(578, 41);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            lbLogo.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 802);
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
        private Button btnAdmin;
        private Panel pnMain;
        private Panel pnLogo;
        private Label lbLogo;
        private Button stdBoard;
        private Button btnTeacherBoard;
    }
}
