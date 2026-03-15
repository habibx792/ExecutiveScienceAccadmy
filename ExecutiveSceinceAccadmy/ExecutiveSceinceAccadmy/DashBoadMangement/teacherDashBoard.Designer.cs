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
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Location = new Point(29, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 439);
            panel2.TabIndex = 17;
            // 
            // btnFeeMange
            // 
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(217, 163);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(289, 92);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "View Fee/Salary Collection";
            btnFeeMange.UseVisualStyleBackColor = true;
            // 
            // btnAttendMange
            // 
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(217, 45);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(289, 92);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Mark Attendance";
            btnAttendMange.UseVisualStyleBackColor = true;
            btnAttendMange.Click += btnAttendMange_Click;
            // 
            // btnRegisMange
            // 
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(217, 282);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(289, 92);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "View Subject Collection";
            btnRegisMange.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(29, 26);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(650, 123);
            pnLogo.TabIndex = 18;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(34, 39);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(537, 54);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teacherDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(708, 604);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
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
    }
}