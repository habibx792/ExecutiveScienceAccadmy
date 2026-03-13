using ExecutiveSceinceAccadmy.classes;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void feeSet_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 12; i++)
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
        }
    }
}
