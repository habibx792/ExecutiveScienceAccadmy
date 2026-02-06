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

namespace ExecutiveSceinceAccadmy.RegisTrationForms.StudentRegistration
{
    public partial class RegisTracionForm : Form
    {
        public RegisTracionForm()
        {
            InitializeComponent();
           
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void StyleControls()
        {

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StylePanel(pnAccadminc, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StylePanel(pnMainPn, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StylePanel(pnPerMain, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StylePanel(pnPreq, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StylePanel(pnPerMain, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StyleTextBox(
            txtBoard,
            focusedBorderColor: Color.DodgerBlue,
             height: 42
            );
            UI.Instance.StyleTextBox(
            txtDeg,
            focusedBorderColor: Color.DodgerBlue,
             height: 42
            );
            UI.Instance.StyleTextBox(txtDeg, focusedBorderColor: Color.DodgerBlue,
         height: 42);
                UI.Instance.StyleTextBox(txtDegYear, focusedBorderColor: Color.DodgerBlue, height: 42);







            lbLogo.Font = new Font(lbLogo.Font, FontStyle.Bold);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisTracionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
