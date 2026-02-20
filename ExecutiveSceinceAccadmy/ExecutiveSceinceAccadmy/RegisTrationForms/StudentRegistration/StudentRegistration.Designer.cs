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
            lbLogo = new Label();
            btnPrimaryReg = new Button();
            pnMain = new Panel();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSupReg
            // 
            btnSupReg.BackColor = Color.Black;
            btnSupReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupReg.ForeColor = Color.Blue;
            btnSupReg.Location = new Point(737, 365);
            btnSupReg.Margin = new Padding(4, 5, 4, 5);
            btnSupReg.Name = "btnSupReg";
            btnSupReg.Size = new Size(447, 198);
            btnSupReg.TabIndex = 9;
            btnSupReg.Text = "Supplementary";
            btnSupReg.UseVisualStyleBackColor = false;
            btnSupReg.Click += stdBoard_Click;
            // 
            // btnStdReg
            // 
            btnStdReg.BackColor = Color.Black;
            btnStdReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdReg.ForeColor = Color.Blue;
            btnStdReg.Location = new Point(125, 104);
            btnStdReg.Margin = new Padding(4, 5, 4, 5);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(449, 198);
            btnStdReg.TabIndex = 7;
            btnStdReg.Text = "Regular Student ";
            btnStdReg.UseVisualStyleBackColor = false;
            btnStdReg.Click += btnStdReg_Click;
            // 
            // BtnFeeSub
            // 
            BtnFeeSub.BackColor = Color.Black;
            BtnFeeSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFeeSub.ForeColor = Color.Blue;
            BtnFeeSub.Location = new Point(737, 104);
            BtnFeeSub.Margin = new Padding(4, 5, 4, 5);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(437, 198);
            BtnFeeSub.TabIndex = 8;
            BtnFeeSub.Text = "RTS Student";
            BtnFeeSub.UseVisualStyleBackColor = false;
            BtnFeeSub.Click += BtnFeeSub_Click;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(104, 75);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1515, 135);
            pnLogo.TabIndex = 10;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(485, 37);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // btnPrimaryReg
            // 
            btnPrimaryReg.BackColor = Color.Black;
            btnPrimaryReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimaryReg.ForeColor = Color.Blue;
            btnPrimaryReg.Location = new Point(136, 379);
            btnPrimaryReg.Margin = new Padding(4, 5, 4, 5);
            btnPrimaryReg.Name = "btnPrimaryReg";
            btnPrimaryReg.Size = new Size(437, 198);
            btnPrimaryReg.TabIndex = 13;
            btnPrimaryReg.Text = "Primary Student Student";
            btnPrimaryReg.UseVisualStyleBackColor = false;
            btnPrimaryReg.Click += button3_Click;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(BtnFeeSub);
            pnMain.Controls.Add(btnPrimaryReg);
            pnMain.Controls.Add(btnStdReg);
            pnMain.Controls.Add(btnSupReg);
            pnMain.Location = new Point(104, 219);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1515, 739);
            pnMain.TabIndex = 14;
            pnMain.Paint += panel1_Paint;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1695, 977);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label lbLogo;
        private Button btnPrimaryReg;
        private Panel pnMain;
    }
}
