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
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnCurrMon);
            pnMain.Controls.Add(btnAddExp);
            pnMain.Controls.Add(btnCurrYearReport);
            pnMain.Controls.Add(btnFromDate);
            pnMain.Location = new Point(399, 185);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(596, 396);
            pnMain.TabIndex = 28;
            // 
            // btnCurrMon
            // 
            btnCurrMon.Location = new Point(315, 41);
            btnCurrMon.Name = "btnCurrMon";
            btnCurrMon.Size = new Size(221, 130);
            btnCurrMon.TabIndex = 26;
            btnCurrMon.Text = "Current Month";
            btnCurrMon.UseVisualStyleBackColor = true;
            // 
            // btnAddExp
            // 
            btnAddExp.Location = new Point(44, 41);
            btnAddExp.Name = "btnAddExp";
            btnAddExp.Size = new Size(229, 130);
            btnAddExp.TabIndex = 24;
            btnAddExp.Text = "Add Expense";
            btnAddExp.UseVisualStyleBackColor = true;
            btnAddExp.Click += btnAddExp_Click;
            // 
            // btnCurrYearReport
            // 
            btnCurrYearReport.Location = new Point(36, 185);
            btnCurrYearReport.Name = "btnCurrYearReport";
            btnCurrYearReport.Size = new Size(237, 130);
            btnCurrYearReport.TabIndex = 25;
            btnCurrYearReport.Text = "Current Year";
            btnCurrYearReport.UseVisualStyleBackColor = true;
            // 
            // btnFromDate
            // 
            btnFromDate.Location = new Point(315, 185);
            btnFromDate.Name = "btnFromDate";
            btnFromDate.Size = new Size(221, 130);
            btnFromDate.TabIndex = 20;
            btnFromDate.Text = "From ToDay";
            btnFromDate.UseVisualStyleBackColor = true;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(110, 27);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1178, 88);
            pnLogo.TabIndex = 27;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(356, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 605);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Margin = new Padding(2);
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
        private Label lbLogo;
        private Button btnCurrMon;
    }
}