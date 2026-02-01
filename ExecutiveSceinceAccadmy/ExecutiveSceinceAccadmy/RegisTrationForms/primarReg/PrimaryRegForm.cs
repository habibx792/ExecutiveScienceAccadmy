using ExecutiveScienceAcademy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.RegisTrationForms.suplementaryReg
{
    public partial class PrimaryRegForm : Form
    {
       
        public PrimaryRegForm()
        {
            InitializeComponent();

            Load += PrimaryRegForm_Load;

            UI.Instance.StyleForm(
                this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy"
            );

            StyleControls();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StyleControls()
        {
            UI.Instance.AddFormShadow(this);
            UI.Instance.setFormSize(this, 1373, 687);
        }
        private void PrimaryRegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
