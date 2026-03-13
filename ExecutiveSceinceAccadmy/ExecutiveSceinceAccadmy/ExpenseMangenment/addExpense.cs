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

namespace ExecutiveSceinceAccadmy.ExpenseMangenment
{
    public partial class addExpense : Form
    {
        List<string> expenseTypes = new List<string> { "Office Supplies", "Electrix Bills", "Other Bills", "Maintenance", "Marketing", "Other" };
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
            for (int i = 0; i < expenseTypes.Count; i++)
            {
                cmbExpense.Items.Add(expenseTypes[i]);
            }
            cmbExpense.SelectedIndex = 0;

        }

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExpenseAdd_Click(object sender, EventArgs e)
        {
            // Validate amount
            if (string.IsNullOrWhiteSpace(txtExenseAmount.Text))
            {
                MessageBox.Show("Please enter expense amount.");
                return;
            }

            if (cmbExpense.SelectedItem == null)
            {
                MessageBox.Show("Please select expense type.");
                return;
            }

            if (!double.TryParse(txtExenseAmount.Text, out double amount))
            {
                MessageBox.Show("Invalid amount entered.");
                return;
            }

            string date = dtExpense.Value.ToString("yyyy-MM-dd");
            string month = dtExpense.Value.ToString("MMMM");
            string expenseType = cmbExpense.SelectedItem.ToString();

            string expenseId =
                expenseType.Trim() +
                dataHandler.generateRandomeNumber(3) +
                dataHandler.getStringOfDate();

            //MessageBox.Show(
            //    $"Expense ID: {expenseId}\n" +
            //    $"Expense Type: {expenseType}\n" +
            //    $"Amount: {amount}\n" +
            //    $"Date: {date}\n" +
            //    $"Month: {month}"
            //);

            bool addExpenseSuccess = DB.addExpense(expenseId, expenseType, amount, date, month);

            if (addExpenseSuccess)
            {
                MessageBox.Show("Expense added successfully!");

                txtExenseAmount.Clear();
                cmbExpense.SelectedIndex = 0;
                dtExpense.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Failed to add expense. Please try again.");
            }
        }
    }
}
