using ExecutiveSceinceAccadmy.classes;
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

namespace ExecutiveSceinceAccadmy.TeacherMangement
{
    public partial class HireingForm : Form
    {
        public HireingForm()
        {
            InitializeComponent();
            UI.Instance.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;
        }
        private void StyleControls()
        {


            UI.Instance.StyleButton(btnHire, borderRadius: 20);
            UI.Instance.AddFormShadow(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HireingForm_Load(object sender, EventArgs e)
        {
            List<string> cityList = dataHandler.GetPakistanCities();
            foreach (string city in cityList)
            {
                cmbCity.Items.Add(city);
            }
            List<string> countryList = dataHandler.GetCountries();
            foreach (string country in countryList)
            {
                cmbCountry.Items.Add(country);
            }
            List<string> qualifications= dataHandler.GetQualifications();
            foreach (string qualification in qualifications)
            {
                cmbQualification.Items.Add(qualification);
            }
            rdSal.Checked = true;
            rdPercent.Checked = false;
            cmbCountry.SelectedIndex = 0;
            cmbCity.SelectedIndex = 0;
            cmbQualification.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPercent.Checked)
            {
                rdSal.Checked = false;
                txtType.Text = "60%";
                lblsalType.Text = "Precentage";
            }
        }

        private void rdSal_CheckedChanged(object sender, EventArgs e)
        {
            if(rdSal.Checked)
            {
                rdPercent.Checked = false;
                txtType.Text = "0";
                lblsalType.Text = "Salary";
            }
        }
    }
}
