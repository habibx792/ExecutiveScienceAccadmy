namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class teacherDashBoard
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
            panel2 = new Panel();
            btnTeacherAttendRep = new Button();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            btnRegisMange = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnTeacherAttendRep);
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Location = new Point(23, 97);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 345);
            panel2.TabIndex = 17;
            // 
            // btnTeacherAttendRep
            // 
            btnTeacherAttendRep.BackColor = SystemColors.Highlight;
            btnTeacherAttendRep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherAttendRep.ForeColor = Color.White;
            btnTeacherAttendRep.Location = new Point(144, 265);
            btnTeacherAttendRep.Name = "btnTeacherAttendRep";
            btnTeacherAttendRep.Size = new Size(225, 65);
            btnTeacherAttendRep.TabIndex = 26;
            btnTeacherAttendRep.Text = "Teacher Attendce Report";
            btnTeacherAttendRep.UseVisualStyleBackColor = false;
            btnTeacherAttendRep.Click += btnTeacherAttendRep_Click;
            // 
            // btnFeeMange
            // 
            btnFeeMange.BackColor = SystemColors.Highlight;
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.ForeColor = Color.White;
            btnFeeMange.Location = new Point(144, 122);
            btnFeeMange.Margin = new Padding(2);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(225, 60);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "View Fee/Salary Collection";
            btnFeeMange.UseVisualStyleBackColor = false;
            // 
            // btnAttendMange
            // 
            btnAttendMange.BackColor = SystemColors.Highlight;
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.ForeColor = Color.White;
            btnAttendMange.Location = new Point(144, 45);
            btnAttendMange.Margin = new Padding(2);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(225, 60);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Mark Attendance";
            btnAttendMange.UseVisualStyleBackColor = false;
            btnAttendMange.Click += btnAttendMange_Click;
            // 
            // btnRegisMange
            // 
            btnRegisMange.BackColor = SystemColors.Highlight;
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.ForeColor = Color.White;
            btnRegisMange.Location = new Point(144, 200);
            btnRegisMange.Margin = new Padding(2);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(225, 60);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "View Subject Collection";
            btnRegisMange.UseVisualStyleBackColor = false;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(23, 17);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(506, 80);
            pnLogo.TabIndex = 18;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(26, 25);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teacherDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(551, 469);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "teacherDashBoard";
            Text = "teacherDashBoard";
            Load += teacherDashBoard_Load;
            panel2.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Button btnRegisMange;
        private Panel pnLogo;
        private Label lbLogo;
        private Button btnTeacherAttendRep;
    }
}