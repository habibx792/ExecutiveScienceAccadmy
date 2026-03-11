namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class feeRecordSearch
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            rdFeeId = new RadioButton();
            panel1 = new Panel();
            lblMonth = new Label();
            lblSearchby = new Label();
            label1 = new Label();
            rdStdId = new RadioButton();
            cmbMonth = new ComboBox();
            textBox1 = new TextBox();
            lbLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(543, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 128, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 471);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 188);
            dataGridView1.TabIndex = 3;
            // 
            // rdFeeId
            // 
            rdFeeId.AutoSize = true;
            rdFeeId.Location = new Point(224, 109);
            rdFeeId.Name = "rdFeeId";
            rdFeeId.Size = new Size(158, 27);
            rdFeeId.TabIndex = 4;
            rdFeeId.TabStop = true;
            rdFeeId.Text = "Search By Fee ID";
            rdFeeId.UseVisualStyleBackColor = true;
            rdFeeId.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(lblSearchby);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rdStdId);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(rdFeeId);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(279, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 352);
            panel1.TabIndex = 5;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(96, 217);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(75, 28);
            lblMonth.TabIndex = 9;
            lblMonth.Text = "Month";
            // 
            // lblSearchby
            // 
            lblSearchby.AutoSize = true;
            lblSearchby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchby.Location = new Point(61, 164);
            lblSearchby.Name = "lblSearchby";
            lblSearchby.Size = new Size(110, 28);
            lblSearchby.TabIndex = 8;
            lblSearchby.Text = "Student Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 7;
            label1.Text = "Search Fee Record";
            // 
            // rdStdId
            // 
            rdStdId.AutoSize = true;
            rdStdId.Location = new Point(430, 109);
            rdStdId.Name = "rdStdId";
            rdStdId.Size = new Size(191, 27);
            rdStdId.TabIndex = 5;
            rdStdId.TabStop = true;
            rdStdId.Text = "Search By Student ID";
            rdStdId.UseVisualStyleBackColor = true;
            rdStdId.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(224, 219);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(413, 31);
            cmbMonth.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 30);
            textBox1.TabIndex = 2;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(364, 41);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 6;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // feeRecordSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1432, 732);
            Controls.Add(lbLogo);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "feeRecordSearch";
            Text = "feeRecordSearch";
            Load += feeRecordSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private RadioButton rdFeeId;
        private Panel panel1;
        private ComboBox cmbMonth;
        private TextBox textBox1;
        private RadioButton rdStdId;
        private Label lblSearchby;
        private Label label1;
        private Label lbLogo;
        private Label lblMonth;
    }
}