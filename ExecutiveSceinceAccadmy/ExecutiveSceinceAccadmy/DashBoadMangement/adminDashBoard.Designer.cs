namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class adminDashBoard
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
            btnRegisMange = new Button();
            btnTeachMang = new Button();
            btnExpenseMange = new Button();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnReports = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisMange
            // 
            btnRegisMange.BackColor = SystemColors.Highlight;
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.ForeColor = Color.White;
            btnRegisMange.Location = new Point(474, 160);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(364, 100);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "Registration Mangement";
            btnRegisMange.UseVisualStyleBackColor = false;
            btnRegisMange.Click += button2_Click;
            // 
            // btnTeachMang
            // 
            btnTeachMang.BackColor = SystemColors.HotTrack;
            btnTeachMang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTeachMang.ForeColor = Color.White;
            btnTeachMang.Location = new Point(81, 277);
            btnTeachMang.Name = "btnTeachMang";
            btnTeachMang.Size = new Size(363, 100);
            btnTeachMang.TabIndex = 2;
            btnTeachMang.Text = "Teacher Manangement";
            btnTeachMang.UseVisualStyleBackColor = false;
            btnTeachMang.Click += button3_Click;
            // 
            // btnExpenseMange
            // 
            btnExpenseMange.BackColor = SystemColors.Highlight;
            btnExpenseMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnExpenseMange.ForeColor = Color.White;
            btnExpenseMange.Location = new Point(81, 160);
            btnExpenseMange.Name = "btnExpenseMange";
            btnExpenseMange.Size = new Size(363, 100);
            btnExpenseMange.TabIndex = 3;
            btnExpenseMange.Text = "Expense Mangement";
            btnExpenseMange.UseVisualStyleBackColor = false;
            btnExpenseMange.Click += button4_Click;
            // 
            // btnFeeMange
            // 
            btnFeeMange.BackColor = SystemColors.Highlight;
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.ForeColor = Color.White;
            btnFeeMange.Location = new Point(81, 33);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(363, 100);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "Fee Management";
            btnFeeMange.UseVisualStyleBackColor = false;
            btnFeeMange.Click += button12_Click;
            // 
            // btnAttendMange
            // 
            btnAttendMange.BackColor = SystemColors.Highlight;
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.ForeColor = Color.White;
            btnAttendMange.Location = new Point(474, 33);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(364, 100);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Attendance Magangement";
            btnAttendMange.UseVisualStyleBackColor = false;
            btnAttendMange.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnExpenseMange);
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Controls.Add(btnTeachMang);
            panel2.Location = new Point(24, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 530);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(81, 401);
            button1.Name = "button1";
            button1.Size = new Size(363, 100);
            button1.TabIndex = 14;
            button1.Text = "Change Student Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Highlight;
            btnReports.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(474, 277);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(364, 100);
            btnReports.TabIndex = 13;
            btnReports.Text = "Magange Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(24, 28);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(889, 133);
            pnLogo.TabIndex = 17;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(126, 25);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(646, 65);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            lbLogo.Click += lbLogo_Click;
            // 
            // adminDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(946, 713);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
            Name = "adminDashBoard";
            Text = "adminDashBoard";
            Load += adminDashBoard_Load;
            panel2.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisMange;
        private Button btnTeachMang;
        private Button btnExpenseMange;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Panel panel2;
        private Panel pnLogo;
        private Label lbLogo;
        private Button btnReports;
        private Button button1;
    }
}