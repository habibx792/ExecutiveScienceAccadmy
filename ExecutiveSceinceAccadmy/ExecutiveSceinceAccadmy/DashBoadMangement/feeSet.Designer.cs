namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class feeSet
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            cmbDomain = new ComboBox();
            cmbClass = new ComboBox();
            txtAmount = new TextBox();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel1.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbDomain);
            panel1.Controls.Add(cmbClass);
            panel1.Controls.Add(txtAmount);
            panel1.Location = new Point(17, 97);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 222);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 67);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 8;
            label5.Text = "Domain";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Class";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(328, 154);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 1;
            button1.Text = "Set Fee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbDomain
            // 
            cmbDomain.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Location = new Point(202, 65);
            cmbDomain.Margin = new Padding(2);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(252, 25);
            cmbDomain.TabIndex = 4;
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(202, 31);
            cmbClass.Margin = new Padding(2);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(252, 25);
            cmbClass.TabIndex = 0;
            cmbClass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtAmount.Location = new Point(202, 113);
            txtAmount.Margin = new Padding(2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(252, 25);
            txtAmount.TabIndex = 3;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(17, 18);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(493, 80);
            pnLogo.TabIndex = 19;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(26, 25);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(426, 45);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // feeSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(532, 337);
            Controls.Add(pnLogo);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "feeSet";
            Text = "feeSet";
            Load += feeSet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbClass;
        private Button button1;
        private Label label1;
        private TextBox txtAmount;
        private Label label5;
        private Label label4;
        private ComboBox cmbDomain;
        private Panel pnLogo;
        private Label lbLogo;
    }
}