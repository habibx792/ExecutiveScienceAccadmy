namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class DashBoardForm
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
            picBox = new PictureBox();
            lblRollNo = new Label();
            tbRollNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(630, 9);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(264, 37);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Student DashBoard";
            // 
            // picBox
            // 
            picBox.BackColor = SystemColors.ActiveCaption;
            picBox.Location = new Point(1219, 45);
            picBox.Name = "picBox";
            picBox.Size = new Size(127, 133);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += pictureBox1_Click;
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRollNo.Location = new Point(12, 61);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(96, 30);
            lblRollNo.TabIndex = 2;
            lblRollNo.Text = "Roll NO:";
            lblRollNo.Click += label1_Click;
            // 
            // tbRollNo
            // 
            tbRollNo.BackColor = Color.Silver;
            tbRollNo.Location = new Point(138, 68);
            tbRollNo.Name = "tbRollNo";
            tbRollNo.Size = new Size(319, 23);
            tbRollNo.TabIndex = 3;
            tbRollNo.TextChanged += tbRollNo_TextChanged;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 648);
            Controls.Add(tbRollNo);
            Controls.Add(lblRollNo);
            Controls.Add(picBox);
            Controls.Add(lbLogo);
            Name = "DashBoardForm";
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogo;
        private PictureBox picBox;
        private Label lblRollNo;
        private TextBox tbRollNo;
    }
}