namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    partial class teacherDashBoard
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
            panel2 = new Panel();
            btnFeeMange = new Button();
            btnAttendMange = new Button();
            btnRegisMange = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnFeeMange);
            panel2.Controls.Add(btnAttendMange);
            panel2.Controls.Add(btnRegisMange);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 439);
            panel2.TabIndex = 17;
            // 
            // btnFeeMange
            // 
            btnFeeMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFeeMange.Location = new Point(113, 168);
            btnFeeMange.Name = "btnFeeMange";
            btnFeeMange.Size = new Size(289, 92);
            btnFeeMange.TabIndex = 12;
            btnFeeMange.Text = "View Fee/Salary Collection";
            btnFeeMange.UseVisualStyleBackColor = true;
            // 
            // btnAttendMange
            // 
            btnAttendMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAttendMange.Location = new Point(113, 50);
            btnAttendMange.Name = "btnAttendMange";
            btnAttendMange.Size = new Size(289, 92);
            btnAttendMange.TabIndex = 8;
            btnAttendMange.Text = "Mark Attendance";
            btnAttendMange.UseVisualStyleBackColor = true;
            // 
            // btnRegisMange
            // 
            btnRegisMange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegisMange.Location = new Point(113, 287);
            btnRegisMange.Name = "btnRegisMange";
            btnRegisMange.Size = new Size(289, 92);
            btnRegisMange.TabIndex = 1;
            btnRegisMange.Text = "View Subject Collection";
            btnRegisMange.UseVisualStyleBackColor = true;
            // 
            // teacherDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 480);
            Controls.Add(panel2);
            Name = "teacherDashBoard";
            Text = "teacherDashBoard";
            Load += teacherDashBoard_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnFeeMange;
        private Button btnAttendMange;
        private Button btnRegisMange;
    }
}