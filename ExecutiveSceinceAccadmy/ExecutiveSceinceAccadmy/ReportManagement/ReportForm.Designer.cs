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
            btnMark = new Button();
            btnRts = new Button();
            btnSum = new Button();
            btnUpAtt = new Button();
            btnSujectWise = new Button();
            btnDashBoad = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnMark);
            pnMain.Controls.Add(btnRts);
            pnMain.Controls.Add(btnSum);
            pnMain.Controls.Add(btnUpAtt);
            pnMain.Controls.Add(btnSujectWise);
            pnMain.Controls.Add(btnDashBoad);
            pnMain.Location = new Point(220, 186);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(984, 391);
            pnMain.TabIndex = 28;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(44, 41);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(229, 130);
            btnMark.TabIndex = 24;
            btnMark.Text = "Class Wise";
            btnMark.UseVisualStyleBackColor = true;
            // 
            // btnRts
            // 
            btnRts.Location = new Point(587, 41);
            btnRts.Name = "btnRts";
            btnRts.Size = new Size(237, 130);
            btnRts.TabIndex = 25;
            btnRts.Text = "RTC Class Wise";
            btnRts.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(44, 234);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(229, 130);
            btnSum.TabIndex = 21;
            btnSum.Text = "Show Summary";
            btnSum.UseVisualStyleBackColor = true;
            // 
            // btnUpAtt
            // 
            btnUpAtt.Location = new Point(314, 234);
            btnUpAtt.Name = "btnUpAtt";
            btnUpAtt.Size = new Size(231, 130);
            btnUpAtt.TabIndex = 23;
            btnUpAtt.Text = "Update Attedance";
            btnUpAtt.UseVisualStyleBackColor = true;
            // 
            // btnSujectWise
            // 
            btnSujectWise.Location = new Point(324, 41);
            btnSujectWise.Name = "btnSujectWise";
            btnSujectWise.Size = new Size(221, 130);
            btnSujectWise.TabIndex = 20;
            btnSujectWise.Text = "Suject Wise";
            btnSujectWise.UseVisualStyleBackColor = true;
            // 
            // btnDashBoad
            // 
            btnDashBoad.Location = new Point(587, 234);
            btnDashBoad.Name = "btnDashBoad";
            btnDashBoad.Size = new Size(237, 130);
            btnDashBoad.TabIndex = 22;
            btnDashBoad.Text = "Attendance DashBoard";
            btnDashBoad.UseVisualStyleBackColor = true;
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
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnMark;
        private Button btnRts;
        private Button btnSum;
        private Button btnUpAtt;
        private Button btnSujectWise;
        private Button btnDashBoad;
        private Panel pnLogo;
        private Label lbLogo;
    }
}