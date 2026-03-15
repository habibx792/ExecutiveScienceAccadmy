namespace ExecutiveSceinceAccadmy.TeacherMangement
{
    partial class TeacherMangementForm
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
            btnAttend = new Button();
            btnHiring = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAttend
            // 
            btnAttend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttend.Location = new Point(47, 48);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(221, 107);
            btnAttend.TabIndex = 7;
            btnAttend.Text = "Teacher Attendance";
            btnAttend.UseVisualStyleBackColor = true;
            btnAttend.Click += btnAttend_Click;
            // 
            // btnHiring
            // 
            btnHiring.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHiring.Location = new Point(47, 179);
            btnHiring.Name = "btnHiring";
            btnHiring.Size = new Size(221, 107);
            btnHiring.TabIndex = 10;
            btnHiring.Text = "Hiring";
            btnHiring.UseVisualStyleBackColor = true;
            btnHiring.Click += btnHiring_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHiring);
            panel1.Controls.Add(btnAttend);
            panel1.Location = new Point(39, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 331);
            panel1.TabIndex = 15;
            // 
            // TeacherMangementForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 401);
            Controls.Add(panel1);
            Name = "TeacherMangementForm";
            Text = "TeacherMangement";
            Load += TeacherMangement_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAttend;
        private Button btnHiring;
        private Panel panel1;
    }
}