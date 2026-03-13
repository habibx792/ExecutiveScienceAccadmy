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
            lbLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGirdPaidStatus).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(516, 269);
            button1.Name = "button1";
            button1.Size = new Size(121, 53);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtGirdPaidStatus
            // 
            dtGirdPaidStatus.BackgroundColor = Color.FromArgb(255, 128, 128);
            dtGirdPaidStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGirdPaidStatus.Location = new Point(45, 471);
            dtGirdPaidStatus.Name = "dtGirdPaidStatus";
            dtGirdPaidStatus.RowHeadersWidth = 51;
            dtGirdPaidStatus.Size = new Size(850, 188);
            dtGirdPaidStatus.TabIndex = 3;
            // 
            // rdFeeId
            // 
            rdFeeId.AutoSize = true;
            rdFeeId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdFeeId.Location = new Point(224, 109);
            rdFeeId.Name = "rdFeeId";
            rdFeeId.Size = new Size(191, 32);
            rdFeeId.TabIndex = 4;
            rdFeeId.TabStop = true;
            rdFeeId.Text = "Search By Fee ID";
            rdFeeId.UseVisualStyleBackColor = true;
            rdFeeId.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(lblSearchby);
            panel1.Controls.Add(rdStdId);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(rdFeeId);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(45, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 352);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 84);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 7;
            label1.Text = "Search Fee Record";
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
            // rdStdId
            // 
            rdStdId.AutoSize = true;
            rdStdId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdStdId.Location = new Point(430, 109);
            rdStdId.Name = "rdStdId";
            rdStdId.Size = new Size(233, 32);
            rdStdId.TabIndex = 5;
            rdStdId.TabStop = true;
            rdStdId.Text = "Search By Student ID";
            rdStdId.UseVisualStyleBackColor = true;
            rdStdId.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(224, 219);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(413, 36);
            cmbMonth.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(224, 162);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Enter Registeratrion Number";
            txtId.Size = new Size(413, 34);
            txtId.TabIndex = 2;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(173, 42);
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
            ClientSize = new Size(947, 732);
            Controls.Add(lbLogo);
            Controls.Add(panel1);
            Controls.Add(dtGirdPaidStatus);
            Name = "feeRecordSearch";
            Text = "feeRecordSearch";
            Load += feeRecordSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dtGirdPaidStatus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dtGirdPaidStatus;
        private RadioButton rdFeeId;
        private Panel panel1;
        private ComboBox cmbMonth;
        private TextBox txtId;
        private RadioButton rdStdId;
        private Label lblSearchby;
        private Label label1;
        private Label lbLogo;
        private Label lblMonth;
        private Panel panel2;
    }
}