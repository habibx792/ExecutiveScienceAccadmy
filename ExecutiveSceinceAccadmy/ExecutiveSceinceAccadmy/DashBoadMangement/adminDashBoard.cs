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
    }
}
