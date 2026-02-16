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
            radioButton1 = new RadioButton();
            rdArrival = new RadioButton();
            btnTeachAttence = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(349, 108);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Departure";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdArrival
            // 
            rdArrival.AutoSize = true;
            rdArrival.Location = new Point(91, 108);
            rdArrival.Name = "rdArrival";
            rdArrival.Size = new Size(89, 19);
            rdArrival.TabIndex = 1;
            rdArrival.TabStop = true;
            rdArrival.Text = "Arrival Time";
            rdArrival.UseVisualStyleBackColor = true;
            // 
            // btnTeachAttence
            // 
            btnTeachAttence.Location = new Point(351, 214);
            btnTeachAttence.Name = "btnTeachAttence";
            btnTeachAttence.Size = new Size(75, 31);
            btnTeachAttence.TabIndex = 2;
            btnTeachAttence.Text = "Mark";
            btnTeachAttence.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ghulam Habib" });
            comboBox1.Location = new Point(91, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 23);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // TeacheraAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 345);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(btnTeachAttence);
            Controls.Add(rdArrival);
            Controls.Add(radioButton1);
            Name = "TeacheraAttendance";
            Text = "TeacheraAttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton rdArrival;
        private Button btnTeachAttence;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}