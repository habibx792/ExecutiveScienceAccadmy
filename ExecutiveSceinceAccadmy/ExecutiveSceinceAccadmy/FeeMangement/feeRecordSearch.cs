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
using System.Windows.Forms.VisualStyles;

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class feeRecordSearch : Form
    {
        public feeRecordSearch()
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
        }
        private void StyleControls()
        {


            UI.Instance.StyleButton(btnSearch, borderRadius: 20);
            UI.Instance.AddFormShadow(this);
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
                    $"Student has not paid fee for .{dataHandler.getCurrentMonthStr()}"

                );

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
            this.TopMost = true;
            rdStdId.Checked = true;
            string currentMonthName = DateTime.Now.ToString("MMMM");

            // Find the index of the month in the ComboBox
            int monthIndex = cmbMonth.Items.IndexOf(currentMonthName);

            // Set the selected index if found
            if (monthIndex >= 0)
            {
                cmbMonth.SelectedIndex = monthIndex;
            }
            //cmbMonth.SelectedIndex = ;
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
