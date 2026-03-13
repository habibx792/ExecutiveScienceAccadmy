using ExecutiveSceinceAccadmy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class classWisAttencedance : Form
    {
        public classWisAttencedance()
        {
            InitializeComponent();
            cmbAttendanceType.SelectedIndexChanged += cmbAttendance_SelectedIndexChanged;
            btnSearch.BackColor = Color.AliceBlue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setAttendanceTypes()
        {
            cmbAttendanceType.Items.Clear();
            cmbAttendanceType.Items.Add("Regular");
            cmbAttendanceType.Items.Add("RTS");
            cmbAttendanceType.Items.Add("Primary");
            cmbAttendanceType.SelectedIndex = 0;

        }
        private void setClassOnBaseOfAttendanceType(int start = 1, int end = 12)
        {
            cmbClass.Items.Clear();

            for (int i = start; i <= end; i++)
            {
                if (i <= 8)
                    cmbClass.Items.Add(i.ToString());
                else
                    cmbClass.Items.Add(i);
            }

            if (cmbClass.Items.Count > 0)
                cmbClass.SelectedIndex = 0;
        }
        private void classWisAttencedance_Load(object sender, EventArgs e)
        {
            setAttendanceTypes();
            styleAttendanceGrid();
        }
        private void styleAttendanceGrid()
        {
            dtGridAttence.Rows.Clear();
            dtGridAttence.Columns.Clear();

            dtGridAttence.Columns.Add("colRegis", "Registration No");
            dtGridAttence.Columns.Add("colName", "Name");
            dtGridAttence.Columns.Add("colDay", "Day");

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "colIsPresent";
            chk.HeaderText = "Is Present";
            chk.DefaultCellStyle.NullValue = true; // default checked


            dtGridAttence.Columns.Add(chk);
            // remove ugly borders
            dtGridAttence.BorderStyle = BorderStyle.None;
            dtGridAttence.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // hide row header (empty grey column)
            dtGridAttence.RowHeadersVisible = false;

            // header style
            dtGridAttence.EnableHeadersVisualStyles = false;
            dtGridAttence.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 62, 80);
            dtGridAttence.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtGridAttence.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dtGridAttence.ColumnHeadersHeight = 42;

            // row style
            dtGridAttence.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dtGridAttence.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridAttence.RowTemplate.Height = 36;

            // zebra rows (better readability)
            dtGridAttence.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // selection colors
            dtGridAttence.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dtGridAttence.DefaultCellStyle.SelectionForeColor = Color.White;

            // fill entire grid width
            dtGridAttence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // prevent ugly resizing
            dtGridAttence.AllowUserToResizeRows = false;
            dtGridAttence.AllowUserToResizeColumns = false;
        }
        private void cmbAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAttendanceType.SelectedItem == null)
                return;

            if (cmbAttendanceType.SelectedItem.ToString() == "Regular")
            {
                setClassOnBaseOfAttendanceType(1, 12);
            }
            else if (cmbAttendanceType.SelectedItem.ToString() == "RTS")
            {
                setClassOnBaseOfAttendanceType(9, 12);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbAttendanceType.SelectedItem == null || cmbClass.SelectedItem == null)
                return;
            string classSelected = cmbClass.SelectedItem.ToString();
            string attendanceTypeSelected = cmbAttendanceType.SelectedItem.ToString();
            string currentMonth = DateTime.Now.ToString("MMMM");
            string currDay = DateTime.Now.Day.ToString();
            //MessageBox.Show($"Searching attendance for {attendanceTypeSelected} class {classSelected} for month {currentMonth} and day {currDay}");
            bool dataLaodSuccess = DB.loadClassAttendance(classSelected, attendanceTypeSelected, dtGridAttence);
            if (!dataLaodSuccess || dtGridAttence.Rows.Count == 0)
            {
                MessageBox.Show("No attendance data found for the selected class and month.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAttendanceType.SelectedItem != null && cmbClass.SelectedItem != null)
            {
                List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();
                bool isGetData = false;
                foreach (DataGridViewRow row in dtGridAttence.Rows)
                {
                    if (row.IsNewRow) continue; // ignore last empty row

                    string regNo = row.Cells["colRegis"].Value.ToString();
                    string name = row.Cells["colName"].Value.ToString();
                    bool isPresent = Convert.ToBoolean(row.Cells["colIsPresent"].Value);
                    string day = row.Cells["colDay"].Value.ToString();
                    string attendanceType = cmbAttendanceType.SelectedItem.ToString();
                    string attendanceDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string strId = regNo;
                    strId=strId.Substring(4);
                    string attendaceId = strId + dataHandler.getStringOfDate();
                    attendanceRecords.Add(new AttendanceRecord(attendaceId, regNo, attendanceDate, isPresent, attendanceType, day));
                    isGetData = true;
                    //MessageBox.Show(attendaceId);
                }
                if(isGetData)
                {
                    bool updateSuccess = DB.MarkAttendanceByClassWise(attendanceRecords);
                    if(updateSuccess)
                    {
                        MessageBox.Show("Attendance marked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to mark attendance. Please try again.");
                    }

                }

            }
        }
    }
}
