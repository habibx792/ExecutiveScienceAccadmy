namespace ExecutiveSceinceAccadmy
{
    partial class LoginForm
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
            pnMain = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(label2);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(txtPass);
            pnMain.Controls.Add(txtUser);
            pnMain.Location = new Point(450, 200);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(400, 300);
            pnMain.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 12;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(50, 145);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Enter Password";
            txtPass.Size = new Size(300, 27);
            txtPass.TabIndex = 10;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Location = new Point(50, 75);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Enter UserName";
            txtUser.Size = new Size(300, 27);
            txtUser.TabIndex = 9;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(12, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1281, 80);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(400, 20);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnMain;
        private TextBox txtUser;
        private Panel pnLogo;
        private Label lbLogo;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private Button btnLogin;
    }
}