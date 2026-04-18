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
            UI.Instance.StyleButton(btnSearch, borderRadius: 20);

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
            rdMonth.Checked = false;
            rdDay.Checked = true;
            lblMonth.Visible = true;
            lblDate.Visible = false;
            cmbMonth.Visible = true;
            //makeDashBoardUiGood();
        }
        private void makeDashBoardUiGood()
        {
            // Basic grid behavior
            dtDashAttend.BorderStyle = BorderStyle.None;
            dtDashAttend.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtDashAttend.RowHeadersVisible = false;
            dtDashAttend.AllowUserToAddRows = false;
            dtDashAttend.AllowUserToResizeRows = false;
            dtDashAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDashAttend.MultiSelect = false;

            // Better column sizing: use AllCells to fit content, then Fill for remaining space
            dtDashAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDashAttend.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtDashAttend.BackgroundColor = Color.White;

            // Header style (bolder)
            dtDashAttend.EnableHeadersVisualStyles = false;
            dtDashAttend.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtDashAttend.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 62, 80);
            dtDashAttend.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtDashAttend.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            dtDashAttend.ColumnHeadersHeight = 40;

            // Row style (slightly bolder)
            dtDashAttend.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Made bold
            dtDashAttend.DefaultCellStyle.ForeColor = Color.Black;
            dtDashAttend.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dtDashAttend.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows (striped look)
            dtDashAttend.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Row height
            dtDashAttend.RowTemplate.Height = 35;

            // Align specific columns if they exist
            if (dtDashAttend.Columns.Contains("isPresent"))
            {
                dtDashAttend.Columns["isPresent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtDashAttend.Columns["isPresent"].Width = 80; // Fixed width for status
            }

            if (dtDashAttend.Columns.Contains("attendDate"))
            {
                dtDashAttend.Columns["attendDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtDashAttend.Columns["attendDate"].Width = 110; // Fixed width for date
            }

            // Additional column width adjustments for teacher attendance
            if (dtDashAttend.Columns.Contains("arrivalTime"))
            {
                dtDashAttend.Columns["arrivalTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtDashAttend.Columns["arrivalTime"].Width = 100;
            }

            if (dtDashAttend.Columns.Contains("departureTime"))
            {
                dtDashAttend.Columns["departureTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtDashAttend.Columns["departureTime"].Width = 100;
            }

            if (dtDashAttend.Columns.Contains("teacherName"))
            {
                dtDashAttend.Columns["teacherName"].Width = 180; // Give more space for names
            }

            // After fixing individual widths, fill remaining space for the last column
            dtDashAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                DateTime dt= dtDate.Value.Date; // Get only the date part
                loadSuccess = DB.loadTeacherAttendanceByDate(teacherId, dt, dtDashAttend);
                //makeDashBoardUiGood();


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
                makeDashBoardUiGood();

            }

            if (loadSuccess && dtDashAttend.Rows.Count > 0)
            {
                btnSearch.Text= "Print Report";
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
            btnSearch.Text = "Search";


        }
    }
}
