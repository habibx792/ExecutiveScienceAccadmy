namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class Defulter
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
            button1 = new Button();
            dtDefaulter = new DataGridView();
            pnLogo = new Panel();
            lbLogo = new Label();
            panel1 = new Panel();
            btnDef = new Button();
            label2 = new Label();
            cmbMonth = new ComboBox();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtDefaulter).BeginInit();
            pnLogo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1263, 762);
            button1.Name = "button1";
            button1.Size = new Size(123, 64);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtDefaulter
            // 
            dtDefaulter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDefaulter.Location = new Point(30, 158);
            dtDefaulter.Name = "dtDefaulter";
            dtDefaulter.RowHeadersWidth = 51;
            dtDefaulter.Size = new Size(758, 325);
            dtDefaulter.TabIndex = 2;
            dtDefaulter.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(30, 53);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(758, 63);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.FromArgb(0, 70, 140);
            lbLogo.Location = new Point(213, 10);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(297, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Defaulter Student List";
            lbLogo.Click += lbLogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnDef);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbMonth);
            panel1.Location = new Point(30, 116);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 50);
            panel1.TabIndex = 10;
            // 
            // btnDef
            // 
            btnDef.BackColor = SystemColors.Highlight;
            btnDef.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDef.ForeColor = Color.White;
            btnDef.Location = new Point(521, 2);
            btnDef.Margin = new Padding(2);
            btnDef.Name = "btnDef";
            btnDef.Size = new Size(124, 46);
            btnDef.TabIndex = 11;
            btnDef.Text = "Search";
            btnDef.UseVisualStyleBackColor = false;
            btnDef.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 11);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(160, 12);
            cmbMonth.Margin = new Padding(2);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(319, 25);
            cmbMonth.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(30, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 58);
            panel2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 70, 140);
            label6.Location = new Point(172, 7);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Defulter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(835, 492);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Controls.Add(button1);
            Controls.Add(dtDefaulter);
            Name = "Defulter";
            Text = "Defulter";
            Load += Defulter_Load;
            ((System.ComponentModel.ISupportInitialize)dtDefaulter).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dtDefaulter;
        private Panel pnLogo;
        private Label lbLogo;
        private Panel panel1;
        private ComboBox cmbMonth;
        private Label label2;
        private Button btnDef;
        private Panel panel2;
        private Label label6;
    }
}