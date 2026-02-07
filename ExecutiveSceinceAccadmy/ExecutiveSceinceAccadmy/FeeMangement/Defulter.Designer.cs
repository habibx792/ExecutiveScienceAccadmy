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
            dataGridView1 = new DataGridView();
            pnLogo = new Panel();
            lbLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnLogo.SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1378, 550);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(88, 12);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(1155, 88);
            pnLogo.TabIndex = 8;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(481, 21);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(297, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Defaulter Student List";
            // 
            // Defulter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 838);
            Controls.Add(pnLogo);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Defulter";
            Text = "Defulter";
            Load += Defulter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Panel pnLogo;
        private Label lbLogo;
    }
}