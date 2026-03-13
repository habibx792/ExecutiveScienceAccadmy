using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    public partial class checkExpense : Form
    {
        public checkExpense()
        {
            InitializeComponent();

            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            UI.Instance.StylePanel(pnMain,
                backColor: Color.IndianRed,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;

            rdMonth.CheckedChanged += RdMonth_CheckedChanged;
            rdYear.CheckedChanged += RdYear_CheckedChanged;
            cmbMonth.SelectedIndexChanged += CmbMonth_SelectedIndexChanged;
            button1.Click += Button1_Click;
        }

        private void checkCurrMonth_Load(object sender, EventArgs e)
        {
            rdMonth.Checked = true;
        }

        private void RdMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonth.Checked)
            {
                lblMonth.Text = "Month";
                cmbMonth.Items.Clear();
                dataHandler.LoadMonths(cmbMonth);
                if (cmbMonth.Items.Count > 0)
                    cmbMonth.SelectedIndex = 0;
            }
        }

        private void RdYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdYear.Checked)
            {
                lblMonth.Text = "Year";
                cmbMonth.Items.Clear();
                List<int> years = dataHandler.loadPreviouseAndNextFiveYears();
                foreach (int year in years)
                    cmbMonth.Items.Add(year);
                if (cmbMonth.Items.Count > 0)
                    cmbMonth.SelectedIndex = 0;
            }
        }

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private  void StyleDataGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.GridColor = Color.Gray;
            dgv.BorderStyle = BorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string selectedValue = cmbMonth.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedValue))
            {
                MessageBox.Show("Please select a month/year.");
                return;
            }
            StyleDataGrid(dtExpense);
            if (rdMonth.Checked)
            {
                string year = DateTime.Now.Year.ToString();
                string month = selectedValue;
                bool loadSuccess = DB.expenseOfCurrentYearMonth(year, month, dtExpense);
            }
            else if (rdYear.Checked)
            {
                string year = selectedValue;
                bool loadSuccess = DB.LoadExpenseOfYear(year, dtExpense);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}