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
            pnMain.Location = new Point(24, 115);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(718, 318);
            pnMain.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(26, 43);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(284, 75);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "add Expense";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // bntReport
            // 
            bntReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntReport.Location = new Point(395, 43);
            bntReport.Margin = new Padding(4, 5, 4, 5);
            bntReport.Name = "bntReport";
            bntReport.Size = new Size(305, 75);
            bntReport.TabIndex = 25;
            bntReport.Text = "Expense Report";
            bntReport.UseVisualStyleBackColor = true;
            bntReport.Click += bntReport_Click;
            // 
            // btnCurrMonth
            // 
            btnCurrMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCurrMonth.Location = new Point(26, 153);
            btnCurrMonth.Margin = new Padding(4, 5, 4, 5);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(284, 76);
            btnCurrMonth.TabIndex = 20;
            btnCurrMonth.Text = "Check Expenses";
            btnCurrMonth.UseVisualStyleBackColor = true;
            btnCurrMonth.Click += btnCurrMonth_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(24, 44);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(718, 78);
            pnLogo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(91, 12);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(537, 54);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(771, 488);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
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