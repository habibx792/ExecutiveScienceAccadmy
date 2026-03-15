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
            button2 = new Button();
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
            button1.Location = new Point(1624, 1168);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(158, 98);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtDefaulter
            // 
            dtDefaulter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDefaulter.Location = new Point(39, 235);
            dtDefaulter.Margin = new Padding(4, 5, 4, 5);
            dtDefaulter.Name = "dtDefaulter";
            dtDefaulter.RowHeadersWidth = 51;
            dtDefaulter.Size = new Size(975, 506);
            dtDefaulter.TabIndex = 2;
            dtDefaulter.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(39, 81);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(975, 97);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(305, 34);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(368, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Defaulter Student List";
            lbLogo.Click += lbLogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbMonth);
            panel1.Location = new Point(39, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 57);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(670, 3);
            button2.Name = "button2";
            button2.Size = new Size(159, 46);
            button2.TabIndex = 11;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(196, 8);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(409, 36);
            cmbMonth.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(39, 22);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(975, 71);
            panel2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(238, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(537, 54);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Defulter
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1074, 755);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Controls.Add(button1);
            Controls.Add(dtDefaulter);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button2;
        private Panel panel2;
        private Label label6;
    }
}