using ExecutiveSceinceAccadmy.classes;
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

namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class teacherAttendReport : Form
    {
        public teacherAttendReport()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void rdDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDay.Checked)
            {
                cmbMonth.Visible = false;
                dtDate.Visible = true;
                rdMonth.Checked = false;
                lblMonth.Visible = false;
                lblDate.Visible = true;

            }
        }

        private void teacherAttendReport_Load(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblMonth.Visible = true;
            dataHandler.LoadMonths(cmbMonth);
            cmbMonth.SelectedIndex = 0;
            rdMonth.Checked = true;
            lblMonth.Visible = true;
            lblDate.Visible = false;
            cmbMonth.Visible = true;
            //makeDashBoardUiGood();
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonth.Checked)
            {
                rdDay.Checked = false;
                cmbMonth.Visible = true;
                dtDate.Visible = false;
                lblMonth.Visible = true;
                lblDate.Visible = false;

            }
        }
    }
}
