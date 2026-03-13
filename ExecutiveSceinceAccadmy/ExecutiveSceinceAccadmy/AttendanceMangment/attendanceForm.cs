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

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class attendanceForm : Form
    {

        public attendanceForm()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");

            StyleControls();
            UI.Instance.StyleButton(btnDashBoad, borderRadius: 20);
            UI.Instance.StyleButton(btnSujectWise, borderRadius: 20);
            //UI.Instance.StyleButton(btnSum, borderRadius: 20);
            UI.Instance.StyleButton(btnUpAtt, borderRadius: 20);
            UI.Instance.StyleButton(btnMark, borderRadius: 20);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void StyleControls()
        {

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.IndianRed,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.AddFormShadow(this);
            UI.Instance.StylePanel(pnMain, backColor: Color.IndianRed,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
        }
        private void attendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (classWisAttencedance attendance = new classWisAttencedance())
            {
                attendance.ShowDialog();
            }
            this.Show();
        }

        private void btnUpAtt_Click(object sender, EventArgs e)
        {
            this.Hide()
                ;
            using (TeacheraAttendance updateAtt = new TeacheraAttendance())
            {
                updateAtt.ShowDialog();
            }
            this.Show();
        }

        private void btnDashBoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AttendanceDashBoard dashBoard = new AttendanceDashBoard())
            {
                dashBoard.ShowDialog();
            }
            this.Show();
        }
    }
}
