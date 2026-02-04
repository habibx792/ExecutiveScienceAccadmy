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
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(label2);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(txtPass);
            pnMain.Controls.Add(txtUser);
            pnMain.Location = new Point(453, 254);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(437, 279);
            pnMain.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(264, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 48);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 109);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 12;
            label2.Text = "Password ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 61);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "User Name";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(175, 101);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(222, 23);
            txtPass.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(175, 53);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(222, 23);
            txtUser.TabIndex = 9;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(187, 41);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1155, 88);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(397, 23);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 729);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Name = "LoginForm";
            Text = "LoginForm";
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