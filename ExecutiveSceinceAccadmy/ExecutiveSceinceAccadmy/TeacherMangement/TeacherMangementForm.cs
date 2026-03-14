using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.TeacherMangement
{
    public partial class TeacherMangementForm : Form
    {
        public TeacherMangementForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TeacherMangement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHiring_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(HireingForm hireForm=new HireingForm())
            {
                hireForm.ShowDialog();
            }
            this.Show();
        }
    }
}
