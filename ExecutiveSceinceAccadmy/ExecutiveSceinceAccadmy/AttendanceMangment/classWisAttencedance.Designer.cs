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
            comboBox1 = new ComboBox();
            pnLogo = new Panel();
            lbLogo = new Label();

            colDate = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colPresent = new DataGridViewCheckBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
            SuspendLayout();

            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(423, 141);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search Class";
            btnSearch.UseVisualStyleBackColor = true;

            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colDate,
                colStudentName,
                colGrade,
                colPresent
            });
            dataGridView1.Location = new Point(59, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1194, 150);
            dataGridView1.TabIndex = 1;

            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
                "1","2","3","4","5","6","7","8","9","10","11","12"
            });
            comboBox1.Location = new Point(78, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 2;

            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(78, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1155, 88);
            pnLogo.TabIndex = 8;

            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogo.Location = new Point(468, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(148, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Attendance";

            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.Width = 150;

            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Name";
            colStudentName.Name = "colStudentName";
            colStudentName.Width = 500;

            // 
            // colGrade
            // 
            colGrade.HeaderText = "Grade";
            colGrade.Name = "colGrade";
            colGrade.Width = 300;

            // 
            // colPresent
            // 
            colPresent.HeaderText = "Present";
            colPresent.Name = "colPresent";
            colPresent.TrueValue = true;
            colPresent.FalseValue = false;
            colPresent.Width = 200;

            // 
            // classWisAttencedance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 840);
            Controls.Add(pnLogo);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            this.Name = "classWisAttencedance";
            this.Text = "classWisAttencedance";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Panel pnLogo;
        private Label lbLogo;

        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewCheckBoxColumn colPresent;
    }
}
