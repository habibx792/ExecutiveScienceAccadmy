using ExecutiveSceinceAccadmy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class feeRecordSearch : Form
    {
        public feeRecordSearch()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void feeRecordSearch_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbMonth);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdFeeId.Checked)
            {
                lblSearchby.Text = "Fee ID ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdStdId.Checked)
            {
                lblSearchby.Text = "Student ID";
            }
        }
    }
}
