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
            lblAdd = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pnLogo = new Panel();
            lbLogo = new Label();
            label1 = new Label();
            lblDate = new Label();
            label3 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(label3);
            pnMain.Controls.Add(lblDate);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(lblAdd);
            pnMain.Controls.Add(comboBox1);
            pnMain.Controls.Add(button1);
            pnMain.Controls.Add(textBox1);
            pnMain.Controls.Add(dateTimePicker1);
            pnMain.Location = new Point(13, 98);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(789, 428);
            pnMain.TabIndex = 0;
            pnMain.Paint += panel1_Paint;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdd.Location = new Point(288, 15);
            lblAdd.Margin = new Padding(4, 0, 4, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(200, 41);
            lblAdd.TabIndex = 34;
            lblAdd.Text = "Add Expense";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(195, 147);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 36);
            comboBox1.TabIndex = 33;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(387, 260);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(156, 58);
            button1.TabIndex = 29;
            button1.Text = "Add Expense";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(195, 206);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 34);
            textBox1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(195, 68);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 34);
            dateTimePicker1.TabIndex = 32;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(13, 14);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(789, 74);
            pnLogo.TabIndex = 28;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(58, 9);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += lbLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 150);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 35;
            label1.Text = "Expense Type";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(131, 73);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 28);
            lblDate.TabIndex = 36;
            lblDate.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 209);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 29;
            label3.Text = "Expense Amount";
            // 
            // addExpense
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Panel pnLogo;
        private Label lbLogo;
        private Label label3;
        private Label lblDate;
        private Label label1;
    }
}