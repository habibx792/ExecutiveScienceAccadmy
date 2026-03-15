using ExecutiveSceinceAccadmy.AttendanceMangment;
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
                backgroundColor: Color.RoyalBlue,
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            UI.Instance.AddFormShadow(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void teacherDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnAttendMange_Click(object sender, EventArgs e)
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
