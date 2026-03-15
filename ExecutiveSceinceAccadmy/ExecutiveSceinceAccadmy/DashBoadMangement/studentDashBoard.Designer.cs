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
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            panel2.SuspendLayout();
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
            panel2.Location = new Point(36, 42);
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
            // studentDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 504);
            Controls.Add(panel2);
            Controls.Add(picBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "studentDashBoard";
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picBox;
        private Panel panel2;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Button btnRegisMange;
    }
}