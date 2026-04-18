namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    partial class studentAttendReport
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
            dtDashAttend = new DataGridView();
            dtDate = new DateTimePicker();
            lblMonth = new Label();
            txtReginstraion = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lbLogo = new Label();
            cmbMonth = new ComboBox();
            lblDate = new Label();
            label2 = new Label();
            rdMonth = new RadioButton();
            rdDay = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(469, 164);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 44);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button2_Click;
            // 
            // dtDashAttend
            // 
            dtDashAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDashAttend.Location = new Point(0, 224);
            dtDashAttend.Margin = new Padding(2);
            dtDashAttend.Name = "dtDashAttend";
            dtDashAttend.RowHeadersWidth = 51;
            dtDashAttend.Size = new Size(887, 222);
            dtDashAttend.TabIndex = 2;
            dtDashAttend.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDate.Location = new Point(320, 87);
            dtDate.Margin = new Padding(2);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(258, 27);
            dtDate.TabIndex = 3;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(234, 89);
            lblMonth.Margin = new Padding(2, 0, 2, 0);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(61, 21);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "Month";
            // 
            // txtReginstraion
            // 
            txtReginstraion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReginstraion.Location = new Point(320, 128);
            txtReginstraion.Margin = new Padding(2);
            txtReginstraion.Name = "txtReginstraion";
            txtReginstraion.PlaceholderText = "Enter Registration Number";
            txtReginstraion.Size = new Size(258, 29);
            txtReginstraion.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dtDashAttend);
            panel1.Location = new Point(11, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 448);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(lbLogo);
            panel2.Controls.Add(cmbMonth);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(dtDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblMonth);
            panel2.Controls.Add(rdMonth);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(rdDay);
            panel2.Controls.Add(txtReginstraion);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 226);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(206, 7);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 13;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(320, 87);
            cmbMonth.Margin = new Padding(2);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(258, 29);
            cmbMonth.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(243, 87);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 21);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(166, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 11;
            label2.Text = "Registration No";
            // 
            // rdMonth
            // 
            rdMonth.AutoSize = true;
            rdMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdMonth.Location = new Point(452, 54);
            rdMonth.Margin = new Padding(2);
            rdMonth.Name = "rdMonth";
            rdMonth.Size = new Size(157, 25);
            rdMonth.TabIndex = 10;
            rdMonth.TabStop = true;
            rdMonth.Text = "Search By Month";
            rdMonth.UseVisualStyleBackColor = true;
            rdMonth.CheckedChanged += rdMonth_CheckedChanged;
            // 
            // rdDay
            // 
            rdDay.AutoSize = true;
            rdDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdDay.Location = new Point(312, 54);
            rdDay.Margin = new Padding(2);
            rdDay.Name = "rdDay";
            rdDay.Size = new Size(142, 25);
            rdDay.TabIndex = 9;
            rdDay.TabStop = true;
            rdDay.Text = "Search by Date";
            rdDay.UseVisualStyleBackColor = true;
            rdDay.CheckedChanged += rdDay_CheckedChanged;
            // 
            // studentAttendReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(910, 468);
            Controls.Add(panel1);
            Name = "studentAttendReport";
            Text = "markAttedance";
            Load += AttendanceDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSearch;
        private DataGridView dtDashAttend;
        private DateTimePicker dtDate;
        private Label lblMonth;
        private TextBox txtReginstraion;
        private Panel panel1;
        private ComboBox cmbMonth;
        private Label lblDate;
        private Label label2;
        private RadioButton rdMonth;
        private RadioButton rdDay;
        private Panel panel2;
        private Label lbLogo;
    }
}