namespace ExecutiveSceinceAccadmy.studentRegistrationForms
{
    partial class StudentRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSupReg = new Button();
            btnStdReg = new Button();
            BtnFeeSub = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            btnPrimaryReg = new Button();
            pnMain = new Panel();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSupReg
            // 
            btnSupReg.BackColor = SystemColors.Highlight;
            btnSupReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSupReg.ForeColor = SystemColors.HighlightText;
            btnSupReg.Location = new Point(324, 152);
            btnSupReg.Name = "btnSupReg";
            btnSupReg.Size = new Size(212, 67);
            btnSupReg.TabIndex = 9;
            btnSupReg.Text = "Supplementary";
            btnSupReg.UseVisualStyleBackColor = false;
            btnSupReg.Click += stdBoard_Click;
            // 
            // btnStdReg
            // 
            btnStdReg.BackColor = SystemColors.Highlight;
            btnStdReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdReg.ForeColor = SystemColors.HighlightText;
            btnStdReg.Location = new Point(62, 49);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(219, 71);
            btnStdReg.TabIndex = 7;
            btnStdReg.Text = "Regular Student ";
            btnStdReg.UseVisualStyleBackColor = false;
            btnStdReg.Click += btnStdReg_Click;
            // 
            // BtnFeeSub
            // 
            BtnFeeSub.BackColor = SystemColors.Highlight;
            BtnFeeSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnFeeSub.ForeColor = SystemColors.HighlightText;
            BtnFeeSub.Location = new Point(324, 49);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(212, 71);
            BtnFeeSub.TabIndex = 8;
            BtnFeeSub.Text = "RTS Student";
            BtnFeeSub.UseVisualStyleBackColor = false;
            BtnFeeSub.Click += BtnFeeSub_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(27, 19);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(621, 67);
            pnLogo.TabIndex = 10;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 70, 140);
            label6.Location = new Point(95, 19);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 30;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrimaryReg
            // 
            btnPrimaryReg.BackColor = SystemColors.Highlight;
            btnPrimaryReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimaryReg.ForeColor = SystemColors.HighlightText;
            btnPrimaryReg.Location = new Point(62, 152);
            btnPrimaryReg.Name = "btnPrimaryReg";
            btnPrimaryReg.Size = new Size(211, 67);
            btnPrimaryReg.TabIndex = 13;
            btnPrimaryReg.Text = "Primary Student";
            btnPrimaryReg.UseVisualStyleBackColor = false;
            btnPrimaryReg.Click += button3_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(BtnFeeSub);
            pnMain.Controls.Add(btnPrimaryReg);
            pnMain.Controls.Add(btnStdReg);
            pnMain.Controls.Add(btnSupReg);
            pnMain.Location = new Point(27, 86);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(621, 249);
            pnMain.TabIndex = 14;
            pnMain.Paint += panel1_Paint;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(684, 363);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Name = "StudentRegistration";
            Text = "stdRegForm";
            Load += StudentRegistration_Load_1;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button btnSupReg;
        private Button btnStdReg;
        private Button BtnFeeSub;
        private Panel pnLogo;
        private Button btnPrimaryReg;
        private Panel pnMain;
        private Label label6;
    }
}
