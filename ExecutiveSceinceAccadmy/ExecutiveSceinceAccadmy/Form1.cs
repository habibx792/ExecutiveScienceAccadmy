
using ExecutiveSceinceAccadmy.AttendanceMangment;
using ExecutiveSceinceAccadmy.DashBoadMangement;
using ExecutiveSceinceAccadmy.ExpenseMangenment;
using ExecutiveSceinceAccadmy.FeeMangement;
using ExecutiveSceinceAccadmy.ReportManagement;
using ExecutiveSceinceAccadmy.ResultManagement;
//using ExecutiveSceinceAccadmy.StudentRegistration;
using ExecutiveSceinceAccadmy.studentRegistrationForms;
    
using ExecutiveScienceAcademy.classes;
using System;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace ExecutiveSceinceAccadmy
{
    public partial class Form1 : Form
    {

        public Form1()
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
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StylePanel(pnMain, backColor: Color.White,
              borderColor: Color.FromArgb(0, 120, 215),
              borderRadius: 20,
              borderThickness: 2);
            UI.Instance.StyleButton(btnStdReg, borderRadius: 20);
            UI.Instance.StyleButton(BtnFeeSub, borderRadius: 20);
            UI.Instance.StyleButton(BtnAttend, borderRadius: 20);
            UI.Instance.StyleButton(btnResult, borderRadius: 20);
            UI.Instance.StyleButton(btnReport, borderRadius: 20);
            UI.Instance.StyleButton(btnAdmin, borderRadius: 20);
            UI.Instance.StyleButton(btnExpense, borderRadius: 20);
            UI.Instance.StyleButton(stdBoard, borderRadius: 20);
            UI.Instance.StyleButton(btnTeacherBoard, borderRadius: 20);
            UI.Instance.AddFormShadow(this);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbLogo.Text = "Welcome To Executive Science Academy";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel panel) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int borderRadius = 15;
            int borderThickness = 2;

            Rectangle rect = panel.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
            using (Pen pen = new Pen(Color.FromArgb(0, 120, 215), borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }


        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }


        private void btnStdReg_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (StudentRegistration stdRegForm = new StudentRegistration())
            {
                stdRegForm.ShowDialog();
            }

            this.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (resultFrom ResultForm = new resultFrom())
            {
                ResultForm.ShowDialog();
            }
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFeeSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FeeForm stdFee = new FeeForm())
            {
                stdFee.ShowDialog();
            }

            this.Show();
        }

        private void stdBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DashBoardForm DashBoard = new DashBoardForm())
            {
                DashBoard.ShowDialog();
            }

            this.Show();
        }

        private void BtnAttend_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (attendanceForm attManagne = new attendanceForm())
            {
                attManagne.ShowDialog();
            }

            this.Show();
        }

        private void btnTeacherBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DashBoardForm DashBoard = new DashBoardForm())
            {
                DashBoard.ShowDialog();
            }

            this.Show();
        }
        

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ExpenseForm expenseMange = new ExpenseForm())
            {
                expenseMange.ShowDialog();
            }

            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ReportForm accaReportForm = new ReportForm())
            {
                accaReportForm.ShowDialog();
            }

            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DashBoardForm DashBoard = new DashBoardForm())
            {
                DashBoard.ShowDialog();
            }

            this.Show();
        }
    }
}
