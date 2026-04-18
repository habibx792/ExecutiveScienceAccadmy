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
            pnLogo = new Panel();
            lbLogo = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisMange
            // 
            btnRegisMange.BackColor = SystemColors.Highlight;
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(335, 166);
            btnRegisMange.Margin = new Padding(2);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(225, 60);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "Registration Mangement";
            btnRegisMange.UseVisualStyleBackColor = false;
            btnRegisMange.Click += button2_Click;
            // 
            // btnTeachMang
            // 
            btnTeachMang.BackColor = SystemColors.HotTrack;
            btnTeachMang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTeachMang.Location = new Point(86, 166);
            btnTeachMang.Margin = new Padding(2);
            btnTeachMang.Name = "btnTeachMang";
            btnTeachMang.Size = new Size(225, 60);
            btnTeachMang.TabIndex = 2;
            btnTeachMang.Text = "Teacher Manangement";
            btnTeachMang.UseVisualStyleBackColor = false;
            btnTeachMang.Click += button3_Click;
            // 
            // btnExpenseMange
            // 
            btnExpenseMange.BackColor = SystemColors.Highlight;
            btnExpenseMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnExpenseMange.Location = new Point(86, 96);
            btnExpenseMange.Margin = new Padding(2);
            btnExpenseMange.Name = "btnExpenseMange";
            btnExpenseMange.Size = new Size(225, 60);
            btnExpenseMange.TabIndex = 3;
            btnExpenseMange.Text = "Expense Mangement";
            btnExpenseMange.UseVisualStyleBackColor = false;
            btnExpenseMange.Click += button4_Click;
            // 
            // btnFeeMange
            // 
            btnFeeMange.BackColor = SystemColors.Highlight;
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(86, 20);
            btnFeeMange.Margin = new Padding(2);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(225, 60);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "Fee Management";
            btnFeeMange.UseVisualStyleBackColor = false;
            btnFeeMange.Click += button12_Click;
            // 
            // btnAttendMange
            // 
            btnAttendMange.BackColor = SystemColors.Highlight;
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(332, 20);
            btnAttendMange.Margin = new Padding(2);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(225, 60);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Attendance Magangement";
            btnAttendMange.UseVisualStyleBackColor = false;
            btnAttendMange.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnExpenseMange);
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Controls.Add(btnTeachMang);
            panel2.Location = new Point(17, 94);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 318);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(17, 17);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(622, 80);
            pnLogo.TabIndex = 17;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(86, 33);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(86, 245);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(225, 60);
            button1.TabIndex = 13;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = false;
            // 
            // adminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(662, 428);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
            Margin = new Padding(2);
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
        private Button button1;
    }
}