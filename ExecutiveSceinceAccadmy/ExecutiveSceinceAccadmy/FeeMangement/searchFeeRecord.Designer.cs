namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class searchFeeRecord
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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            lblRollNo = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1378, 512);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1229, 708);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 64);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(15, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1378, 88);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(397, 23);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(383, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Search Fee Status Of Student";
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRollNo.Location = new Point(15, 114);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(126, 32);
            lblRollNo.TabIndex = 9;
            lblRollNo.Text = "RoLL NO :";
            lblRollNo.Click += lblRollNo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 23);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1178, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(908, 115);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 12;
            label1.Text = "Date :";
            // 
            // searchFeeRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 784);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(lblRollNo);
            Controls.Add(pnLogo);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "searchFeeRecord";
            Text = "searchFeeRecord";
            Load += searchFeeRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private Panel pnLogo;
        private Label lbLogo;
        private Label lblRollNo;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}