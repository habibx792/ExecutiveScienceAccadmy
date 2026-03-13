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
            lbLogo = new Label();
            pnLogo = new Panel();
            lblMont = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
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
            panel1.Location = new Point(32, 71);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 519);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 46);
            label2.TabIndex = 3;
            label2.Text = "Fee Submission";
            label2.Click += label2_Click;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(420, 260);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(427, 36);
            cmbMonth.TabIndex = 39;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 390);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 38;
            label5.Text = "Submitted By:";
            // 
            // txtSubBy
            // 
            txtSubBy.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txtSubBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSubBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubBy.Location = new Point(420, 383);
            txtSubBy.Margin = new Padding(4, 5, 4, 5);
            txtSubBy.Name = "txtSubBy";
            txtSubBy.PlaceholderText = "Enter Discount";
            txtSubBy.Size = new Size(427, 30);
            txtSubBy.TabIndex = 37;
            txtSubBy.Text = "Muhammd Shahid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(253, 315);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 36;
            label4.Text = "Discont";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 35;
            label3.Text = "Amount";
            // 
            // txtPercentage
            // 
            txtPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPercentage.Location = new Point(606, 315);
            txtPercentage.Margin = new Padding(4, 5, 4, 5);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.ReadOnly = true;
            txtPercentage.Size = new Size(241, 34);
            txtPercentage.TabIndex = 34;
            txtPercentage.Text = "0";
            // 
            // txtDicount
            // 
            txtDicount.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txtDicount.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDicount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDicount.Location = new Point(420, 315);
            txtDicount.Margin = new Padding(4, 5, 4, 5);
            txtDicount.Name = "txtDicount";
            txtDicount.PlaceholderText = "Enter Discount";
            txtDicount.Size = new Size(178, 34);
            txtDicount.TabIndex = 33;
            txtDicount.Text = "0";
            txtDicount.TextChanged += textBox2_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(420, 222);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter Amount";
            txtAmount.Size = new Size(427, 34);
            txtAmount.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 31;
            label1.Text = "Date :";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeg.Location = new Point(253, 147);
            lblDeg.Margin = new Padding(4, 0, 4, 0);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(139, 23);
            lblDeg.TabIndex = 30;
            lblDeg.Text = "Registraion No :";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(707, 437);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 63);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += Search_Click;
            // 
            // dtPick
            // 
            dtPick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtPick.Location = new Point(420, 69);
            dtPick.Margin = new Padding(4, 5, 4, 5);
            dtPick.Name = "dtPick";
            dtPick.Size = new Size(427, 34);
            dtPick.TabIndex = 3;
            dtPick.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtRegis
            // 
            txtRegis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegis.Location = new Point(420, 145);
            txtRegis.Margin = new Padding(4, 5, 4, 5);
            txtRegis.Name = "txtRegis";
            txtRegis.PlaceholderText = "26-10-comp-00";
            txtRegis.Size = new Size(427, 34);
            txtRegis.TabIndex = 4;
            txtRegis.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.Salmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 587);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1110, 180);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(263, 20);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(653, 46);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            lbLogo.Click += lbLogo_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Location = new Point(32, 71);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1110, 696);
            pnLogo.TabIndex = 26;
            pnLogo.Paint += pnLogo_Paint;
            // 
            // lblMont
            // 
            lblMont.AutoSize = true;
            lblMont.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMont.Location = new Point(258, 260);
            lblMont.Margin = new Padding(4, 0, 4, 0);
            lblMont.Name = "lblMont";
            lblMont.Size = new Size(63, 23);
            lblMont.TabIndex = 40;
            lblMont.Text = "Month";
            // 
            // FeeSubMission
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1184, 782);
            Controls.Add(dataGridView1);
            Controls.Add(lbLogo);
            Controls.Add(panel1);
            Controls.Add(pnLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FeeSubMission";
            Text = "FeeSubMission";
            Load += FeeSubMission_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dtPick;
        private TextBox txtRegis;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lbLogo;
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
    }
}