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
    public partial class FeeForm : Form
    {

        public FeeForm()
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
            UI.Instance.setFormSize(this, 1373, 687);

            UI.Instance.AddFormShadow(this);
        }

        private void FeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
