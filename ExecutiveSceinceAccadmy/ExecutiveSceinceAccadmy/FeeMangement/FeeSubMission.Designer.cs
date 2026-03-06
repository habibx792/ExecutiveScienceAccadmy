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
            label1 = new Label();
            lblDeg = new Label();
            Search = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtRegis = new TextBox();
            dataGridView1 = new DataGridView();
            pnLogo = new Panel();
            label2 = new Label();
            lbLogo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDeg);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtRegis);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 190);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 45);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 31;
            label1.Text = "Date :";
            // 
            // lblDeg
            // 
            lblDeg.AutoSize = true;
            lblDeg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeg.Location = new Point(261, 90);
            lblDeg.Name = "lblDeg";
            lblDeg.Size = new Size(108, 17);
            lblDeg.TabIndex = 30;
            lblDeg.Text = "Registraion No :";
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(615, 118);
            Search.Name = "Search";
            Search.Size = new Size(109, 41);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(391, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtRegis
            // 
            txtRegis.Location = new Point(391, 89);
            txtRegis.Name = "txtRegis";
            txtRegis.Size = new Size(333, 23);
            txtRegis.TabIndex = 4;
            txtRegis.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.Salmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(948, 349);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label2);
            pnLogo.Controls.Add(dataGridView1);
            pnLogo.Controls.Add(panel1);
            pnLogo.Location = new Point(348, 138);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(948, 596);
            pnLogo.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 12);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 3;
            label2.Text = "Fee Submission";
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(435, 39);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(529, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Welcome To Executive Sceince Accadmy";
            // 
            // FeeSubMission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1441, 794);
            Controls.Add(lbLogo);
            Controls.Add(pnLogo);
            Name = "FeeSubMission";
            Text = "FeeSubMission";
            Load += FeeSubMission_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtRegis;
        private Button Search;
        private DataGridView dataGridView1;
        private Panel pnLogo;
        private Label lbLogo;
        private Label lblDeg;
        private Label label1;
        private Label label2;
    }
}