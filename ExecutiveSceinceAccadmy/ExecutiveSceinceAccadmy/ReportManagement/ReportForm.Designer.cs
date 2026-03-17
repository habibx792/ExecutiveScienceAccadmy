namespace ExecutiveSceinceAccadmy.ReportManagement
{
    partial class ReportForm
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
            pnMain = new Panel();
            btnCurrMon = new Button();
            btnAddExp = new Button();
            btnCurrYearReport = new Button();
            btnFromDate = new Button();
            pnLogo = new Panel();
            label6 = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Controls.Add(btnCurrMon);
            pnMain.Controls.Add(btnAddExp);
            pnMain.Controls.Add(btnCurrYearReport);
            pnMain.Controls.Add(btnFromDate);
            pnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnMain.Location = new Point(33, 156);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(766, 307);
            pnMain.TabIndex = 28;
            // 
            // btnCurrMon
            // 
            btnCurrMon.Location = new Point(418, 38);
            btnCurrMon.Margin = new Padding(4, 5, 4, 5);
            btnCurrMon.Name = "btnCurrMon";
            btnCurrMon.Size = new Size(284, 104);
            btnCurrMon.TabIndex = 26;
            btnCurrMon.Text = "Expense Report";
            btnCurrMon.UseVisualStyleBackColor = true;
            btnCurrMon.Click += btnCurrMon_Click;
            // 
            // btnAddExp
            // 
            btnAddExp.Location = new Point(70, 38);
            btnAddExp.Margin = new Padding(4, 5, 4, 5);
            btnAddExp.Name = "btnAddExp";
            btnAddExp.Size = new Size(294, 104);
            btnAddExp.TabIndex = 24;
            btnAddExp.Text = "Add Expense";
            btnAddExp.UseVisualStyleBackColor = true;
            btnAddExp.Click += btnAddExp_Click;
            // 
            // btnCurrYearReport
            // 
            btnCurrYearReport.Location = new Point(70, 164);
            btnCurrYearReport.Margin = new Padding(4, 5, 4, 5);
            btnCurrYearReport.Name = "btnCurrYearReport";
            btnCurrYearReport.Size = new Size(294, 100);
            btnCurrYearReport.TabIndex = 25;
            btnCurrYearReport.Text = "Current Year";
            btnCurrYearReport.UseVisualStyleBackColor = true;
            // 
            // btnFromDate
            // 
            btnFromDate.Location = new Point(418, 164);
            btnFromDate.Margin = new Padding(4, 5, 4, 5);
            btnFromDate.Name = "btnFromDate";
            btnFromDate.Size = new Size(284, 100);
            btnFromDate.TabIndex = 20;
            btnFromDate.Text = "From ToDay";
            btnFromDate.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label6);
            pnLogo.Location = new Point(33, 25);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(766, 135);
            pnLogo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(115, 40);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(537, 54);
            label6.TabIndex = 31;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(854, 502);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            pnMain.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button btnAddExp;
        private Button btnRts;
        private Button btnCurrYearReport;
        private Button btnUpAtt;
        private Button btnFromDate;
        private Button btnDashBoad;
        private Panel pnLogo;
        private Button btnCurrMon;
        private Label label6;
    }
}