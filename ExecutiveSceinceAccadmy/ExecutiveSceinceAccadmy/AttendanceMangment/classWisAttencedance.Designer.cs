namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    partial class classWisAttencedance
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnSearch = new Button();
            dtGridAttence = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colPresent = new DataGridViewCheckBoxColumn();
            cmbClass = new ComboBox();
            pnLogo = new Panel();
            lbLogo = new Label();
            label1 = new Label();
            btnMark = new Button();
            panel2 = new Panel();
            cmbAttendanceType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtGridAttence).BeginInit();
            pnLogo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(681, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Class";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtGridAttence
            // 
            dtGridAttence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridAttence.Columns.AddRange(new DataGridViewColumn[] { colDate, colStudentName, colGrade, colPresent });
            dtGridAttence.Location = new Point(3, 181);
            dtGridAttence.Name = "dtGridAttence";
            dtGridAttence.RowHeadersWidth = 51;
            dtGridAttence.Size = new Size(935, 264);
            dtGridAttence.TabIndex = 1;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.Width = 150;
            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Name";
            colStudentName.MinimumWidth = 6;
            colStudentName.Name = "colStudentName";
            colStudentName.Width = 500;
            // 
            // colGrade
            // 
            colGrade.HeaderText = "Grade";
            colGrade.MinimumWidth = 6;
            colGrade.Name = "colGrade";
            colGrade.Width = 300;
            // 
            // colPresent
            // 
            colPresent.FalseValue = false;
            colPresent.HeaderText = "Present";
            colPresent.MinimumWidth = 6;
            colPresent.Name = "colPresent";
            colPresent.TrueValue = true;
            colPresent.Width = 200;
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbClass.Location = new Point(18, 14);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(291, 29);
            cmbClass.TabIndex = 2;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Controls.Add(label1);
            pnLogo.Controls.Add(btnMark);
            pnLogo.Controls.Add(panel2);
            pnLogo.Controls.Add(dtGridAttence);
            pnLogo.Location = new Point(10, 7);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(938, 500);
            pnLogo.TabIndex = 8;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(334, 47);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(164, 37);
            lbLogo.TabIndex = 16;
            lbLogo.Text = "Attendance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 70, 140);
            label1.Location = new Point(231, 2);
            label1.Name = "label1";
            label1.Size = new Size(426, 45);
            label1.TabIndex = 15;
            label1.Text = "Executive Science Academy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnMark
            // 
            btnMark.BackColor = SystemColors.Highlight;
            btnMark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMark.ForeColor = Color.White;
            btnMark.Location = new Point(782, 452);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(124, 44);
            btnMark.TabIndex = 5;
            btnMark.Text = "Mark";
            btnMark.UseVisualStyleBackColor = false;
            btnMark.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(cmbAttendanceType);
            panel2.Controls.Add(cmbClass);
            panel2.Controls.Add(btnSearch);
            panel2.Location = new Point(-1, 88);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 51);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // cmbAttendanceType
            // 
            cmbAttendanceType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAttendanceType.FormattingEnabled = true;
            cmbAttendanceType.Location = new Point(335, 14);
            cmbAttendanceType.Margin = new Padding(2);
            cmbAttendanceType.Name = "cmbAttendanceType";
            cmbAttendanceType.Size = new Size(233, 29);
            cmbAttendanceType.TabIndex = 3;
            cmbAttendanceType.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // classWisAttencedance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(981, 515);
            Controls.Add(pnLogo);
            Name = "classWisAttencedance";
            Text = "classWisAttencedance";
            Load += classWisAttencedance_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridAttence).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private DataGridView dtGridAttence;
        private ComboBox cmbClass;
        private Panel pnLogo;

        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewCheckBoxColumn colPresent;
        private ComboBox cmbAttendanceType;
        private Panel panel2;
        private Button btnMark;
        private Label label1;
        private Label lbLogo;
    }
}
