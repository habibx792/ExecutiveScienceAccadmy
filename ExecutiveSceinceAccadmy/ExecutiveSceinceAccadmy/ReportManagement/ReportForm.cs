using ExecutiveSceinceAccadmy.ExpenseMangenment;
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
//using ExecutiveScienceAcademy.ExpenseMangenment

namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.RoyalBlue,
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        private void StyleControls()
        {
            //UI.Instance.setFormSize(this, 680, 486);

            UI.Instance.StyleButton(btnAddExp, borderRadius: 20);
            UI.Instance.StyleButton(btnMonth, borderRadius: 20);
            UI.Instance.StyleButton(btnSalary, borderRadius: 20);
            UI.Instance.StyleButton(btnCurrMon, borderRadius: 20);
            //UI.Instance.StylePanel(pnLogo,
            //    backColor: Color.IndianRed,
            //    borderColor: Color.FromArgb(0, 120, 215),
            //    borderRadius: 20,
            //    borderThickness: 2);
            //UI.Instance.StylePanel(pnMain, backColor: Color.IndianRed,
            //  borderColor: Color.FromArgb(0, 120, 215),
            //  borderRadius: 20,
            //  borderThickness: 2);

            UI.Instance.AddFormShadow(this);
        }


        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (feeReports feeReportForm = new feeReports())
            {
                feeReportForm.ShowDialog();
            }
            this.Show();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the expense report form. The project provides `checkExpense` for expense reports.
            using (var expenseForm = new ExecutiveSceinceAccadmy.ReportManagement.expenseReport())
            {
                expenseForm.ShowDialog();
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ProfitLostForm profitLostForm = new ProfitLostForm())
            {
                profitLostForm.ShowDialog();
            }
            this.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(TeacherSalary teacherSalaryForm = new TeacherSalary())
            {
                teacherSalaryForm.ShowDialog();
            }
            this.Show();
        }
    }
}
