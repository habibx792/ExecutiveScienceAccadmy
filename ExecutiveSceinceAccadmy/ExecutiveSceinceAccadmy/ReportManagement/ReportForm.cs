using ExecutiveSceinceAccadmy.ExpenseMangenment;
using ExecutiveSceinceAccadmy.ReportManagement;
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
//using ExecutiveScienceAcademy.ExpenseMangenment;

namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            UI.Instance.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StylePanel(pnMain, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);

        }
        private void StyleControls()
        {
            UI.Instance.setFormSize(this, 1373, 687);

            UI.Instance.StyleButton(btnAddExp, borderRadius: 20);
            UI.Instance.StyleButton(btnCurrYearReport, borderRadius: 20);
            UI.Instance.StyleButton(btnFromDate, borderRadius: 20);
            UI.Instance.StyleButton(btnCurrMon, borderRadius: 20);

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
            using (ReportForm reportForm = new ReportForm())
            {
                reportForm.ShowDialog();
            }
            this.Show();
        }
    }
}
