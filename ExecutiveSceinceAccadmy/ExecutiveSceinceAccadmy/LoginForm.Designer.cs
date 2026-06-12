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
            chkShow = new CheckBox();
            rdStudent = new RadioButton();
            rdTeacher = new RadioButton();
            rdAdmin = new RadioButton();
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
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(chkShow);
            pnMain.Controls.Add(rdStudent);
            pnMain.Controls.Add(rdTeacher);
            pnMain.Controls.Add(rdAdmin);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(label2);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(txtPass);
            pnMain.Controls.Add(txtUser);
            pnMain.Location = new Point(32, 95);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(498, 305);
            pnMain.TabIndex = 0;
            pnMain.Paint += pnMain_Paint;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(100, 172);
            chkShow.Margin = new Padding(2, 2, 2, 2);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(108, 19);
            chkShow.TabIndex = 9;
            chkShow.Text = "Show Password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // rdStudent
            // 
            rdStudent.AutoSize = true;
            rdStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdStudent.Location = new Point(330, 31);
            rdStudent.Margin = new Padding(2, 2, 2, 2);
            rdStudent.Name = "rdStudent";
            rdStudent.Size = new Size(88, 25);
            rdStudent.TabIndex = 15;
            rdStudent.TabStop = true;
            rdStudent.Text = "Student";
            rdStudent.UseVisualStyleBackColor = true;
            rdStudent.CheckedChanged += rdStudent_CheckedChanged;
            // 
            // rdTeacher
            // 
            rdTeacher.AutoSize = true;
            rdTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdTeacher.Location = new Point(215, 31);
            rdTeacher.Margin = new Padding(2, 2, 2, 2);
            rdTeacher.Name = "rdTeacher";
            rdTeacher.Size = new Size(87, 25);
            rdTeacher.TabIndex = 14;
            rdTeacher.TabStop = true;
            rdTeacher.Text = "Teacher";
            rdTeacher.UseVisualStyleBackColor = true;
            rdTeacher.CheckedChanged += rdTeacher_CheckedChanged;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdAdmin.Location = new Point(105, 31);
            rdAdmin.Margin = new Padding(2, 2, 2, 2);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(79, 25);
            rdAdmin.TabIndex = 13;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "Admin";
            rdAdmin.UseVisualStyleBackColor = true;
            rdAdmin.CheckedChanged += rdAdmin_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 213);
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
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(100, 123);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(100, 63);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtPass.Location = new Point(100, 147);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Enter Password";
            txtPass.Size = new Size(300, 26);
            txtPass.TabIndex = 10;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtUser.Location = new Point(100, 93);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Enter UserName";
            txtUser.Size = new Size(300, 26);
            txtUser.TabIndex = 9;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(32, 17);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(498, 93);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(43, 18);
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
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(557, 423);
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
        private RadioButton rdStudent;
        private RadioButton rdTeacher;
        private RadioButton rdAdmin;
        private CheckBox chkShow;
    }
}