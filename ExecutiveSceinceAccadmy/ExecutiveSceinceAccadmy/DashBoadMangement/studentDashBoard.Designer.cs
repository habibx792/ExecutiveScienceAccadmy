namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class studentDashBoard
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
            picBox = new PictureBox();
            panel2 = new Panel();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            btnRegisMange = new Button();
            pnLogo = new Panel();
            lbLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            panel2.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.BackColor = SystemColors.ActiveCaption;
            picBox.Location = new Point(1567, 69);
            picBox.Margin = new Padding(4, 5, 4, 5);
            picBox.Name = "picBox";
            picBox.Size = new Size(163, 204);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Location = new Point(69, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 427);
            panel2.TabIndex = 17;
            // 
            // btnFeeMange
            // 
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(154, 34);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(289, 92);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "Check Result";
            btnFeeMange.UseVisualStyleBackColor = true;
            // 
            // btnAttendMange
            // 
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(154, 295);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(289, 92);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Check Attendance";
            btnAttendMange.UseVisualStyleBackColor = true;
            btnAttendMange.Click += btnAttendMange_Click;
            // 
            // btnRegisMange
            // 
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(154, 164);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(289, 92);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "Check Fee Records";
            btnRegisMange.UseVisualStyleBackColor = true;
            btnRegisMange.Click += btnRegisMange_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(lbLogo);
            pnLogo.Location = new Point(69, 35);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(576, 123);
            pnLogo.TabIndex = 19;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.ForeColor = Color.Black;
            lbLogo.Location = new Point(34, 39);
            lbLogo.Margin = new Padding(4, 0, 4, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(537, 54);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Executive Science Academy";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(732, 615);
            Controls.Add(pnLogo);
            Controls.Add(panel2);
            Controls.Add(picBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "studentDashBoard";
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            panel2.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picBox;
        private Panel panel2;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Button btnRegisMange;
        private Panel pnLogo;
        private Label lbLogo;
    }
}