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

namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    public partial class addExpense : Form
    {
        public addExpense()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.RoyalBlue,
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            UI.Instance.StyleLabel(lblAdd);
            UI.Instance.StyleLabel(lbLogo);

        }
        private void StyleControls()
        {

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.IndianRed,
                borderColor: Color.RoyalBlue,
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StylePanel(pnMain, backColor: Color.IndianRed,
              borderColor: Color.RoyalBlue,
              borderRadius: 20,
              borderThickness: 2);
            
           
            UI.Instance.AddFormShadow(this);
        }

        private void addExpense_Load(object sender, EventArgs e)
        {

        }

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
