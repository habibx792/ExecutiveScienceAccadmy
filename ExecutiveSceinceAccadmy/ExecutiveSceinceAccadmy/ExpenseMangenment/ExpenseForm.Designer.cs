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
            pnMain.Location = new Point(24, 115);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(718, 318);
            pnMain.TabIndex = 28;
            // 
            // btnAdd
            // 
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
            bntReport.Location = new Point(395, 43);
            bntReport.Margin = new Padding(4, 5, 4, 5);
            bntReport.Name = "bntReport";
            bntReport.Size = new Size(305, 75);
            bntReport.TabIndex = 25;
            bntReport.Text = "Expense Report";
            bntReport.UseVisualStyleBackColor = true;
            // 
            // btnYear
            // 
            btnYear.Location = new Point(395, 153);
            btnYear.Margin = new Padding(4, 5, 4, 5);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(305, 76);
            btnYear.TabIndex = 21;
            btnYear.Text = "Current Year Expense";
            btnYear.UseVisualStyleBackColor = true;
            // 
            // btnCurrMonth
            // 
            btnCurrMonth.Location = new Point(26, 153);
            btnCurrMonth.Margin = new Padding(4, 5, 4, 5);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(284, 76);
            btnCurrMonth.TabIndex = 20;
            btnCurrMonth.Text = "Current Month Expense";
            btnCurrMonth.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(24, 27);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(718, 78);
            pnLogo.TabIndex = 27;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(26, 16);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Button btnYear;
        private Button btnCurrMonth;
        private Panel pnLogo;
        private Label lbLogo;
    }
}