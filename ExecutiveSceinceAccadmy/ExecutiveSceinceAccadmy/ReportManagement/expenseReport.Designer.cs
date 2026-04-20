namespace ExecutiveSceinceAccadmy.ReportManagement
{
    partial class expenseReport
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
            btnGen = new Button();
            cmbEnd = new ComboBox();
            dtGrid = new DataGridView();
            panel1 = new Panel();
            cmbYear = new ComboBox();
            cmbStart = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGen
            // 
            btnGen.Location = new Point(1051, 25);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(75, 46);
            btnGen.TabIndex = 0;
            btnGen.Text = "search";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += button1_Click;
            // 
            // cmbEnd
            // 
            cmbEnd.FormattingEnabled = true;
            cmbEnd.Location = new Point(673, 25);
            cmbEnd.Name = "cmbEnd";
            cmbEnd.Size = new Size(121, 23);
            cmbEnd.TabIndex = 2;
            // 
            // dtGrid
            // 
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(24, 161);
            dtGrid.Name = "dtGrid";
            dtGrid.Size = new Size(1091, 380);
            dtGrid.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbYear);
            panel1.Controls.Add(cmbStart);
            panel1.Controls.Add(btnGen);
            panel1.Controls.Add(cmbEnd);
            panel1.Controls.Add(dtGrid);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 553);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(844, 26);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(149, 23);
            cmbYear.TabIndex = 6;
            // 
            // cmbStart
            // 
            cmbStart.FormattingEnabled = true;
            cmbStart.Location = new Point(525, 26);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(121, 23);
            cmbStart.TabIndex = 5;
            // 
            // expenseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 565);
            Controls.Add(panel1);
            Name = "expenseReport";
            Text = "expenseReport";
            Load += expenseReport_Load;
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGen;
        private ComboBox cmbEnd;
        private DataGridView dtGrid;
        private Panel panel1;
        private ComboBox cmbStart;
        private ComboBox cmbYear;
    }
}