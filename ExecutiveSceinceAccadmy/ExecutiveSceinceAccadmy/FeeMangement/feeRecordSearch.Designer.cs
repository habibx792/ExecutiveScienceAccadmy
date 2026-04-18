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
            btnSearch = new Button();
            dtGirdPaidStatus = new DataGridView();
            rdFeeId = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            lblMonth = new Label();
            lblSearchby = new Label();
            rdStdId = new RadioButton();
            cmbMonth = new ComboBox();
            txtId = new TextBox();
            pnLogo = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGirdPaidStatus).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(401, 175);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 47);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // dtGirdPaidStatus
            // 
            dtGirdPaidStatus.BackgroundColor = Color.IndianRed;
            dtGirdPaidStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGirdPaidStatus.Location = new Point(22, 299);
            dtGirdPaidStatus.Margin = new Padding(2, 2, 2, 2);
            dtGirdPaidStatus.Name = "dtGirdPaidStatus";
            dtGirdPaidStatus.RowHeadersWidth = 51;
            dtGirdPaidStatus.Size = new Size(661, 123);
            dtGirdPaidStatus.TabIndex = 3;
            // 
            // rdFeeId
            // 
            rdFeeId.AutoSize = true;
            rdFeeId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdFeeId.Location = new Point(174, 71);
            rdFeeId.Margin = new Padding(2, 2, 2, 2);
            rdFeeId.Name = "rdFeeId";
            rdFeeId.Size = new Size(153, 25);
            rdFeeId.TabIndex = 4;
            rdFeeId.TabStop = true;
            rdFeeId.Text = "Search By Fee ID";
            rdFeeId.UseVisualStyleBackColor = true;
            rdFeeId.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(lblSearchby);
            panel1.Controls.Add(rdStdId);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(rdFeeId);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(22, 73);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 230);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 55);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 11);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 7;
            label1.Text = "Search Fee Record";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(75, 142);
            lblMonth.Margin = new Padding(2, 0, 2, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(61, 21);
            lblMonth.TabIndex = 9;
            lblMonth.Text = "Month";
            // 
            // lblSearchby
            // 
            lblSearchby.AutoSize = true;
            lblSearchby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchby.Location = new Point(47, 107);
            lblSearchby.Margin = new Padding(2, 0, 2, 0);
            lblSearchby.Name = "lblSearchby";
            lblSearchby.Size = new Size(89, 21);
            lblSearchby.TabIndex = 8;
            lblSearchby.Text = "Student Id";
            // 
            // rdStdId
            // 
            rdStdId.AutoSize = true;
            rdStdId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdStdId.Location = new Point(334, 71);
            rdStdId.Margin = new Padding(2, 2, 2, 2);
            rdStdId.Name = "rdStdId";
            rdStdId.Size = new Size(187, 25);
            rdStdId.TabIndex = 5;
            rdStdId.TabStop = true;
            rdStdId.Text = "Search By Student ID";
            rdStdId.UseVisualStyleBackColor = true;
            rdStdId.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(174, 143);
            cmbMonth.Margin = new Padding(2, 2, 2, 2);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(322, 25);
            cmbMonth.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtId.Location = new Point(174, 106);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Enter Registeratrion Number";
            txtId.Size = new Size(322, 25);
            txtId.TabIndex = 2;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label2);
            pnLogo.Location = new Point(22, 22);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(661, 53);
            pnLogo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(108, 14);
            label2.Name = "label2";
            label2.Size = new Size(426, 45);
            label2.TabIndex = 0;
            label2.Text = "Executive Science Academy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // feeRecordSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(713, 440);
            Controls.Add(pnLogo);
            Controls.Add(panel1);
            Controls.Add(dtGirdPaidStatus);
            Margin = new Padding(2, 2, 2, 2);
            Name = "feeRecordSearch";
            Text = "feeRecordSearch";
            Load += feeRecordSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dtGirdPaidStatus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSearch;
        private DataGridView dtGirdPaidStatus;
        private RadioButton rdFeeId;
        private Panel panel1;
        private ComboBox cmbMonth;
        private TextBox txtId;
        private RadioButton rdStdId;
        private Label lblSearchby;
        private Label label1;
        private Label lblMonth;
        private Panel panel2;
        private Panel pnLogo;
        private Label label2;
    }
}