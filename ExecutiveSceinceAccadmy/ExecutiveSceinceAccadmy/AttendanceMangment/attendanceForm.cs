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

namespace ExecutiveSceinceAccadmy.AttendanceMangment
{
    public partial class attendanceForm : Form
    {
        
        public attendanceForm()
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
            UI.Instance.AddFormShadow(this);
        }
        private void attendanceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
