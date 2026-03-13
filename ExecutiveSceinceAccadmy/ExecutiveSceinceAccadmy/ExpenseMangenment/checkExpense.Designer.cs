namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    partial class checkExpense
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnMain = new Panel();
            lbLogo = new Label();
            rdYear = new RadioButton();
            rdMonth = new RadioButton();
            dtExpense = new DataGridView();
            button1 = new Button();
            lblMonth = new Label();
            cmbMonth = new ComboBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtExpense).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(lbLogo);
            pnMain.Controls.Add(rdYear);
            pnMain.Controls.Add(rdMonth);
            pnMain.Controls.Add(dtExpense);
            pnMain.Controls.Add(button1);
            pnMain.Controls.Add(lblMonth);
            pnMain.Controls.Add(cmbMonth);
            pnMain.Location = new Point(12, 12);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(925, 535);
            pnMain.TabIndex = 0;
            pnMain.Paint += panel1_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(70, 24);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(776, 54);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdYear
            // 
            rdYear.AutoSize = true;
            rdYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdYear.Location = new Point(426, 106);
            rdYear.Name = "rdYear";
            rdYear.Size = new Size(238, 32);
            rdYear.TabIndex = 1;
            rdYear.TabStop = true;
            rdYear.Text = "Total Expense Of Year";
            rdYear.UseVisualStyleBackColor = true;
            // 
            // rdMonth
            // 
            rdMonth.AutoSize = true;
            rdMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdMonth.Location = new Point(162, 108);
            rdMonth.Name = "rdMonth";
            rdMonth.Size = new Size(258, 32);
            rdMonth.TabIndex = 2;
            rdMonth.TabStop = true;
            rdMonth.Text = "Check Monthly Expense";
            rdMonth.UseVisualStyleBackColor = true;
            // 
            // dtExpense
            // 
            dtExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtExpense.Location = new Point(0, 277);
            dtExpense.Name = "dtExpense";
            dtExpense.RowHeadersWidth = 51;
            dtExpense.Size = new Size(922, 255);
            dtExpense.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(489, 218);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 5;
            button1.Text = "Check Expense";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(202, 162);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(75, 28);
            lblMonth.TabIndex = 6;
            lblMonth.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(305, 162);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(360, 36);
            cmbMonth.TabIndex = 7;
            // 
            // checkExpense
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 579);
            Controls.Add(pnMain);
            Name = "checkExpense";
            Text = "Check Expense";
            Load += checkCurrMonth_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtExpense).EndInit();
            ResumeLayout(false);
        }

        private Panel pnMain;
        private Label lbLogo;
        private RadioButton rdYear;
        private RadioButton rdMonth;
        private DataGridView dtExpense;
        private Button button1;
        private Label lblMonth;
        private ComboBox cmbMonth;
    }
}