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
            btnFeeSet = new Button();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            panel2 = new Panel();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisMange
            // 
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(660, 31);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(289, 92);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "Registration Mangement";
            btnRegisMange.UseVisualStyleBackColor = true;
            btnRegisMange.Click += button2_Click;
            // 
            // btnTeachMang
            // 
            btnTeachMang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTeachMang.Location = new Point(660, 147);
            btnTeachMang.Name = "btnTeachMang";
            btnTeachMang.Size = new Size(289, 92);
            btnTeachMang.TabIndex = 2;
            btnTeachMang.Text = "Teacher Manangement";
            btnTeachMang.UseVisualStyleBackColor = true;
            btnTeachMang.Click += button3_Click;
            // 
            // btnExpenseMange
            // 
            btnExpenseMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnExpenseMange.Location = new Point(24, 147);
            btnExpenseMange.Name = "btnExpenseMange";
            btnExpenseMange.Size = new Size(289, 92);
            btnExpenseMange.TabIndex = 3;
            btnExpenseMange.Text = "Expense Mangement";
            btnExpenseMange.UseVisualStyleBackColor = true;
            btnExpenseMange.Click += button4_Click;
            // 
            // btnFeeSet
            // 
            btnFeeSet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeSet.Location = new Point(344, 147);
            btnFeeSet.Name = "btnFeeSet";
            btnFeeSet.Size = new Size(289, 92);
            btnFeeSet.TabIndex = 11;
            btnFeeSet.Text = "Set Fee ";
            btnFeeSet.UseVisualStyleBackColor = true;
            btnFeeSet.Click += button11_Click;
            // 
            // btnFeeMange
            // 
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(24, 31);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(289, 92);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "Fee Management";
            btnFeeMange.UseVisualStyleBackColor = true;
            btnFeeMange.Click += button12_Click;
            // 
            // btnAttendMange
            // 
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(340, 31);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(289, 92);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Attendance Magangement";
            btnAttendMange.UseVisualStyleBackColor = true;
            btnAttendMange.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnExpenseMange);
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Controls.Add(btnTeachMang);
            panel2.Controls.Add(btnFeeSet);
            panel2.Location = new Point(8, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 409);
            panel2.TabIndex = 16;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(8, 27);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(964, 123);
            pnLogo.TabIndex = 17;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(216, 35);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(537, 54);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(984, 610);
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
        private Button btnFeeSet;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Panel panel2;
        private Panel pnLogo;
        private Label lbLogo;
    }
}