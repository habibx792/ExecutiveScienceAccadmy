using ExecutiveScienceAcademy.classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.studentRegistrationForms
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();

            Load += StudentRegistration_Load;

            UI.Instance.StyleForm(
                this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy"
            );

            StyleControls();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StyleControls()
        {
            UI.Instance.AddFormShadow(this);

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            // Runs after form is fully loaded
        }

        private void StudentRegistration_Load_1(object sender, EventArgs e)
        {

        }

        private void btnStdReg_Click(object sender, EventArgs e)
        {

        }

        private void BtnFeeSub_Click(object sender, EventArgs e)
        {

        }

        private void stdBoard_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
