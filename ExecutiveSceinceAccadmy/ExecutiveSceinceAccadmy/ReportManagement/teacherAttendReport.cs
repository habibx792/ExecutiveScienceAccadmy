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
            List<string> teachers = DB.GetAllTeacherNames();
            cmbTeacher.DataSource = teachers;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate teacher selection
            if (cmbTeacher.SelectedItem == null)
            {
                MessageBox.Show("Please select a teacher.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherName = cmbTeacher.SelectedItem.ToString();
            string teacherId = DB.GetTeacherIdByName(teacherName);
            if (string.IsNullOrEmpty(teacherId))
            {
                MessageBox.Show("Teacher ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool loadSuccess = false;

            if (rdDay.Checked)
            {
                // For day-wise, you may need a separate method. We'll show a message.
                MessageBox.Show("Day-wise report not implemented yet. Using month view.", "Info");
                return;
            }
            else if (rdMonth.Checked)
            {
                if (cmbMonth.SelectedItem == null)
                {
                    MessageBox.Show("Please select a month.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int month = cmbMonth.SelectedIndex + 1;
                loadSuccess = DB.loadTeacherAttendanceRecord(teacherId, month, dtDashAttend);
            }

            if (loadSuccess && dtDashAttend.Rows.Count > 0)
            {
                // Ask user if they want to print
                DialogResult result = MessageBox.Show("Attendance loaded successfully.\nDo you want to print the report?",
                    "Print Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    printEngine.printTeacherAttendance(dtDashAttend, teacherName, teacherId);
                }
            }
            else
            {
                MessageBox.Show("No attendance records found for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
