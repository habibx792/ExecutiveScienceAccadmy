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
            btnDefault = new Button();
            btnRegularFee = new Button();
            btnSearchFee = new Button();
            btnTodayCollection = new Button();
            pnLogo.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(164, 39);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(757, 85);
            pnLogo.TabIndex = 9;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(124, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += lbLogo_Click;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnTodayCollection);
            pnMain.Controls.Add(label1);
            pnMain.Controls.Add(btnSearchFee);
            pnMain.Controls.Add(btnDefault);
            pnMain.Controls.Add(btnRegularFee);
            pnMain.Location = new Point(164, 121);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(757, 415);
            pnMain.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 60);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 17;
            label1.Text = "Fee Mamgement";
            // 
            // btnDefault
            // 
            btnDefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDefault.Location = new Point(103, 230);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(249, 83);
            btnDefault.TabIndex = 14;
            btnDefault.Text = "Defualter Student";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // btnRegularFee
            // 
            btnRegularFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegularFee.Location = new Point(103, 128);
            btnRegularFee.Name = "btnRegularFee";
            btnRegularFee.Size = new Size(249, 80);
            btnRegularFee.TabIndex = 11;
            btnRegularFee.Text = "Submit Fee";
            btnRegularFee.UseVisualStyleBackColor = true;
            btnRegularFee.Click += btnRegularFee_Click;
            // 
            // btnSearchFee
            // 
            btnSearchFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchFee.Location = new Point(420, 125);
            btnSearchFee.Name = "btnSearchFee";
            btnSearchFee.Size = new Size(233, 83);
            btnSearchFee.TabIndex = 16;
            btnSearchFee.Text = "Search Fee Recored";
            btnSearchFee.UseVisualStyleBackColor = true;
            btnSearchFee.Click += btnSearchFee_Click;
            // 
            // btnTodayCollection
            // 
            btnTodayCollection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTodayCollection.Location = new Point(420, 230);
            btnTodayCollection.Name = "btnTodayCollection";
            btnTodayCollection.Size = new Size(233, 83);
            btnTodayCollection.TabIndex = 18;
            btnTodayCollection.Text = "Fee Collection Of Day";
            btnTodayCollection.UseVisualStyleBackColor = true;
            btnTodayCollection.Click += button1_Click;
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1147, 648);
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
        private Button btnDefault;
        private Button btnRegularFee;
        private Label label1;
        private Button btnSearchFee;
        private Button btnTodayCollection;
    }
}