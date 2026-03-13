using ExecutiveSceinceAccadmy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class AttendanceDashBoard : Form
    {
        public AttendanceDashBoard()
        {
            InitializeComponent();
        }

        private void AttendanceDashBoard_Load(object sender, EventArgs e)
        {
            lblDate.Visible = false;
             lblMonth.Visible = true;
            dataHandler.LoadMonths(cmbMonth);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDay.Checked)
            {
                rdMonth.Checked = false;
                lblMonth.Visible = false;
                lblDate.Visible = true;

            }
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonth.Checked) 
            {
                rdDay.Checked = false;
                lblMonth.Visible = true;
                lblDate.Visible = false;

            }
        }
    }
}
