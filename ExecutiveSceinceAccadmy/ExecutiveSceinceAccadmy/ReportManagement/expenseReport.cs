using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class expenseReport : Form
    {
        public expenseReport()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");

        }

        private void expenseReport_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbStart);
            dataHandler.LoadMonths(cmbEnd);
            List<int> years =    dataHandler.loadPreviouseAndNextFiveYears();
            for(int i=0; i < years.Count; i++ ) {
                cmbYear.Items.Add(years[i]);
            }
            int currMontIndex= dataHandler.getCurrentMonth() - 1;
            cmbEnd.SelectedIndex = currMontIndex;
            cmbStart.SelectedIndex = 0;
            int currYearIndex = dataHandler.getCurrentYear();
            cmbYear.SelectedIndex = years.IndexOf(currYearIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnGen.Text == "search")
            {
                // Get values safely
                if (cmbStart.SelectedItem == null || cmbYear.SelectedItem == null)
                {
                    MessageBox.Show("Please select month and year");
                    return;
                }

                string selectedMonth = cmbStart.SelectedItem.ToString();
                int year = int.Parse(cmbYear.SelectedItem.ToString());

                // Convert month name → number
                int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", null).Month;

                // DEBUG: Show what we're searching for
                MessageBox.Show($"Searching for:\nMonth: {selectedMonth} → Number: {monthNumber}\nYear: {year}");

                // Load data using the direct method
                DB.LoadExpenseDataDirect(dtGrid, year, monthNumber, monthNumber);

                // Switch mode
                btnGen.Text = "Generate";
            }
            else if (btnGen.Text == "Generate")
            {
                if (dtGrid.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export");
                    return;
                }

                // Export Excel
                ExcelFileEngine.ExportExpenseToExcel(dtGrid);

                // Reset button
                btnGen.Text = "search";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
