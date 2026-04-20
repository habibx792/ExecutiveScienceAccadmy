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
            btnCurrMon = new Button();
            btnAddExp = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(button2);
            pnMain.Controls.Add(button1);
            pnMain.Controls.Add(btnCurrMon);
            pnMain.Controls.Add(btnAddExp);
            pnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnMain.Location = new Point(26, 102);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(596, 254);
            pnMain.TabIndex = 28;
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
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
            button1.Location = new Point(62, 132);
            button1.Name = "button1";
            button1.Size = new Size(221, 65);
            button1.TabIndex = 27;
            button1.Text = "Current Month Report";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = Color.White;
            button2.Location = new Point(325, 132);
            button2.Name = "button2";
            button2.Size = new Size(229, 65);
            button2.TabIndex = 28;
            button2.Text = "Teach Salary Reports";
            button2.UseVisualStyleBackColor = false;
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
        private Button button2;
        private Button button1;
    }
}