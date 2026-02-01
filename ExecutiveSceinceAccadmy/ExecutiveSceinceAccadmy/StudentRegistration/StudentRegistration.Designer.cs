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
            stdBoard = new Button();
            btnStdReg = new Button();
            BtnFeeSub = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            button3 = new Button();
            panel1 = new Panel();
            pnLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stdBoard
            // 
            stdBoard.BackColor = Color.Black;
            stdBoard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdBoard.ForeColor = Color.Blue;
            stdBoard.Location = new Point(573, 232);
            stdBoard.Name = "stdBoard";
            stdBoard.Size = new Size(348, 129);
            stdBoard.TabIndex = 9;
            stdBoard.Text = "Supplementary";
            stdBoard.UseVisualStyleBackColor = false;
            stdBoard.Click += stdBoard_Click;
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
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(106, 247);
            button3.Name = "button3";
            button3.Size = new Size(340, 129);
            button3.TabIndex = 13;
            button3.Text = "Primary Student Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnFeeSub);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnStdReg);
            panel1.Controls.Add(stdBoard);
            panel1.Location = new Point(81, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 482);
            panel1.TabIndex = 14;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1318, 637);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Name = "StudentRegistration";
            Text = "stdRegForm";
            Load += StudentRegistration_Load_1;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button stdBoard;
        private Button btnStdReg;
        private Button BtnFeeSub;
        private Panel pnLogo;
        private Label lbLogo;
        private Button button3;
        private Panel panel1;
    }
}
