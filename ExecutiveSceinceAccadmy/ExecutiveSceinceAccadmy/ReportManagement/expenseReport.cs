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

        }
    }
}
