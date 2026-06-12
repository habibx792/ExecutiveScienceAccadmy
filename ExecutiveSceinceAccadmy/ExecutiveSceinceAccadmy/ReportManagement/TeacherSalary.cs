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
    public partial class TeacherSalary : Form
    {
        public TeacherSalary()
        {
            InitializeComponent();
            InitializeComponent();
            UI.Instance.StyleForm(this,

              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void TeacherSalary_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Teacher Salary Report";
            label1.BackColor = Color.Coral;
            label1.ForeColor = Color.Coral;

            //CenterToParent of form
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (this.ClientSize.Height - label1.Height) / 2);

        }
    }
}
