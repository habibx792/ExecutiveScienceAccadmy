namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    partial class addExpense
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
            label3 = new Label();
            lblDate = new Label();
            label1 = new Label();
            lblAdd = new Label();
            cmbExpense = new ComboBox();
            btnExpenseAdd = new Button();
            txtExenseAmount = new TextBox();
            dtExpense = new DateTimePicker();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(label3);
            pnMain.Controls.Add(lblDate);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(lblAdd);
            pnMain.Controls.Add(cmbExpense);
            pnMain.Controls.Add(btnExpenseAdd);
            pnMain.Controls.Add(txtExenseAmount);
            pnMain.Controls.Add(dtExpense);
            pnMain.Location = new Point(13, 98);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(789, 461);
            pnMain.TabIndex = 0;
            pnMain.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(85, 251);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 29;
            label3.Text = "Expense Amount";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(85, 110);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(140, 28);
            lblDate.TabIndex = 36;
            lblDate.Text = "Expense Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(85, 189);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 35;
            label1.Text = "Expense Type";
            label1.Click += label1_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdd.Location = new Point(310, 15);
            lblAdd.Margin = new Padding(4, 0, 4, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(200, 41);
            lblAdd.TabIndex = 34;
            lblAdd.Text = "Add Expense";
            // 
            // cmbExpense
            // 
            cmbExpense.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbExpense.FormattingEnabled = true;
            cmbExpense.Location = new Point(263, 189);
            cmbExpense.Margin = new Padding(4, 5, 4, 5);
            cmbExpense.Name = "cmbExpense";
            cmbExpense.Size = new Size(348, 36);
            cmbExpense.TabIndex = 33;
            // 
            // btnExpenseAdd
            // 
            btnExpenseAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExpenseAdd.Location = new Point(455, 302);
            btnExpenseAdd.Margin = new Padding(4, 5, 4, 5);
            btnExpenseAdd.Name = "btnExpenseAdd";
            btnExpenseAdd.Size = new Size(156, 58);
            btnExpenseAdd.TabIndex = 29;
            btnExpenseAdd.Text = "Add Expense";
            btnExpenseAdd.UseVisualStyleBackColor = true;
            btnExpenseAdd.Click += btnExpenseAdd_Click;
            // 
            // txtExenseAmount
            // 
            txtExenseAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtExenseAmount.Location = new Point(263, 248);
            txtExenseAmount.Margin = new Padding(4, 5, 4, 5);
            txtExenseAmount.Name = "txtExenseAmount";
            txtExenseAmount.Size = new Size(348, 34);
            txtExenseAmount.TabIndex = 31;
            // 
            // dtExpense
            // 
            dtExpense.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtExpense.Location = new Point(263, 110);
            dtExpense.Margin = new Padding(4, 5, 4, 5);
            dtExpense.Name = "dtExpense";
            dtExpense.Size = new Size(348, 34);
            dtExpense.TabIndex = 32;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(13, 34);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(789, 74);
            pnLogo.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(126, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(537, 54);
            label6.TabIndex = 29;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addExpense
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(824, 573);
            Controls.Add(pnLogo);
            Controls.Add(pnMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "addExpense";
            Text = "addExpense";
            Load += addExpense_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Label lblAdd;
        private ComboBox cmbExpense;
        private Button btnExpenseAdd;
        private TextBox txtExenseAmount;
        private DateTimePicker dtExpense;
        private Panel pnLogo;
        private Label label3;
        private Label lblDate;
        private Label label1;
        private Label label6;
    }
}