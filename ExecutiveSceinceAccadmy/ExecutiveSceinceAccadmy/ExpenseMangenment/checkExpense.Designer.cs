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
            pnMain.Location = new Point(23, 42);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(925, 535);
            pnMain.TabIndex = 0;
            pnMain.Paint += panel1_Paint;
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
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(23, 42);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(922, 78);
            pnLogo.TabIndex = 28;
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
            // checkExpense
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1024, 643);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
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