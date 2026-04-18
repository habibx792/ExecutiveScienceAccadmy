namespace ExecutiveSceinceAccadmy.TeacherMangement
{
    partial class TeacherMangementForm
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
            btnAttend = new Button();
            btnHiring = new Button();
            panel1 = new Panel();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel1.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnAttend
            // 
            btnAttend.BackColor = SystemColors.Highlight;
            btnAttend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttend.ForeColor = Color.White;
            btnAttend.Location = new Point(134, 18);
            btnAttend.Margin = new Padding(2);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(172, 70);
            btnAttend.TabIndex = 7;
            btnAttend.Text = "Teacher Attendance";
            btnAttend.UseVisualStyleBackColor = false;
            btnAttend.Click += btnAttend_Click;
            // 
            // btnHiring
            // 
            btnHiring.BackColor = SystemColors.Highlight;
            btnHiring.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHiring.ForeColor = Color.White;
            btnHiring.Location = new Point(134, 127);
            btnHiring.Margin = new Padding(2);
            btnHiring.Name = "btnHiring";
            btnHiring.Size = new Size(172, 70);
            btnHiring.TabIndex = 10;
            btnHiring.Text = "Hiring";
            btnHiring.UseVisualStyleBackColor = false;
            btnHiring.Click += btnHiring_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnHiring);
            panel1.Controls.Add(btnAttend);
            panel1.Location = new Point(9, 89);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 247);
            panel1.TabIndex = 15;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(9, 9);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(455, 80);
            pnLogo.TabIndex = 16;
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
            // TeacherMangementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(481, 361);
            Controls.Add(pnLogo);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "TeacherMangementForm";
            Text = "TeacherMangement";
            Load += TeacherMangement_Load;
            panel1.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAttend;
        private Button btnHiring;
        private Panel panel1;
        private Panel pnLogo;
        private Label lbLogo;
    }
}