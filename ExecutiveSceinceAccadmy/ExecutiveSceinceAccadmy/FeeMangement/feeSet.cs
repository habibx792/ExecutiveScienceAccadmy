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

namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    public partial class feeSet : Form
    {
        public feeSet()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
              backgroundColor: Color.RoyalBlue,
              borderRadius: 25,
              showCustomTitleBar: true,
              title: "Executive Science Academy");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void feeSet_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbClass.Items.Add(i);
            }
            List<string> domains = DB.loadALlDomain();
            bool flag = false;
            for (int i = 0; i < domains.Count; i++)
            {
                flag = true;

                cmbDomain.Items.Add(domains[i]);
            }
           cmbClass.SelectedIndex = 0;
            cmbDomain.SelectedIndex = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbClass.SelectedItem!=null && cmbDomain.SelectedItem!=null)
            {
                int classNum = (int)cmbClass.SelectedItem;
                string domain = cmbDomain.SelectedItem.ToString();
                int feeAmount=int.Parse(txtAmount.Text);
                DB.addFeeOfClassDomain(classNum, domain, feeAmount);
                MessageBox.Show("Fee added successfully!");
            }
            else
            {
                MessageBox.Show("Please select both class and domain.");
            }
        }
    }
}
