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
            panel1.SuspendLayout();
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
            panel1.Location = new Point(39, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 341);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 102);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 8;
            label5.Text = "Domain";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 181);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 2;
            label1.Text = "Class";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(422, 236);
            button1.Name = "button1";
            button1.Size = new Size(161, 69);
            button1.TabIndex = 1;
            button1.Text = "Set Fee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbDomain
            // 
            cmbDomain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbDomain.FormattingEnabled = true;
            cmbDomain.Location = new Point(260, 99);
            cmbDomain.Name = "cmbDomain";
            cmbDomain.Size = new Size(323, 36);
            cmbDomain.TabIndex = 4;
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(260, 47);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(323, 36);
            cmbClass.TabIndex = 0;
            cmbClass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAmount.Location = new Point(260, 174);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(323, 34);
            txtAmount.TabIndex = 3;
            // 
            // feeSet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 406);
            Controls.Add(panel1);
            Name = "feeSet";
            Text = "feeSet";
            Load += feeSet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}