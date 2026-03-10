using ExecutiveSceinceAccadmy.classes;
using ExecutiveScienceAcademy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.RegisTrationForms.StudentRegistration
{
    public partial class RegisTracionForm : Form
    {
        public RegisTracionForm()
        {
            InitializeComponent();

            UI.Instance.StyleForm(this,
                backgroundColor: Color.RoyalBlue,
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");


            StyleControls();
            this.StartPosition = FormStartPosition.CenterScreen;
            pnHide.Visible = false;
            AutoScroll = true;
            List<string> domains = DB.loadALlDomain();
            bool flag = false;
            for (int i = 0; i < domains.Count; i++)
            {
                flag = true;

                cmbDomain.Items.Add(domains[i]);
            }
            List<int> years = dataHandler.laodPrevisous_10Years();
            for (int i = 0; i < years.Count; i++)
            {
                cmbPassingYear.Items.Add(years[i].ToString());
            }




        }
        private void StyleControls()
        {

            UI.Instance.StylePanel(pnLogo,
                backColor: Color.IndianRed,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StylePanel(pnAccadminc, backColor: Color.RoyalBlue,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 0);
            UI.Instance.StylePanel(pnMainPn, backColor: Color.RoyalBlue,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 0);
            UI.Instance.StylePanel(pnPerMain, backColor: Color.RoyalBlue,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 0);
            UI.Instance.StylePanel(pnPreq, backColor: Color.RoyalBlue,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 0);
            UI.Instance.StylePanel(pnPerMain, backColor: Color.RoyalBlue,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 0);


            //lbLogo.Font = new Font(lbLogo.Font, FontStyle.Bold);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisTracionForm_Load(object sender, EventArgs e)
        {
            AutoScroll = true;


        }
        private void helpMethodOfRegies(Student student,string registraionNumber)
        {
            pnHide.Visible = true;
            pnMainPn.Visible = false;
            pnHide.Height = 400;
            pnHide.Width = 800;
            pnHide.Location = new Point((this.ClientSize.Width - pnHide.Width) / 3, (this.ClientSize.Height - pnHide.Height) / 3);
            UI.Instance.StylePanel(pnHide,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            Label lblMessage = new Label();
            lblMessage.Text = "You are registered";
            lblMessage.AutoSize = false;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Width = 600;
            lblMessage.Height = 40;
            lblMessage.Location = new Point(
                (pnHide.Width - lblMessage.Width) / 2,
                80
            );
            

            // fully qualify Button to avoid ambiguity with VisualStyleElement.Button
            System.Windows.Forms.Button btnRegister = new System.Windows.Forms.Button();
            btnRegister.Text = "Print Form";
            btnRegister.Width = 160;
            btnRegister.Height = 40;
            btnRegister.Location = new Point(
                (pnHide.Width - btnRegister.Width) / 2,
                160
            );
            btnRegister.Click += (s, e) =>
            {
              printEngine.printStudentRegistration(student, registraionNumber);
                MessageBox.Show("Print functionality is not implemented yet.");
            };
            Button btnSaveFile=new Button();
            btnSaveFile.Text = "Save Form";
            btnSaveFile.Width = 160;
            btnSaveFile.Height = 40;
            btnSaveFile.BackColor = Color.RoyalBlue;
            btnSaveFile.Location = new Point(
                (pnHide.Width - btnSaveFile.Width) / 2,
                200
            );
            btnSaveFile.Click += (s, e) =>
            {
                printEngine.SaveStudentDocument(printEngine.GenerateStudentDocument( student, registraionNumber),student.Name, registraionNumber);
            };
            Button hide = new Button();
            hide.Text = "Register New Student ";
            hide.AutoSize = false;
            hide.Width = 160;
            hide.Height = 50;
            hide.Location = new Point(
                (pnHide.Width - hide.Width) / 2,
                240
            );
            hide.Click += (s, e) =>
            {
                pnHide.Visible = false;
                pnMainPn.Visible = true;
                pnHide.Controls.Clear();
            };
            hide.BackColor = Color.RoyalBlue;
            hide.ForeColor = Color.Black;


            pnHide.BringToFront();
            pnHide.Controls.Clear();
            pnHide.Controls.Add(lblMessage);
            pnHide.Controls.Add(btnRegister);
            pnHide.Controls.Add(hide);
            pnHide.Controls.Add(btnSaveFile);
        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            //prepate data to be inserted into database


            string studentClassLevel = cmbClass.SelectedItem.ToString();
            string studentDomain = cmbDomain.SelectedItem.ToString();
            string dateOfRegistraion = dtpRegis.Value.ToString("yyyy-MM-dd");
            DateTime dob = dtpDOB.Value;
            int studentAge = dataHandler.calculateAge(dob);
            string studentName = txtStdName.Text;
            string studentFatherName = txtStdFatherName.Text;
            string studentCnic = txtStdCNIC.Text;
            string studentFatherCnic = txtFatherCNIC.Text;
            string studentContact = txtStdContact.Text;
            string studentFatherContact = txtFatherContact.Text;
            string studentGender = cmbGender.SelectedItem.ToString();
            string studentDOB = dtpDOB.Value.ToString("yyyy-MM-dd");
            //string studentFatherContact = txtFatherContact.Text;
            string studentWatappNumber = txtWatsApp.Text;
            string fatherJob = cmbFatherJob.SelectedItem.ToString();
            string studentCity = txtCity.Text;
            string studetnAddress = txtStdAddress.Text;
            string studentcountry = "Pakistan";
            //academic info
            string previousInstitute = txtSchool.Text;
            string previousDegree = cmbPrvDeg.SelectedItem.ToString();
            int passingYearInt = int.Parse(cmbPassingYear.SelectedItem.ToString());
            string board = cmbBoard.SelectedItem.ToString();
            string prevRegistrationNumber = txtPrevReg.Text;
            int totalMarks = int.Parse(txtObtainedMarks.Text);
            int obtainedMarks = int.Parse(txtObtainedMarks.Text);
            string gen = "";
            if (studentGender == "Male")
            {
                gen = "B";
            }
            else
            {
                gen = "G";
            }
            bool successFlag = false;
            string registrationNumber = dataHandler.createRegistrationNumber(studentDomain, gen, studentClassLevel);
            MessageBox.Show("Your registration number is: " + registrationNumber);
            string passingYear = cmbPassingYear.SelectedItem.ToString();
            string studentType = "Regular";
            Dictionary<string, string> admissinType = new Dictionary<string, string>();
            admissinType.Add("Regular", "Regular");
            admissinType.Add("Primary", "Primary");
            admissinType.Add("RTS", "RTS");
            admissinType.Add("Suplemenrtary", "Suplemenrtary");
            Student student = new Student(studentName, studentAge, studentDOB, studentContact, studentCnic, studentGender, studentClassLevel, studentDomain, studentType);
            student.Father = new Father(studentFatherName, 50, "", studentFatherContact, studentFatherCnic, "Male", fatherJob);
            student.AcademicHistories = new accadmicHistory(previousInstitute, previousDegree, passingYearInt, totalMarks, obtainedMarks, prevRegistrationNumber, board);
            student.Address = new Address(studentCity, studentcountry, studetnAddress);
            if (rdReg.Checked)
            {
                student.ReqisterType = admissinType["Regular"];
                successFlag = DB.registerAStudent(student, registrationNumber);
            }
            else if (rdPrim.Checked)
            {
                student.ReqisterType = admissinType["Primary"];
                successFlag = DB.registerAStudent(student, registrationNumber);
                
            }
            else if (rdRTS.Checked)
            {
                student.ReqisterType = admissinType["RTS"];
                successFlag = DB.registerAStudent(student, registrationNumber);
              
            }
            else if (rdSuple.Checked)
            {
                student.ReqisterType = admissinType["Suplemenrtary"];
              successFlag= DB.registerAStudent(student, registrationNumber);
                
            }
            if(successFlag)
            {
                MessageBox.Show("Student registered successfully!");
                helpMethodOfRegies(student,registrationNumber);
                //return;
            }


        }

        private void pnMainPn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnPreq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void rdPrim_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
