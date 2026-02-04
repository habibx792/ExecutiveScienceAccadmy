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
            btnYear = new Button();
            btnCurrMonth = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnAdd);
            pnMain.Controls.Add(bntReport);
            pnMain.Controls.Add(btnYear);
            pnMain.Controls.Add(btnCurrMonth);
            pnMain.Location = new Point(406, 205);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(642, 391);
            pnMain.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(221, 130);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "add Expense";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // bntReport
            // 
            bntReport.Location = new Point(362, 21);
            bntReport.Name = "bntReport";
            bntReport.Size = new Size(237, 130);
            bntReport.TabIndex = 25;
            bntReport.Text = "Expense Report";
            bntReport.UseVisualStyleBackColor = true;
            // 
            // btnYear
            // 
            btnYear.Location = new Point(362, 212);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(237, 130);
            btnYear.TabIndex = 21;
            btnYear.Text = "Current Year Expense";
            btnYear.UseVisualStyleBackColor = true;
            // 
            // btnCurrMonth
            // 
            btnCurrMonth.Location = new Point(60, 212);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(221, 130);
            btnCurrMonth.TabIndex = 20;
            btnCurrMonth.Text = "Current Month Expense";
            btnCurrMonth.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(136, 33);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1178, 88);
            pnLogo.TabIndex = 27;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(356, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 617);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(2);
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
        private Button btnYear;
        private Button btnCurrMonth;
        private Panel pnLogo;
        private Label lbLogo;
    }
}