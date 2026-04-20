namespace ExecutiveSceinceAccadmy.ReportManagement
{
    partial class ReportForm
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
            btnSalary = new Button();
            btnMonth = new Button();
            btnCurrMon = new Button();
            btnAddExp = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnSalary);
            pnMain.Controls.Add(btnMonth);
            pnMain.Controls.Add(btnCurrMon);
            pnMain.Controls.Add(btnAddExp);
            pnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnMain.Location = new Point(26, 102);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(596, 254);
            pnMain.TabIndex = 28;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = SystemColors.Highlight;
            btnSalary.ForeColor = Color.White;
            btnSalary.Location = new Point(325, 132);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(229, 65);
            btnSalary.TabIndex = 28;
            btnSalary.Text = "Teach Salary Reports";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = SystemColors.Highlight;
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(54, 132);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(229, 65);
            btnMonth.TabIndex = 27;
            btnMonth.Text = "Current Month Report";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += button1_Click;
            // 
            // btnCurrMon
            // 
            btnCurrMon.BackColor = SystemColors.Highlight;
            btnCurrMon.ForeColor = Color.White;
            btnCurrMon.Location = new Point(325, 25);
            btnCurrMon.Name = "btnCurrMon";
            btnCurrMon.Size = new Size(229, 68);
            btnCurrMon.TabIndex = 26;
            btnCurrMon.Text = "Expense Report";
            btnCurrMon.UseVisualStyleBackColor = false;
            btnCurrMon.Click += btnCurrMon_Click;
            // 
            // btnAddExp
            // 
            btnAddExp.BackColor = SystemColors.Highlight;
            btnAddExp.ForeColor = Color.White;
            btnAddExp.Location = new Point(54, 25);
            btnAddExp.Name = "btnAddExp";
            btnAddExp.Size = new Size(229, 68);
            btnAddExp.TabIndex = 24;
            btnAddExp.Text = "Fee Reports";
            btnAddExp.UseVisualStyleBackColor = false;
            btnAddExp.Click += btnAddExp_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(26, 16);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(596, 88);
            pnLogo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 70, 140);
            label6.Location = new Point(89, 26);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 31;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(647, 370);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(2);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button btnAddExp;
        private Button btnRts;
        private Button btnUpAtt;
        private Button btnDashBoad;
        private Panel pnLogo;
        private Button btnCurrMon;
        private Label label6;
        private Button btnSalary;
        private Button btnMonth;
    }
}