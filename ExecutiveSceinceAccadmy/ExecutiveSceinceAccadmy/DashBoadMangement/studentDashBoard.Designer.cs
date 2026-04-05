namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class studentDashBoard
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
            picBox = new PictureBox();
            panel2 = new Panel();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            btnRegisMange = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.BackColor = SystemColors.ActiveCaption;
            picBox.Location = new Point(1219, 45);
            picBox.Name = "picBox";
            picBox.Size = new Size(127, 133);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Location = new Point(22, 83);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 278);
            panel2.TabIndex = 17;
            // 
            // btnFeeMange
            // 
            btnFeeMange.BackColor = SystemColors.Highlight;
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(120, 22);
            btnFeeMange.Margin = new Padding(2, 2, 2, 2);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(225, 60);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "Check Result";
            btnFeeMange.UseVisualStyleBackColor = false;
            // 
            // btnAttendMange
            // 
            btnAttendMange.BackColor = SystemColors.Highlight;
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(120, 192);
            btnAttendMange.Margin = new Padding(2, 2, 2, 2);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(225, 60);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Check Attendance";
            btnAttendMange.UseVisualStyleBackColor = false;
            btnAttendMange.Click += btnAttendMange_Click;
            // 
            // btnRegisMange
            // 
            btnRegisMange.BackColor = SystemColors.Highlight;
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(120, 107);
            btnRegisMange.Margin = new Padding(2, 2, 2, 2);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(225, 60);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "Check Fee Records";
            btnRegisMange.UseVisualStyleBackColor = false;
            btnRegisMange.Click += btnRegisMange_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(22, 9);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(474, 80);
            pnLogo.TabIndex = 19;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(26, 25);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(523, 375);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
            Controls.Add(picBox);
            Name = "studentDashBoard";
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            panel2.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picBox;
        private Panel panel2;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Button btnRegisMange;
        private Panel pnLogo;
        private Label lbLogo;
    }
}