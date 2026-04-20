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
            UI.StyleDataGrid(dtGrid);
            dataHandler.LoadMonths(cmbEnd);
            List<int> years = dataHandler.loadPreviouseAndNextFiveYears();
            for (int i = 0; i < years.Count; i++)
            {
                cmbYear.Items.Add(years[i]);
            }
            int currMontIndex = dataHandler.getCurrentMonth() - 1;
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
                if (cmbStart.SelectedItem == null || cmbEnd.SelectedItem == null || cmbYear.SelectedItem == null)
                {
                    MessageBox.Show("Please select start month, end month, and year",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string startMonth = cmbStart.SelectedItem.ToString();
                string endMonth = cmbEnd.SelectedItem.ToString();
                int year = int.Parse(cmbYear.SelectedItem.ToString());

                int startMonthNumber = DateTime.ParseExact(startMonth, "MMMM", null).Month;
                int endMonthNumber = DateTime.ParseExact(endMonth, "MMMM", null).Month;

                // Auto-swap if reversed
                if (startMonthNumber > endMonthNumber)
                {
                    (startMonthNumber, endMonthNumber) = (endMonthNumber, startMonthNumber);
                    (startMonth, endMonth) = (endMonth, startMonth);
                    MessageBox.Show($"Range adjusted: {startMonth} → {endMonth}");
                }

                DB.LoadExpenseDataRange(dtGrid, year, startMonthNumber, endMonthNumber);

                if (dtGrid.Rows.Count > 0)

                    btnGen.Text = "Generate";
            }
            else if (btnGen.Text == "Generate")
            {
                if (dtGrid.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export. Please search first.",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ExcelFileEngine.ExportExpenseToExcel(dtGrid);
                btnGen.Text = "search";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
