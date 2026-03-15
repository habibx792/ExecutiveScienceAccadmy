using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class TeacheraAttendance : Form
    {
        public TeacheraAttendance()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;
        }
        private void StyleControls()
        {


            UI.Instance.StyleButton(btnTeachAttence, borderRadius: 20);
            UI.Instance.AddFormShadow(this);
        }
        private void TeacheraAttendance_Load(object sender, EventArgs e)
        {
            List<string> teachers = DB.GetAllTeacherNames();
            foreach (string teacher in teachers)
            {
                cmbTeaches.Items.Add(teacher);
            }
            cmbTeaches.SelectedIndex = 0;
        }

        private void btnTeachAttence_Click(object sender, EventArgs e)
        {
            if (cmbTeaches.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a teacher.");
                return;
            }

            string teacherName = cmbTeaches.SelectedItem.ToString();
            string teacherId = DB.GetTeacherIdByName(teacherName);
            if (teacherId == null)
            {
                MessageBox.Show("Teacher Does Not exit");
            }



            bool arrival = rdArrival.Checked;

            DateTime date = DateTime.Now.Date;
            DateTime time = DateTime.Now;

            bool success = DB.markTeacherAttendance(teacherId, arrival, date, time);

            if (success)
                MessageBox.Show("Attendance marked successfully");
            else
                if (rdDept.Checked)
            {
                MessageBox.Show("Plese mark arrival first");
            }
            MessageBox.Show("Arrival already marked today");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
