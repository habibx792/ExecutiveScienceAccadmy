using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExecutiveSceinceAccadmy.classes;

namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class expenseReport : Form
    {
        public expenseReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expenseReport_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbMonth);
        }
    }
}
