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
            bool sucess = DB.laodSujectAndClassToTeacherHiring(dtTeacherSubject);
            if (!sucess)
            {
                return;
            }

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
            List<string> qualifications = dataHandler.GetQualifications();
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
            if (rdSal.Checked)
            {
                rdPercent.Checked = false;
                //txtType.Text = "0";
                lblsalType.Text = "Salary";
            }
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            // Collect form data
            string teacherName = txtTeachName.Text.Trim();
            string teacherCNIC = txtTeachCnic.Text.Trim();
            string fatherName = txtFaterName.Text.Trim();
            string fatherCNIC = txtFatherCnic.Text.Trim();
            string city = cmbCity.SelectedItem?.ToString() ?? "";
            string country = cmbCountry.SelectedItem?.ToString() ?? "";
            string address = txtAddress.Text.Trim();
            string qualification = cmbQualification.SelectedItem?.ToString() ?? "";
            string typeInput = txtType.Text.Trim(); // Can be salary or percentage value

            // Basic validation
            if (string.IsNullOrEmpty(teacherName) ||
                string.IsNullOrEmpty(teacherCNIC) ||
                string.IsNullOrEmpty(fatherName) ||
                string.IsNullOrEmpty(fatherCNIC) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(typeInput) ||
                string.IsNullOrEmpty(qualification) ||
                string.IsNullOrEmpty(city) ||
                string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            // Determine teacher type (example: salaried if txtType contains a number, percentage otherwise)
            string teacherType = "Salaried";
            string salary = "0";
            string percentage = "0";

            if (decimal.TryParse(typeInput, out decimal value))
            {
                teacherType = "Salaried";
                salary = value.ToString();
            }
            else
            {
                teacherType = "Percentage";
                percentage = typeInput; // If user writes 10% etc.
            }

            string teacherId = "Tech-" +dataHandler.generateRandomeNumber(5);
            //string teacherId = Guid.NewGuid().ToString();

            // Create TeacherData object with correct parameter order
            TeacherData data = new TeacherData(
                teacherName,      // TeacherName
                teacherId,        // TeacherId
                teacherType,      // TeacherType
                fatherName,       // FatherName
                fatherCNIC,       // FatherCNIC
                teacherCNIC,      // TeacherCnic
                city,             // AddressCity
                country,          // AddressCountry
                address,          // Address
                qualification,    // Qualification
                salary,           // Salary
                percentage        // Percentage
            );

            // Optional: show confirmation
            MessageBox.Show($"Teacher {data.TeacherName} ({data.TeacherType}) ready to hire!");
            string generatedPassword = dataHandler.generatePassword(5); // generate password

            bool success = DB.HireTeacherWithPassword(data, generatedPassword, dtTeacherSubject);
            if (success)
            {

                 //success = DB.HireTeacher(data,generatedPassword, dtTeacherSubject);
                if (success)
                {
                    MessageBox.Show($"You are hired Mr/Mrs {data.TeacherName}");

                    // Save and print teacher document with selected subjects
                    printEngine.PrintTeacherDocument(data, generatedPassword, dtTeacherSubject);
                    return;
                }

            }
        }
    }

    }
