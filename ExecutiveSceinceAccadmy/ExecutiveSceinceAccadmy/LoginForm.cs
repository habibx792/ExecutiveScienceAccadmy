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

namespace ExecutiveSceinceAccadmy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
                backColor: Color.IndianRed,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 4);
            UI.Instance.AddFormShadow(this);
            UI.Instance.StylePanel(pnMain, backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 4);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            
            bool loginSuccess = DB.Login(username, password);

            if (loginSuccess)
            {
                this.Hide();
                using (Form1 mainFom=new Form1() )
                {
                    
                    Form1 mainForm = new Form1();
                    mainForm.ShowDialog();
                   
                }
                this.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    
}
