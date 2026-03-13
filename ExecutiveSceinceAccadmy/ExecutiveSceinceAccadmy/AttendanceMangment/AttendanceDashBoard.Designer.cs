namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    partial class AttendanceDashBoard
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
            button2 = new Button();
            dtDashAttend = new DataGridView();
            dtDate = new DateTimePicker();
            lblMonth = new Label();
            txtReginstraion = new TextBox();
            panel1 = new Panel();
            lblDate = new Label();
            label2 = new Label();
            rdMonth = new RadioButton();
            rdDay = new RadioButton();
            cmbMonth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(414, 228);
            button2.Name = "button2";
            button2.Size = new Size(139, 59);
            button2.TabIndex = 1;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtDashAttend
            // 
            dtDashAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDashAttend.Location = new Point(3, 343);
            dtDashAttend.Name = "dtDashAttend";
            dtDashAttend.RowHeadersWidth = 51;
            dtDashAttend.Size = new Size(1186, 408);
            dtDashAttend.TabIndex = 2;
            dtDashAttend.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDate.Location = new Point(223, 111);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(330, 31);
            dtDate.TabIndex = 3;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(112, 114);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(75, 28);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "Month";
            // 
            // txtReginstraion
            // 
            txtReginstraion.Location = new Point(223, 174);
            txtReginstraion.Name = "txtReginstraion";
            txtReginstraion.Size = new Size(330, 30);
            txtReginstraion.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rdMonth);
            panel1.Controls.Add(rdDay);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(dtDashAttend);
            panel1.Controls.Add(txtReginstraion);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(dtDate);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 753);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(124, 110);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 28);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 176);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 11;
            label2.Text = "Registration No";
            // 
            // rdMonth
            // 
            rdMonth.AutoSize = true;
            rdMonth.Location = new Point(392, 15);
            rdMonth.Name = "rdMonth";
            rdMonth.Size = new Size(161, 27);
            rdMonth.TabIndex = 10;
            rdMonth.TabStop = true;
            rdMonth.Text = "Search By Month";
            rdMonth.UseVisualStyleBackColor = true;
            rdMonth.CheckedChanged += rdMonth_CheckedChanged;
            // 
            // rdDay
            // 
            rdDay.AutoSize = true;
            rdDay.Location = new Point(213, 15);
            rdDay.Name = "rdDay";
            rdDay.Size = new Size(146, 27);
            rdDay.TabIndex = 9;
            rdDay.TabStop = true;
            rdDay.Text = "Search by Date";
            rdDay.UseVisualStyleBackColor = true;
            rdDay.CheckedChanged += rdDay_CheckedChanged;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(223, 110);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(330, 31);
            cmbMonth.TabIndex = 7;
            // 
            // AttendanceDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 781);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AttendanceDashBoard";
            Text = "markAttedance";
            Load += AttendanceDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dtDashAttend).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
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
    }
}