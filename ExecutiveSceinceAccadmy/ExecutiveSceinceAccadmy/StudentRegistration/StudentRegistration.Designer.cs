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
            btnSupReg.Location = new Point(573, 238);
            btnSupReg.Name = "btnSupReg";
            btnSupReg.Size = new Size(348, 129);
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
            btnStdReg.Location = new Point(97, 68);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(349, 129);
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
            BtnFeeSub.Location = new Point(573, 68);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(340, 129);
            BtnFeeSub.TabIndex = 8;
            BtnFeeSub.Text = "RTS Student";
            BtnFeeSub.UseVisualStyleBackColor = false;
            BtnFeeSub.Click += BtnFeeSub_Click;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(81, 49);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1178, 88);
            pnLogo.TabIndex = 10;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(377, 24);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // btnPrimaryReg
            // 
            btnPrimaryReg.BackColor = Color.Black;
            btnPrimaryReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimaryReg.ForeColor = Color.Blue;
            btnPrimaryReg.Location = new Point(106, 247);
            btnPrimaryReg.Name = "btnPrimaryReg";
            btnPrimaryReg.Size = new Size(340, 129);
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
            pnMain.Location = new Point(81, 143);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1178, 482);
            pnMain.TabIndex = 14;
            pnMain.Paint += panel1_Paint;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1318, 637);
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
        private Label lbLogo;
        private Button btnPrimaryReg;
        private Panel pnMain;
    }
}
