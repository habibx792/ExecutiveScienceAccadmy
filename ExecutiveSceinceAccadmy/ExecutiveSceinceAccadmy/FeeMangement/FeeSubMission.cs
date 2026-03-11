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

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class FeeSubMission : Form
    {
        public FeeSubMission()
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

            //UI.Instance.StylePanel(pnLogo,
            //    backColor: Color.White,
            //    borderColor: Color.FromArgb(0, 120, 215),
            //    borderRadius: 20,
            //    borderThickness: 2);
            //UI.Instance.StylePanel(pnMain, backColor: Color.White,
            //  borderColor: Color.FromArgb(0, 120, 215),
            //  borderRadius: 20,
            //  borderThickness: 2);
            //UI.Instance.StyleButton(btnStdReg, borderRadius: 20);
            //UI.Instance.StyleButton(BtnFeeSub, borderRadius: 20);
            //UI.Instance.StyleButton(BtnAttend, borderRadius: 20);
            //UI.Instance.StyleButton(btnResult, borderRadius: 20);
            //UI.Instance.StyleButton(btnReport, borderRadius: 20);
            //UI.Instance.StyleButton(btnAdmin, borderRadius: 20);
            //UI.Instance.StyleButton(btnExpense, borderRadius: 20);
            //UI.Instance.StyleButton(stdBoard, borderRadius: 20);
            //UI.Instance.StyleButton(btnTeacherBoard, borderRadius: 20);
            //UI.Instance.AddFormShadow(this);
            //UI.Instance.StyleLabel(lblMain);
            //lblMain.Font = new Font(lblMain.Font, FontStyle.Bold);
        }

        private void FeeSubMission_Load(object sender, EventArgs e)
        {
            dataHandler.LoadMonths(cmbMonth);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Search_Click(object sender, EventArgs e)
        {
            string registrationNo = dataHandler.stringTrim(txtRegis.Text);

            bool querySuccess = DB.DisplayStudentDetailForFeeSubmission(registrationNo, dataGridView1);
            if (!querySuccess)
            {
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No student found with the provided registration number.",
                                "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text) ||
                string.IsNullOrWhiteSpace(txtDicount.Text) ||
                string.IsNullOrWhiteSpace(txtSubBy.Text))
            {
                MessageBox.Show("Please fill all fee details (Amount, Discount, Submitted By).",
                                "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Get student name safely (there is at least one row)
            string studentName = dataGridView1.Rows[0].Cells["student_name"].Value?.ToString() ?? "";

            // 5. Proceed with fee submission
            btnSearch.Text = "Pay Now";
            string feeMonth = cmbMonth.SelectedItem.ToString();
            string feeId = dataHandler.GenerateShortId()+dataHandler.generateRandomeNumber(3)+ dataHandler.GenerateShortId(); // ensure this method exists
            double FeeAmount = double.Parse(txtAmount.Text);
            double dicountAmount = double.Parse(txtDicount.Text);
            string submittedBy = txtSubBy.Text;
            string percentage = ((dicountAmount / FeeAmount) * 100).ToString("F2") + "%";
            string currDate = DateTime.Now.ToShortDateString();
            int isPaid = 1;
            bool paymentSuccess = DB.submitFee(feeId,
                registrationNo,
                FeeAmount,
                dicountAmount,
                submittedBy,
                feeMonth,
                isPaid
            );

            if (paymentSuccess)
            {
                MessageBox.Show("Fee submitted successfully!");

                // --- Create the three buttons (Save Receipt, Print Receipt, Back) ---
                pnLogo.Controls.Clear();

                int buttonWidth = 160;
                int buttonHeight = 45;
                int spacing = 20;

                int totalWidth = (buttonWidth * 3) + (spacing * 2);
                int startX = (pnLogo.Width - totalWidth) / 2;
                int y = (pnLogo.Height - buttonHeight) / 2;

                Button btnSave = new Button();
                btnSave.Text = "Save Receipt";
                btnSave.Size = new Size(buttonWidth, buttonHeight);
                btnSave.Location = new Point(startX, y);

                Button btnPrint = new Button();
                btnPrint.Text = "Print Receipt";
                btnPrint.Size = new Size(buttonWidth, buttonHeight);
                btnPrint.Location = new Point(startX + buttonWidth + spacing, y);

                Button btnBack = new Button();
                btnBack.Text = "Back";
                btnBack.Size = new Size(buttonWidth, buttonHeight);
                btnBack.Location = new Point(startX + (buttonWidth + spacing) * 2, y);

                // Styling
                Button[] buttons = { btnSave, btnPrint, btnBack };
                foreach (Button btn in buttons)
                {
                    btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    btn.BackColor = Color.FromArgb(0, 120, 215);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }

                pnLogo.Controls.Add(btnSave);
                pnLogo.Controls.Add(btnPrint);
                pnLogo.Controls.Add(btnBack);

                // Attach click events
                string isPaidStatus = "Paid";
                btnSave.Click += (s, ev) =>
                {
                    printEngine.printFeeReceipt(feeId,studentName, registrationNo, feeMonth, FeeAmount,
                                                dicountAmount, percentage, feeMonth, currDate, isPaidStatus);
                };

                btnPrint.Click += (s, ev) =>
                {
                    printEngine.printFeeReceipt(feeId,studentName, registrationNo, feeMonth, FeeAmount,
                                                dicountAmount, percentage, feeMonth, currDate, isPaidStatus);
                };

                btnBack.Click += (s, ev) =>
                {
                    this.Close();
                    using (FeeSubMission feeSubMission = new FeeSubMission())
                    {
                        feeSubMission.ShowDialog();
                    }
                };
            }
            else
            {
                MessageBox.Show("Failed to submit fee. Please try again.");
            }
        }

        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
