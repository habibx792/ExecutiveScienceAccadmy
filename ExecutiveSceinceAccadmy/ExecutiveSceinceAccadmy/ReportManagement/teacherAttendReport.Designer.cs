namespace ExecutiveSceinceAccadmy.ReportManagement
{
    partial class teacherAttendReport
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
            panel2 = new Panel();
            label1 = new Label();
            cmbTeacher = new ComboBox();
            lbLogo = new Label();
            cmbMonth = new ComboBox();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            label2 = new Label();
            lblMonth = new Label();
            rdMonth = new RadioButton();
            btnSearch = new Button();
            rdDay = new RadioButton();
            txtReginstraion = new TextBox();
            dtDashAttend = new DataGridView();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbTeacher);
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
            panel2.Size = new Size(887, 273);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(176, 129);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 15;
            label1.Text = "TeacherName";
            // 
            // cmbTeacher
            // 
            cmbTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(320, 129);
            cmbTeacher.Margin = new Padding(2);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(258, 29);
            cmbTeacher.TabIndex = 14;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(227, 0);
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
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDate.Location = new Point(320, 87);
            dtDate.Margin = new Padding(2);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(258, 27);
            dtDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(165, 181);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 11;
            label2.Text = "Registration No";
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
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(470, 212);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 52);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            // txtReginstraion
            // 
            txtReginstraion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReginstraion.Location = new Point(320, 173);
            txtReginstraion.Margin = new Padding(2);
            txtReginstraion.Name = "txtReginstraion";
            txtReginstraion.PlaceholderText = "Enter Registration Number";
            txtReginstraion.Size = new Size(258, 29);
            txtReginstraion.TabIndex = 6;
            // 
            // dtDashAttend
            // 
            dtDashAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDashAttend.Location = new Point(0, 268);
            dtDashAttend.Margin = new Padding(2);
            dtDashAttend.Name = "dtDashAttend";
            dtDashAttend.RowHeadersWidth = 51;
            dtDashAttend.Size = new Size(887, 222);
            dtDashAttend.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dtDashAttend);
            panel1.Location = new Point(11, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 492);
            panel1.TabIndex = 8;
            // 
            // teacherAttendReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(910, 515);
            Controls.Add(panel1);
            Name = "teacherAttendReport";
            Text = "teacherAttendReport";
            Load += teacherAttendReport_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lbLogo;
        private ComboBox cmbMonth;
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label label2;
        private Label lblMonth;
        private RadioButton rdMonth;
        private Button btnSearch;
        private RadioButton rdDay;
        private TextBox txtReginstraion;
        private DataGridView dtDashAttend;
        private Panel panel1;
        private Label label1;
        public ComboBox cmbTeacher;
        private ComboBox comboBox1;
    }
}