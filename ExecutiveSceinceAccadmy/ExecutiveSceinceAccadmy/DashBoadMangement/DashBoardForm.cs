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

namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
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

            //UI.Instance.MakeTextBoxModern(tbRollNo);

            //UI.Instance.StylePanel(pnLogo,
            //    backColor: Color.White,
            //    borderColor: Color.FromArgb(0, 120, 215),
            //    borderRadius: 20,
            //    borderThickness: 2);
            // UI.Instance.StyleButton(btnStdReg, borderRadius: 20);
            // UI.Instance.StyleButton(BtnFeeSub, borderRadius: 20);
            // UI.Instance.StyleButton(btnPrimaryReg, borderRadius: 20);
            // UI.Instance.StyleButton(btnSupReg, borderRadius: 20);
            // UI.Instance.StylePanel(pnMain,
            //backColor: Color.White,
            //borderColor: Color.FromArgb(0, 120, 215),
            //borderRadius: 20,
            //borderThickness: 2);
            UI.Instance.AddFormShadow(this);
           
            UI.Instance.setFormSize(this, 1373, 687);


        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbRollNo_TextChanged(object sender, EventArgs e)
        {
            tbRollNo.Height = 40;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picBox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
