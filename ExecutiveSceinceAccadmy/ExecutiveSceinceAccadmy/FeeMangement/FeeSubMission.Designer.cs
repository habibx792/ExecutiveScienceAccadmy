namespace ExecutiveSceinceAccadmy.FeeMangement
{
    partial class FeeSubMission
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
            lblMont = new Label();
            label2 = new Label();
            cmbMonth = new ComboBox();
            label5 = new Label();
            txtSubBy = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtPercentage = new TextBox();
            txtDicount = new TextBox();
            txtAmount = new TextBox();
            label1 = new Label();
            lblDeg = new Label();
            btnSearch = new Button();
            dtPick = new DateTimePicker();
            txtRegis = new TextBox();
            dataGridView1 = new DataGridView();
            pnLogo = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(lblMont);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbMonth);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSubBy);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPercentage);
            panel1.Controls.Add(txtDicount);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDeg);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(dtPick);
            panel1.Controls.Add(txtRegis);
            panel1.Location = new Point(25, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 400);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblMont
            // 
            lblMont.AutoSize = true;
            lblMont.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMont.Location = new Point(181, 224);
            lblMont.Name = "lblMont";
            lblMont.Size = new Size(49, 17);
            lblMont.TabIndex = 40;
            lblMont.Text = "Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 70, 140);
            label2.Location = new Point(316, 42);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 3;
            label2.Text = "Fee Submission";
            label2.Click += label2_Click;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(307, 224);
            cmbMonth.Margin = new Padding(2);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(333, 29);
            cmbMonth.TabIndex = 39;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(181, 308);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 38;
            label5.Text = "Submitted By:";
            // 
            // txtSubBy
            // 
            txtSubBy.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txtSubBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSubBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubBy.Location = new Point(307, 304);
            txtSubBy.Name = "txtSubBy";
            txtSubBy.PlaceholderText = "Enter Discount";
            txtSubBy.Size = new Size(333, 26);
            txtSubBy.TabIndex = 37;
            txtSubBy.Text = "Muhammd Shahid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 259);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 36;
            label4.Text = "Discont";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 190);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 35;
            label3.Text = "Amount";
            // 
            // txtPercentage
            // 
            txtPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPercentage.Location = new Point(451, 259);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.ReadOnly = true;
            txtPercentage.Size = new Size(188, 29);
            txtPercentage.TabIndex = 34;
            txtPercentage.Text = "0";
            // 
            // txtDicount
            // 
            txtDicount.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txtDicount.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDicount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDicount.Location = new Point(307, 259);
            txtDicount.Name = "txtDicount";
            txtDicount.PlaceholderText = "Enter Discount";
            txtDicount.Size = new Size(139, 29);
            txtDicount.TabIndex = 33;
            txtDicount.Text = "0";
            txtDicount.TextChanged += textBox2_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(307, 184);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter Amount";
            txtAmount.Size = new Size(333, 29);
            txtAmount.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 105);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 31;
            label1.Text = "Date :";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeg.Location = new Point(177, 150);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(108, 17);
            lblDeg.TabIndex = 30;
            lblDeg.Text = "Registraion No :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(530, 339);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += Search_Click;
            // 
            // dtPick
            // 
            dtPick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtPick.Location = new Point(307, 99);
            dtPick.Name = "dtPick";
            dtPick.Size = new Size(333, 29);
            dtPick.TabIndex = 3;
            dtPick.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtRegis
            // 
            txtRegis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegis.Location = new Point(307, 149);
            txtRegis.Name = "txtRegis";
            txtRegis.PlaceholderText = "26-10-comp-00";
            txtRegis.Size = new Size(333, 29);
            txtRegis.TabIndex = 4;
            txtRegis.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 398);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(863, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(dataGridView1);
            pnLogo.Location = new Point(25, 46);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(863, 548);
            pnLogo.TabIndex = 26;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(25, 7);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 79);
            panel2.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 70, 140);
            label6.Location = new Point(223, 7);
            label6.Name = "label6";
            label6.Size = new Size(426, 45);
            label6.TabIndex = 28;
            label6.Text = "Executive Science Academy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeeSubMission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(921, 606);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Name = "FeeSubMission";
            Text = "FeeSubMission";
            Load += FeeSubMission_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dtPick;
        private TextBox txtRegis;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lblDeg;
        private Label label1;
        private Label label2;
        private TextBox txtPercentage;
        private TextBox txtDicount;
        private TextBox txtAmount;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtSubBy;
        private ComboBox cmbMonth;
        private Panel pnLogo;
        private Label lblMont;
        private Panel panel2;
        private Label label6;
    }
}