namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class FeeForm
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
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain = new Panel();
            lblYear = new Label();
            lblMonth = new Label();
            label4 = new Label();
            lblDay = new Label();
            label5 = new Label();
            label1 = new Label();
            btnSearchFee = new Button();
            btnDefault = new Button();
            btnRegularFee = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(70, 54);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(737, 71);
            pnLogo.TabIndex = 9;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(44, 9);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += lbLogo_Click;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(lblYear);
            pnMain.Controls.Add(lblMonth);
            pnMain.Controls.Add(label4);
            pnMain.Controls.Add(lblDay);
            pnMain.Controls.Add(label5);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(btnSearchFee);
            pnMain.Controls.Add(btnDefault);
            pnMain.Controls.Add(btnRegularFee);
            pnMain.Location = new Point(70, 135);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(737, 583);
            pnMain.TabIndex = 10;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(519, 190);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(43, 23);
            lblYear.TabIndex = 23;
            lblYear.Text = "0 RS";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.White;
            lblMonth.Location = new Point(519, 151);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(61, 31);
            lblMonth.TabIndex = 22;
            lblMonth.Text = "0 RS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(168, 151);
            label4.Name = "label4";
            label4.Size = new Size(232, 28);
            label4.TabIndex = 21;
            label4.Text = "Total Collection Of Day";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(519, 88);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(61, 31);
            lblDay.TabIndex = 20;
            lblDay.Text = "0 RS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(168, 88);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 19;
            label5.Text = "Total Collection Of Day";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 41);
            label1.TabIndex = 17;
            label1.Text = "Fee Mamgement";
            // 
            // btnSearchFee
            // 
            btnSearchFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchFee.Location = new Point(223, 325);
            btnSearchFee.Margin = new Padding(4, 5, 4, 5);
            btnSearchFee.Name = "btnSearchFee";
            btnSearchFee.Size = new Size(320, 86);
            btnSearchFee.TabIndex = 16;
            btnSearchFee.Text = "Search Fee Recored";
            btnSearchFee.UseVisualStyleBackColor = true;
            btnSearchFee.Click += btnSearchFee_Click;
            // 
            // btnDefault
            // 
            btnDefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDefault.Location = new Point(223, 421);
            btnDefault.Margin = new Padding(4, 5, 4, 5);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(320, 78);
            btnDefault.TabIndex = 14;
            btnDefault.Text = "Defualter Student";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // btnRegularFee
            // 
            btnRegularFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegularFee.Location = new Point(223, 233);
            btnRegularFee.Margin = new Padding(4, 5, 4, 5);
            btnRegularFee.Name = "btnRegularFee";
            btnRegularFee.Size = new Size(320, 82);
            btnRegularFee.TabIndex = 11;
            btnRegularFee.Text = "Submit Fee";
            btnRegularFee.UseVisualStyleBackColor = true;
            btnRegularFee.Click += btnRegularFee_Click;
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(850, 765);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FeeForm";
            Text = "FeeForm";
            Load += FeeForm_Load;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogo;
        private Label lbLogo;
        private Panel pnMain;
        private Button btnDefault;
        private Button btnRegularFee;
        private Label label1;
        private Button btnSearchFee;
        private Label lblMonth;
        private Label label4;
        private Label lblDay;
        private Label label5;
        private Label lblYear;
    }
}