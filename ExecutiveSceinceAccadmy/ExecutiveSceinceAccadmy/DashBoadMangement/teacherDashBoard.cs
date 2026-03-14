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
    public partial class teacherDashBoard : Form
    {
        public teacherDashBoard()
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

        private void teacherDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
