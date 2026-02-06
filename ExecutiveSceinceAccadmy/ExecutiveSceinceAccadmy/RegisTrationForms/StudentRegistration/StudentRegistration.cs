using ExecutiveSceinceAccadmy.RegisTrationForms.StudentRegistration;
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
          
        {
            
            UI.Instance.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StyleButton(btnStdReg, borderRadius: 20);
            UI.Instance.StyleButton(BtnFeeSub, borderRadius: 20);
                UI.Instance.StyleButton(btnPrimaryReg, borderRadius: 20);
                UI.Instance.StyleButton(btnSupReg, borderRadius: 20);
                UI.Instance.StylePanel(pnMain,
               backColor: Color.White,
               borderColor: Color.FromArgb(0, 120, 215),
               borderRadius: 20,
               borderThickness: 2);
                UI.Instance.AddFormShadow(this);
                UI.Instance.setFormSize(this, 1373, 687);
                UI.Instance.AddFormShadow(this);
                UI.Instance.AddFormShadow(this);
            }

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
            this.Hide();
            using (RegisTracionForm stdRegForm = new RegisTracionForm())
            {
                stdRegForm.ShowDialog();
            }

            this.Show();
        }

        private void BtnFeeSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegisTracionForm stdRegForm = new RegisTracionForm())
            {
                stdRegForm.ShowDialog();
            }

            this.Show();


        }

        private void stdBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegisTracionForm stdRegForm = new RegisTracionForm())
            {
                stdRegForm.ShowDialog();
            }

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegisTracionForm stdRegForm = new RegisTracionForm())
            {
                stdRegForm.ShowDialog();
            }

            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
