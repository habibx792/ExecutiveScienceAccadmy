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
            lbLogo = new Label();
            cmbYear = new ComboBox();
            cmbStart = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGen
            // 
            btnGen.BackColor = SystemColors.Highlight;
            btnGen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGen.Location = new Point(948, 76);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(108, 44);
            btnGen.TabIndex = 0;
            btnGen.Text = "search";
            btnGen.UseVisualStyleBackColor = false;
            btnGen.Click += button1_Click;
            // 
            // cmbEnd
            // 
            cmbEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbEnd.FormattingEnabled = true;
            cmbEnd.Location = new Point(587, 76);
            cmbEnd.Name = "cmbEnd";
            cmbEnd.Size = new Size(159, 29);
            cmbEnd.TabIndex = 2;
            // 
            // dtGrid
            // 
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(0, 161);
            dtGrid.Name = "dtGrid";
            dtGrid.RowHeadersWidth = 51;
            dtGrid.Size = new Size(1086, 361);
            dtGrid.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(lbLogo);
            panel1.Controls.Add(cmbYear);
            panel1.Controls.Add(cmbStart);
            panel1.Controls.Add(btnGen);
            panel1.Controls.Add(cmbEnd);
            panel1.Controls.Add(dtGrid);
            panel1.Location = new Point(32, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 522);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(385, 14);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 7;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbYear
            // 
            cmbYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(775, 76);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(149, 29);
            cmbYear.TabIndex = 6;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            // 
            // cmbStart
            // 
            cmbStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbStart.FormattingEnabled = true;
            cmbStart.Location = new Point(402, 76);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(164, 29);
            cmbStart.TabIndex = 5;
            // 
            // expenseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1138, 565);
            Controls.Add(panel1);
            Name = "expenseReport";
            Text = "expenseReport";
            Load += expenseReport_Load;
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGen;
        private ComboBox cmbEnd;
        private DataGridView dtGrid;
        private Panel panel1;
        private ComboBox cmbStart;
        private ComboBox cmbYear;
        private Label lbLogo;
    }
}