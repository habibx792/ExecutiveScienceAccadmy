using ExecutiveSceinceAccadmy.AttendanceMangment;
using ExecutiveScienceAcademy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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



            UI.Instance.StyleButton(btnHiring, borderRadius: 20);
            UI.Instance.AddFormShadow(this);

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
            using (HireingForm hireForm = new HireingForm())
            {
                hireForm.ShowDialog();
            }
            this.Show();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(TeacheraAttendance teachAttend=new TeacheraAttendance())
            {
                teachAttend.ShowDialog();
            }
            this.Show();
        }
    }
}
