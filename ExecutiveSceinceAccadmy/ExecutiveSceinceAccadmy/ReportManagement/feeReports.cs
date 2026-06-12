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

namespace ExecutiveSceinceAccadmy.ReportManagement
{
    public partial class feeReports : Form
    {
        public feeReports()
        {
            InitializeComponent();
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");
            this.StartPosition = FormStartPosition.CenterScreen;
            label1 = new Label();
            label1.Text = "Fee Reports";
            label1.Location = new Point(100, -100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void feeReports_Load(object sender, EventArgs e)
        {

        }
    }
}
