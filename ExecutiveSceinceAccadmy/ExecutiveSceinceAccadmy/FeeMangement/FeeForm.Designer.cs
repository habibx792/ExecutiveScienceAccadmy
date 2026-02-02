namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class FeeForm
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
            pnLogo = new Panel();
            lbLogo = new Label();
            pnMain = new Panel();
            label1 = new Label();
            btnSearchFee = new Button();
            btnRts = new Button();
            btnDefault = new Button();
            btnPrimary = new Button();
            btnSupp = new Button();
            btnRegularFee = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(12, 29);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1333, 85);
            pnLogo.TabIndex = 9;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(339, 20);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += lbLogo_Click;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(btnSearchFee);
            pnMain.Controls.Add(btnRts);
            pnMain.Controls.Add(btnDefault);
            pnMain.Controls.Add(btnPrimary);
            pnMain.Controls.Add(btnSupp);
            pnMain.Controls.Add(btnRegularFee);
            pnMain.Location = new Point(67, 151);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1227, 415);
            pnMain.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(544, 84);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 17;
            label1.Text = "Fee Mamgement";
            // 
            // btnSearchFee
            // 
            btnSearchFee.Location = new Point(515, 235);
            btnSearchFee.Name = "btnSearchFee";
            btnSearchFee.Size = new Size(233, 83);
            btnSearchFee.TabIndex = 16;
            btnSearchFee.Text = "Search Fee Recored";
            btnSearchFee.UseVisualStyleBackColor = true;
            // 
            // btnRts
            // 
            btnRts.Location = new Point(515, 137);
            btnRts.Name = "btnRts";
            btnRts.Size = new Size(233, 80);
            btnRts.TabIndex = 15;
            btnRts.Text = "Submit RTS Fee";
            btnRts.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(820, 235);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(226, 83);
            btnDefault.TabIndex = 14;
            btnDefault.Text = "Defualter Student";
            btnDefault.UseVisualStyleBackColor = true;
            // 
            // btnPrimary
            // 
            btnPrimary.Location = new Point(820, 137);
            btnPrimary.Name = "btnPrimary";
            btnPrimary.Size = new Size(226, 80);
            btnPrimary.TabIndex = 13;
            btnPrimary.Text = "Primary Fee Submission";
            btnPrimary.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(191, 235);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(249, 83);
            btnSupp.TabIndex = 12;
            btnSupp.Text = "Supplementary FeeSubmission";
            btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnRegularFee
            // 
            btnRegularFee.Location = new Point(191, 137);
            btnRegularFee.Name = "btnRegularFee";
            btnRegularFee.Size = new Size(249, 80);
            btnRegularFee.TabIndex = 11;
            btnRegularFee.Text = "Submit Regular Fee";
            btnRegularFee.UseVisualStyleBackColor = true;
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 648);
            Controls.Add(pnMain);
            Controls.Add(pnLogo);
            Name = "FeeForm";
            Text = "FeeForm";
            Load += FeeForm_Load;
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogo;
        private Label lbLogo;
        private Panel pnMain;
        private Button btnSearchFee;
        private Button btnRts;
        private Button btnDefault;
        private Button btnPrimary;
        private Button btnSupp;
        private Button btnRegularFee;
        private Label label1;
    }
}