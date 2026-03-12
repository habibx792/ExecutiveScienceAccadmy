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
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colPresent = new DataGridViewCheckBoxColumn();
            cmbClass = new ComboBox();
            pnLogo = new Panel();
            cmbAttendance = new ComboBox();
            lbLogo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(751, 230);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(159, 52);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Class";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colStudentName, colGrade, colPresent });
            dataGridView1.Location = new Point(-1, 480);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1206, 230);
            dataGridView1.TabIndex = 1;
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
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbClass.Location = new Point(103, 230);
            cmbClass.Margin = new Padding(4, 5, 4, 5);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(297, 31);
            cmbClass.TabIndex = 2;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(cmbAttendance);
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Controls.Add(btnSearch);
            pnLogo.Controls.Add(cmbClass);
            pnLogo.Controls.Add(dataGridView1);
            pnLogo.Location = new Point(76, 14);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1206, 766);
            pnLogo.TabIndex = 8;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // cmbAttendance
            // 
            cmbAttendance.FormattingEnabled = true;
            cmbAttendance.Location = new Point(103, 288);
            cmbAttendance.Name = "cmbAttendance";
            cmbAttendance.Size = new Size(297, 31);
            cmbAttendance.TabIndex = 3;
            cmbAttendance.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lbLogo.Location = new Point(489, 154);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(202, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Attendance";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(76, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 135);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(653, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Executive Sceince Accadmy";
            label1.Click += label1_Click;
            // 
            // classWisAttencedance
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 1055);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "classWisAttencedance";
            Text = "classWisAttencedance";
            Load += classWisAttencedance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridView1;
        private ComboBox cmbClass;
        private Panel pnLogo;
        private Label lbLogo;

        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewCheckBoxColumn colPresent;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbAttendance;
    }
}
