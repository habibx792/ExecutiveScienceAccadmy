using ExecutiveSceinceAccadmy.AttendanceMangment;
using ExecutiveSceinceAccadmy.ExpenseMangenment;
using ExecutiveSceinceAccadmy.FeeMangement;
using ExecutiveSceinceAccadmy.studentRegistrationForms;
using ExecutiveSceinceAccadmy.TeacherMangement;

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

namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    public partial class adminDashBoard : Form
    {
        public adminDashBoard()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
              backgroundColor: Color.FromArgb(245, 245, 245),
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");


            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var feeSetForm = new feeSet())
            {
                feeSetForm.ShowDialog();
            }
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FeeForm feeFormControl = new FeeForm())
            {
                feeFormControl.ShowDialog();
            }
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (attendanceForm attendForm = new attendanceForm())
            {
                attendForm.ShowDialog();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var stdRegForm = new StudentRegistration())
            {
                stdRegForm.ShowDialog();
            }
            this.Show();
        }

        private void adminDashBoard_Load(object sender, EventArgs e)
        {
            UI.Instance.StyleButton(btnAttendMange, borderRadius: 20);
            UI.Instance.StyleButton(btnFeeMange, borderRadius: 20);
            UI.Instance.StyleButton(btnRegisMange, borderRadius: 20);
            UI.Instance.StyleButton(btnFeeSet, borderRadius: 20);
            UI.Instance.StyleButton(btnExpenseMange, borderRadius: 20);




        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ExpenseForm expenseMange = new ExpenseForm())
            {
                expenseMange.ShowDialog();
            }
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(TeacherMangementForm teachMangeFor= new TeacherMangementForm())
            {
                teachMangeFor.ShowDialog();
            }
            this.Show();
        }
    }
}
