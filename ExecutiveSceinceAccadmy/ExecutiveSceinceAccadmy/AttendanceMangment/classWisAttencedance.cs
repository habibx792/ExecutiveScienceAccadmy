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
    public partial class classWisAttencedance : Form
    {
        public classWisAttencedance()
        {
            InitializeComponent();
            cmbAttendance.SelectedIndexChanged += cmbAttendance_SelectedIndexChanged;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setAttendanceTypes()
        {
            cmbAttendance.Items.Clear();
            cmbAttendance.Items.Add("Regular");
            cmbAttendance.Items.Add("RTS");

            cmbAttendance.SelectedIndex = 0;
        }
        private void setClassOnBaseOfAttendanceType(int start = 1, int end = 12)
        {
            cmbClass.Items.Clear();

            for (int i = start; i <= end; i++)
            {
                if (i <= 8)
                    cmbClass.Items.Add(i.ToString());
                else
                    cmbClass.Items.Add(i);
            }

            if (cmbClass.Items.Count > 0)
                cmbClass.SelectedIndex = 0;
        }
        private void classWisAttencedance_Load(object sender, EventArgs e)
        {
            setAttendanceTypes();
        }
        private void cmbAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAttendance.SelectedItem == null)
                return;

            if (cmbAttendance.SelectedItem.ToString() == "Regular")
            {
                setClassOnBaseOfAttendanceType(1, 12);
            }
            else if (cmbAttendance.SelectedItem.ToString() == "RTS")
            {
                setClassOnBaseOfAttendanceType(9, 12);
            }
        }

    }
}
