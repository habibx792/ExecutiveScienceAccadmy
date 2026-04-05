namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    partial class ExpenseForm
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
            btnAdd = new Button();
            bntReport = new Button();
            btnCurrMonth = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnAdd);
            pnMain.Controls.Add(bntReport);
            pnMain.Controls.Add(btnCurrMonth);
            pnMain.Location = new Point(19, 75);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(558, 207);
            pnMain.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(20, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(221, 49);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "add Expense";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // bntReport
            // 
            bntReport.BackColor = SystemColors.Highlight;
            bntReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntReport.Location = new Point(307, 28);
            bntReport.Name = "bntReport";
            bntReport.Size = new Size(237, 49);
            bntReport.TabIndex = 25;
            bntReport.Text = "Expense Report";
            bntReport.UseVisualStyleBackColor = false;
            bntReport.Click += bntReport_Click;
            // 
            // btnCurrMonth
            // 
            btnCurrMonth.BackColor = SystemColors.Highlight;
            btnCurrMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCurrMonth.Location = new Point(20, 100);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(221, 50);
            btnCurrMonth.TabIndex = 20;
            btnCurrMonth.Text = "Check Expenses";
            btnCurrMonth.UseVisualStyleBackColor = false;
            btnCurrMonth.Click += btnCurrMonth_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(19, 29);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(558, 51);
            pnLogo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(71, 8);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(600, 318);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ExpenseForm";
            Text = "ExpenseForm";
            Load += ExpenseForm_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button btnAdd;
        private Button bntReport;
        private Button btnCurrMonth;
        private Panel pnLogo;
        private Label label6;
    }
}