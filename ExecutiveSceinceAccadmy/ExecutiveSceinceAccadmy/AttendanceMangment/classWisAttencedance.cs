using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
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
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                    borderRadius: 25,
                    showCustomTitleBar: true,
                    title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;
        


        cmbAttendanceType.SelectedIndexChanged += cmbAttendance_SelectedIndexChanged;
            //btnSearch.BackColor = Color.AliceBlue;

        }

        
        private void StyleControls()
        {



            //UI.Instance.StyleButton(btnHiring, borderRadius: 20);
            UI.Instance.StyleButton(btnSearch, borderRadius: 20);
            UI.Instance.AddFormShadow(this);

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
            cmbClass.SelectedIndex = 0;
            cmbAttendanceType.SelectedIndex = 0;
            //List<string> domainType = DB.loadALlDomain();
            //foreach (string domainTypeItem in domainType) 
            //    {
            //        cmbAttendanceType.Items.Add($"{domainTypeItem}");
            //    }
            
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbAttendanceType.SelectedItem == null || cmbClass.SelectedItem == null)
                return;

            string classSelectedNumber = cmbClass.SelectedItem.ToString();
            string attendanceTypeSelected = cmbAttendanceType.SelectedItem.ToString();

            bool dataLoadSuccess = DB.loadClassAttendance(classSelectedNumber, attendanceTypeSelected, dtGridAttence);

            if (!dataLoadSuccess || dtGridAttence.Rows.Count == 0)
            {
                MessageBox.Show("No attendance data found for the selected class and month.");
            }
        }

        // ===================== Button Mark Attendance =====================
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAttendanceType.SelectedItem == null || cmbClass.SelectedItem == null)
                return;

            List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();
            bool hasData = false;

            foreach (DataGridViewRow row in dtGridAttence.Rows)
            {
                if (row.IsNewRow) continue;

                string regNo = row.Cells["colRegis"].Value.ToString();
                bool isPresent = Convert.ToBoolean(row.Cells["colIsPresent"].Value);
                string day = row.Cells["colDay"].Value.ToString();
                string attendanceType = cmbAttendanceType.SelectedItem.ToString();
                string attendanceDate = DateTime.Now.ToString("yyyy-MM-dd");

                attendanceRecords.Add(new AttendanceRecord(
                    Guid.NewGuid().ToString("N"), // unique attendance ID
                    regNo,
                    attendanceDate,
                    isPresent,
                    attendanceType,
                    day
                ));

                hasData = true;
            }

            if (hasData)
            {
                string givenClassNumber = cmbClass.SelectedItem.ToString();
                string givenAttendanceType = cmbAttendanceType.SelectedItem.ToString();

                bool updateSuccess = DB.MarkAttendanceByClassWise(attendanceRecords, givenClassNumber, givenAttendanceType);

                if (updateSuccess)
                    MessageBox.Show("Attendance marked successfully!");
                else
                    MessageBox.Show("Failed to mark attendance. Please try again.");
            }
        }
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
