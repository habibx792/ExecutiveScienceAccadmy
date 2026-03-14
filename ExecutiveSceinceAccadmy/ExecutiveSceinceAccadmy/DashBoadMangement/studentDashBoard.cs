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
    public partial class studentDashBoard : Form
    {

        public studentDashBoard()
        {

            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            UI.Instance.AddFormShadow(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       

        private void DashBoardForm_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbRollNo_TextChanged(object sender, EventArgs e)
        {
            //tbRollNo.Height = 40;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picBox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
