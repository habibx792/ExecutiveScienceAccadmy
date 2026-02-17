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
            Search = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Search);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(270, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 125);
            panel1.TabIndex = 1;
            // 
            // Search
            // 
            Search.Location = new Point(280, 64);
            Search.Name = "Search";
            Search.Size = new Size(75, 33);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(504, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(755, 150);
            dataGridView1.TabIndex = 2;
            // 
            // FeeSubMission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 794);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FeeSubMission";
            Text = "FeeSubMission";
            Load += FeeSubMission_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button Search;
        private DataGridView dataGridView1;
    }
}