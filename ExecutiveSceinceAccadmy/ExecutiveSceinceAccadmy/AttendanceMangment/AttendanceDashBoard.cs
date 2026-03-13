using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class AttendanceDashBoard : Form
    {
        public AttendanceDashBoard()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AttendanceDashBoard_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            dtDashAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDashAttend.BackgroundColor = Color.White;

            // Header style
            dtDashAttend.EnableHeadersVisualStyles = false;
            dtDashAttend.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtDashAttend.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 62, 80);
            dtDashAttend.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtDashAttend.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dtDashAttend.ColumnHeadersHeight = 40;

            // Row style
            dtDashAttend.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dtDashAttend.DefaultCellStyle.ForeColor = Color.Black;
            dtDashAttend.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dtDashAttend.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows (striped look)
            dtDashAttend.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Row height
            dtDashAttend.RowTemplate.Height = 35;

            // Align specific columns if they exist
            if (dtDashAttend.Columns.Contains("isPresent"))
                dtDashAttend.Columns["isPresent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dtDashAttend.Columns.Contains("attendDate"))
                dtDashAttend.Columns["attendDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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


        private void button2_Click(object sender, EventArgs e)
        {
            string studentRegistratoionNo = txtReginstraion.Text;
            string selectedDate = "";
            string searchMonth = "";
            if (studentRegistratoionNo == "")
            {
                MessageBox.Show("Please enter a registration number.");
                return;
            }
            if (rdDay.Checked)
            {
                selectedDate = dtDate.Value.ToString("yyyy-MM-dd");
                bool success = DB.showAttendacnceRecordOfDate(studentRegistratoionNo, selectedDate, dtDashAttend);
                makeDashBoardUiGood();
            }
            else if (rdMonth.Checked)
            {

                searchMonth = cmbMonth.SelectedItem.ToString();

                // Convert "January" → 1, "February" → 2
                int monthNumber = DateTime.ParseExact(
                    searchMonth,
                    "MMMM",
                    CultureInfo.InvariantCulture
                ).Month; bool success = DB.ShowAttendanceOfStudentOfMonth(studentRegistratoionNo, monthNumber, dtDashAttend);
                makeDashBoardUiGood();


            }







        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
