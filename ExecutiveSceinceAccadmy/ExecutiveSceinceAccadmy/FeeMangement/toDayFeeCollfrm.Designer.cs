namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class toDayFeeCollfrm
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
            lbLogo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(52, 28);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 1;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 191);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 2;
            label1.Text = "Total Collection Of Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 191);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 254);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 254);
            label4.Name = "label4";
            label4.Size = new Size(184, 23);
            label4.TabIndex = 4;
            label4.Text = "Total Collection Of Day";
            // 
            // toDayFeeCollfrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(798, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbLogo);
            Name = "toDayFeeCollfrm";
            Text = "toDayFeeCollfrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}