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

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class Defulter : Form
    {
        public Defulter()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void StyleControls()
        {

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            //UI.Instance.StylePanel(pnMain, backColor: Color.White,
            //  borderColor: Color.FromArgb(0, 120, 215),
            //  borderRadius: 20,
            //  borderThickness: 2);
            //UI.Instance.StyleButton(btnStdReg, borderRadius: 20);
            //UI.Instance.StyleButton(BtnFeeSub, borderRadius: 20);
            //UI.Instance.StyleButton(BtnAttend, borderRadius: 20);
            //UI.Instance.StyleButton(btnResult, borderRadius: 20);
            //UI.Instance.StyleButton(btnReport, borderRadius: 20);
            //UI.Instance.StyleButton(btnAdmin, borderRadius: 20);
            //UI.Instance.StyleButton(btnExpense, borderRadius: 20);
            //UI.Instance.StyleButton(stdBoard, borderRadius: 20);
            //UI.Instance.StyleButton(btnTeacherBoard, borderRadius: 20);
            //UI.Instance.AddFormShadow(this);
            //UI.Instance.StyleLabel(lblMain);
            //lblMain.Font = new Font(lblMain.Font, FontStyle.Bold);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Defulter_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbMonth);
            dtDefaulter.Rows.Clear();
            string currenterMonth = dataHandler.getCurrentMonthStr();
            if (cmbMonth.SelectedItem != null)
            {
                currenterMonth = cmbMonth.SelectedItem.ToString();
            }
            DB.showDefaulterStudent(dtDefaulter, currenterMonth);
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currMonth = dataHandler.getCurrentMonthStr();
            if (cmbMonth.SelectedItem != null)
            {
                currMonth = cmbMonth.SelectedItem.ToString();
            }
            DB.showDefaulterStudent(dtDefaulter,currMonth);
        }
    }
}
