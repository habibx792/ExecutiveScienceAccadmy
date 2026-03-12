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
using System.Windows.Forms.VisualStyles;

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class feeRecordSearch : Form
    {
        public feeRecordSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkCond = (!rdStdId.Checked &&(!rdFeeId.Checked));
            if (checkCond)
            {
                return;
            }
            bool searchFlag = true;
            string feeId = "";
            if (rdFeeId.Checked)
            {
                searchFlag = false;
                feeId=dataHandler.stringTrim(txtId.Text);
            }
            
            string studentRegistrationNumber=dataHandler.stringTrim(txtId.Text);
            string searchMonth = cmbMonth.Text;
            if(searchMonth==""||txtId.Text=="")
            {
                MessageBox.Show("Fill Both Fields Properly");
                return;
            }
            bool dataLaodSuccess = DB.checkStudentFeeStatus(studentRegistrationNumber, searchMonth, feeId, searchFlag, dtGirdPaidStatus);
            if (!dataLaodSuccess || dtGirdPaidStatus.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "Student has not paid fee for this month.\nDo you want to pay the fee now?",
                    "Fee Not Paid",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // open fee payment screen
                    this.Hide();
                    FeeSubMission subMission = new FeeSubMission();
                    subMission.StartPosition = FormStartPosition.CenterScreen;
                    subMission.TopMost = true;   
                    subMission.Show();
                    subMission.Activate();
                }

                return;
            }
            if (!dataLaodSuccess)
            {
                MessageBox.Show("student Not Found laoded data");
            }
            
                
            
        }

        private void feeRecordSearch_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbMonth);
            this.StartPosition = FormStartPosition.CenterScreen;

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
