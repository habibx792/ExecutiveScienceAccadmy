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

namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    public partial class ExpenseForm : Form
    {

        public ExpenseForm()
        {
            InitializeComponent();

            UI.Instance.StyleForm(this,

              backgroundColor: Color.FromArgb(245, 245, 245),
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");

            StyleControls();
            UI.Instance.StyleButton(btnCurrMonth, borderRadius: 20);
            UI.Instance.StyleButton(btnYear, borderRadius: 20);
            UI.Instance.StyleButton(bntReport, borderRadius: 20);
            UI.Instance.StyleButton(btnAdd, borderRadius: 20);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void StyleControls()
        {
            UI.Instance.setFormSize(this, 1373, 687);
         

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.AddFormShadow(this);
            UI.Instance.StylePanel(pnMain, backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.AddFormShadow(this);
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
