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
            pnLogo = new Panel();
            label6 = new Label();
            label2 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(label2);
            pnMain.Controls.Add(lblYear);
            pnMain.Controls.Add(lblMonth);
            pnMain.Controls.Add(label4);
            pnMain.Controls.Add(lblDay);
            pnMain.Controls.Add(label5);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(btnSearchFee);
            pnMain.Controls.Add(btnDefault);
            pnMain.Controls.Add(btnRegularFee);
            pnMain.Location = new Point(42, 76);
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
            lblMonth.Location = new Point(519, 137);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(61, 31);
            lblMonth.TabIndex = 22;
            lblMonth.Text = "0 RS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(178, 139);
            label4.Name = "label4";
            label4.Size = new Size(258, 28);
            label4.TabIndex = 21;
            label4.Text = "Total Collection Of Month";
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
            label5.Location = new Point(188, 88);
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
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(42, 14);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(737, 71);
            pnLogo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(102, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(537, 54);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 185);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 24;
            label2.Text = "Total Collection Of Year";
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(811, 684);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FeeForm";
            Text = "FeeForm";
            Load += FeeForm_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Panel pnLogo;
        private Label label6;
        private Label label2;
    }
}