namespace ExecutiveSceinceAccadmy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStdReg = new Button();
            btnResult = new Button();
            btnAdmin = new Button();
            BtnAttend = new Button();
            btnExpense = new Button();
            BtnFeeSub = new Button();
            pnMagnt = new Panel();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMagnt.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnStdReg
            // 
            btnStdReg.BackColor = Color.Black;
            btnStdReg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdReg.ForeColor = Color.Blue;
            btnStdReg.Location = new Point(27, 43);
            btnStdReg.Name = "btnStdReg";
            btnStdReg.Size = new Size(349, 129);
            btnStdReg.TabIndex = 0;
            btnStdReg.Text = " Registration Mangement";
            btnStdReg.UseVisualStyleBackColor = false;
            btnStdReg.Click += btnStdReg_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Black;
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.Blue;
            btnResult.Location = new Point(27, 201);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(349, 129);
            btnResult.TabIndex = 1;
            btnResult.Text = "Result Mangement";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Black;
            btnAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Blue;
            btnAdmin.Location = new Point(790, 201);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(348, 129);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin DashBoad";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // BtnAttend
            // 
            BtnAttend.BackColor = Color.Black;
            BtnAttend.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAttend.ForeColor = Color.Blue;
            BtnAttend.Location = new Point(790, 43);
            BtnAttend.Name = "BtnAttend";
            BtnAttend.Size = new Size(348, 129);
            BtnAttend.TabIndex = 3;
            BtnAttend.Text = "Attendance Mangement";
            BtnAttend.UseVisualStyleBackColor = false;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.Black;
            btnExpense.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.Blue;
            btnExpense.Location = new Point(421, 201);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(340, 129);
            btnExpense.TabIndex = 4;
            btnExpense.Text = "Expense Mangement";
            btnExpense.UseVisualStyleBackColor = false;
            // 
            // BtnFeeSub
            // 
            BtnFeeSub.BackColor = Color.Black;
            BtnFeeSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFeeSub.ForeColor = Color.Blue;
            BtnFeeSub.Location = new Point(421, 43);
            BtnFeeSub.Name = "BtnFeeSub";
            BtnFeeSub.Size = new Size(340, 129);
            BtnFeeSub.TabIndex = 5;
            BtnFeeSub.Text = "Fee Management";
            BtnFeeSub.UseVisualStyleBackColor = false;
            // 
            // pnMagnt
            // 
            pnMagnt.Controls.Add(btnStdReg);
            pnMagnt.Controls.Add(BtnFeeSub);
            pnMagnt.Controls.Add(btnResult);
            pnMagnt.Controls.Add(btnExpense);
            pnMagnt.Controls.Add(btnAdmin);
            pnMagnt.Controls.Add(BtnAttend);
            pnMagnt.Location = new Point(114, 153);
            pnMagnt.Name = "pnMagnt";
            pnMagnt.Size = new Size(1155, 358);
            pnMagnt.TabIndex = 6;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(114, 59);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1155, 88);
            pnLogo.TabIndex = 7;
            pnLogo.Paint += panel2_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(340, 26);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(364, 25);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1357, 648);
            Controls.Add(pnLogo);
            Controls.Add(pnMagnt);
            Name = "Form1";
            Load += Form1_Load;
            pnMagnt.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStdReg;
        private Button btnResult;
        private Button btnAdmin;
        private Button BtnAttend;
        private Button btnExpense;
        private Button BtnFeeSub;
        private Panel pnMagnt;
        private Panel pnLogo;
        private Label lbLogo;
    }
}
