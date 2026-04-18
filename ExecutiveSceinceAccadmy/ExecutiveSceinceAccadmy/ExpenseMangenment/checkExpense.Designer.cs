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
            rdYear = new RadioButton();
            rdMonth = new RadioButton();
            dtExpense = new DataGridView();
            button1 = new Button();
            lblMonth = new Label();
            cmbMonth = new ComboBox();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtExpense).BeginInit();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(rdYear);
            pnMain.Controls.Add(rdMonth);
            pnMain.Controls.Add(dtExpense);
            pnMain.Controls.Add(button1);
            pnMain.Controls.Add(lblMonth);
            pnMain.Controls.Add(cmbMonth);
            pnMain.Location = new Point(18, 27);
            pnMain.Margin = new Padding(2);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(719, 349);
            pnMain.TabIndex = 0;
            pnMain.Paint += panel1_Paint;
            // 
            // rdYear
            // 
            rdYear.AutoSize = true;
            rdYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdYear.Location = new Point(331, 69);
            rdYear.Margin = new Padding(2);
            rdYear.Name = "rdYear";
            rdYear.Size = new Size(192, 25);
            rdYear.TabIndex = 1;
            rdYear.TabStop = true;
            rdYear.Text = "Total Expense Of Year";
            rdYear.UseVisualStyleBackColor = true;
            // 
            // rdMonth
            // 
            rdMonth.AutoSize = true;
            rdMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdMonth.Location = new Point(126, 70);
            rdMonth.Margin = new Padding(2);
            rdMonth.Name = "rdMonth";
            rdMonth.Size = new Size(210, 25);
            rdMonth.TabIndex = 2;
            rdMonth.TabStop = true;
            rdMonth.Text = "Check Monthly Expense";
            rdMonth.UseVisualStyleBackColor = true;
            // 
            // dtExpense
            // 
            dtExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtExpense.Location = new Point(0, 181);
            dtExpense.Margin = new Padding(2);
            dtExpense.Name = "dtExpense";
            dtExpense.RowHeadersWidth = 51;
            dtExpense.Size = new Size(717, 166);
            dtExpense.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(380, 142);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 5;
            button1.Text = "Check Expense";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(157, 106);
            lblMonth.Margin = new Padding(2, 0, 2, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(61, 21);
            lblMonth.TabIndex = 6;
            lblMonth.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(237, 106);
            cmbMonth.Margin = new Padding(2);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(281, 25);
            cmbMonth.TabIndex = 7;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(18, 27);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(717, 51);
            pnLogo.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(148, 10);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // checkExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(755, 393);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Margin = new Padding(2);
            Name = "checkExpense";
            Text = "Check Expense";
            Load += checkCurrMonth_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtExpense).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnMain;
        private RadioButton rdYear;
        private RadioButton rdMonth;
        private DataGridView dtExpense;
        private Button button1;
        private Label lblMonth;
        private ComboBox cmbMonth;
        private Panel pnLogo;
        private Label label6;
    }
}