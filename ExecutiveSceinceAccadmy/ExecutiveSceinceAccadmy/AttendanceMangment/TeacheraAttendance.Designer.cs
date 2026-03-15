namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    partial class TeacheraAttendance
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
            rdDept = new RadioButton();
            rdArrival = new RadioButton();
            btnTeachAttence = new Button();
            cmbTeaches = new ComboBox();
            dtTime = new DateTimePicker();
            panel1 = new Panel();
            pnLogo = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            pnLogo.SuspendLayout();
            SuspendLayout();
            // 
            // rdDept
            // 
            rdDept.AutoSize = true;
            rdDept.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdDept.Location = new Point(471, 37);
            rdDept.Margin = new Padding(4, 5, 4, 5);
            rdDept.Name = "rdDept";
            rdDept.Size = new Size(130, 32);
            rdDept.TabIndex = 0;
            rdDept.TabStop = true;
            rdDept.Text = "Departure";
            rdDept.UseVisualStyleBackColor = true;
            // 
            // rdArrival
            // 
            rdArrival.AutoSize = true;
            rdArrival.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdArrival.Location = new Point(149, 49);
            rdArrival.Margin = new Padding(4, 5, 4, 5);
            rdArrival.Name = "rdArrival";
            rdArrival.Size = new Size(150, 32);
            rdArrival.TabIndex = 1;
            rdArrival.TabStop = true;
            rdArrival.Text = "Arrival Time";
            rdArrival.UseVisualStyleBackColor = true;
            // 
            // btnTeachAttence
            // 
            btnTeachAttence.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTeachAttence.Location = new Point(483, 223);
            btnTeachAttence.Margin = new Padding(4, 5, 4, 5);
            btnTeachAttence.Name = "btnTeachAttence";
            btnTeachAttence.Size = new Size(96, 48);
            btnTeachAttence.TabIndex = 2;
            btnTeachAttence.Text = "Mark";
            btnTeachAttence.UseVisualStyleBackColor = true;
            btnTeachAttence.Click += btnTeachAttence_Click;
            // 
            // cmbTeaches
            // 
            cmbTeaches.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbTeaches.FormattingEnabled = true;
            cmbTeaches.Location = new Point(149, 150);
            cmbTeaches.Margin = new Padding(4, 5, 4, 5);
            cmbTeaches.Name = "cmbTeaches";
            cmbTeaches.Size = new Size(430, 36);
            cmbTeaches.TabIndex = 3;
            // 
            // dtTime
            // 
            dtTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtTime.Location = new Point(149, 86);
            dtTime.Margin = new Padding(4, 5, 4, 5);
            dtTime.Name = "dtTime";
            dtTime.Size = new Size(430, 34);
            dtTime.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(dtTime);
            panel1.Controls.Add(rdDept);
            panel1.Controls.Add(cmbTeaches);
            panel1.Controls.Add(rdArrival);
            panel1.Controls.Add(btnTeachAttence);
            panel1.Location = new Point(27, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 397);
            panel1.TabIndex = 5;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.IndianRed;
            pnLogo.Controls.Add(label1);
            pnLogo.Location = new Point(27, 26);
            pnLogo.Margin = new Padding(4, 5, 4, 5);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(717, 103);
            pnLogo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(537, 54);
            label1.TabIndex = 15;
            label1.Text = "Executive Science Academy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TeacheraAttendance
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(772, 546);
            Controls.Add(pnLogo);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TeacheraAttendance";
            Text = "TeacheraAttendance";
            Load += TeacheraAttendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdDept;
        private RadioButton rdArrival;
        private Button btnTeachAttence;
        private ComboBox cmbTeaches;
        private DateTimePicker dtTime;
        private Panel panel1;
        private Panel pnLogo;
        private Label label1;
    }
}