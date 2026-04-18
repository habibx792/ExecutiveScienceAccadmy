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
            btnFeeSet = new Button();
            label2 = new Label();
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
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnFeeSet);
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
            pnMain.Location = new Point(33, 61);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(573, 423);
            pnMain.TabIndex = 10;
            // 
            // btnFeeSet
            // 
            btnFeeSet.BackColor = SystemColors.Highlight;
            btnFeeSet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeSet.ForeColor = Color.White;
            btnFeeSet.Location = new Point(159, 356);
            btnFeeSet.Margin = new Padding(2);
            btnFeeSet.Name = "btnFeeSet";
            btnFeeSet.Size = new Size(249, 60);
            btnFeeSet.TabIndex = 25;
            btnFeeSet.Text = "Set Fee ";
            btnFeeSet.UseVisualStyleBackColor = false;
            btnFeeSet.Click += btnFeeSet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 24;
            label2.Text = "Total Collection Of Year";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(390, 147);
            lblYear.Margin = new Padding(2, 0, 2, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 23;
            lblYear.Text = "0 RS";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.White;
            lblMonth.Location = new Point(390, 112);
            lblMonth.Margin = new Padding(2, 0, 2, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(51, 25);
            lblMonth.TabIndex = 22;
            lblMonth.Text = "0 RS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 114);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 21;
            label4.Text = "Total Collection Of Month";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(390, 80);
            lblDay.Margin = new Padding(2, 0, 2, 0);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(51, 25);
            lblDay.TabIndex = 20;
            lblDay.Text = "0 RS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 21);
            label5.TabIndex = 19;
            label5.Text = "Total Collection Of Day";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 70, 140);
            label1.Location = new Point(186, 26);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 17;
            label1.Text = "Fee Mamgement";
            // 
            // btnSearchFee
            // 
            btnSearchFee.BackColor = SystemColors.Highlight;
            btnSearchFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchFee.ForeColor = Color.White;
            btnSearchFee.Location = new Point(159, 238);
            btnSearchFee.Name = "btnSearchFee";
            btnSearchFee.Size = new Size(249, 56);
            btnSearchFee.TabIndex = 16;
            btnSearchFee.Text = "Search Fee Recored";
            btnSearchFee.UseVisualStyleBackColor = false;
            btnSearchFee.Click += btnSearchFee_Click;
            // 
            // btnDefault
            // 
            btnDefault.BackColor = SystemColors.Highlight;
            btnDefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDefault.ForeColor = Color.White;
            btnDefault.Location = new Point(159, 300);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(249, 51);
            btnDefault.TabIndex = 14;
            btnDefault.Text = "Defualter Student";
            btnDefault.UseVisualStyleBackColor = false;
            btnDefault.Click += btnDefault_Click;
            // 
            // btnRegularFee
            // 
            btnRegularFee.BackColor = SystemColors.Highlight;
            btnRegularFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegularFee.ForeColor = Color.White;
            btnRegularFee.Location = new Point(159, 178);
            btnRegularFee.Name = "btnRegularFee";
            btnRegularFee.Size = new Size(249, 53);
            btnRegularFee.TabIndex = 11;
            btnRegularFee.Text = "Submit Fee";
            btnRegularFee.UseVisualStyleBackColor = false;
            btnRegularFee.Click += btnRegularFee_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(33, 9);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(573, 56);
            pnLogo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 70, 140);
            label6.Location = new Point(79, 5);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(631, 529);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
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
        private Button btnFeeSet;
    }
}