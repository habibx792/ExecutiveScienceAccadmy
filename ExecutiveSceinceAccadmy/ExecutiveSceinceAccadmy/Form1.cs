
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

using ExecutiveScienceAcademy.classes;
namespace ExecutiveSceinceAccadmy
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Get UI instance
            UI ui = UI.Instance;

            // Apply modern form styling with custom title bar
            ui.StyleForm(this,
                backgroundColor: Color.FromArgb(245, 245, 245),
                borderRadius: 25,
                showCustomTitleBar: true,
                title: "Executive Science Academy");

            // IMPORTANT: Style controls AFTER form styling
            // This ensures proper positioning

            // Style main logo panel
            ui.StylePanel(pnLogo,
                backColor: Color.White,
                borderColor: Color.FromArgb(10, 220, 215),
                borderRadius: 20,
                borderThickness: 2);
            ui.StylePanel(pnMagnt,
              backColor: Color.White,
              borderColor: Color.FromArgb(100, 220, 215),
              borderRadius: 15,
              borderThickness: 5);
            



            ui.StyleButton(btnStdReg, borderRadius: 20);
            ui.StyleButton(BtnFeeSub, borderRadius: 20);
            ui.StyleButton(BtnAttend, borderRadius: 20);
            ui.StyleButton(btnResult, borderRadius: 20);
            ui.StyleButton(btnExpense, borderRadius: 20);
            ui.StyleButton(btnAdmin, borderRadius: 20);


            ui.StyleLabel(lbLogo, isTitle: true);
      

         
      

            AddFormShadow();
        }
        private void AddFormShadow()
        {
            this.Paint += (s, e) =>
            {
                // Draw subtle shadow around form
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    Color.FromArgb(100, 0, 0, 0), 0, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 0, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 1, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 1, ButtonBorderStyle.None);
            };
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

        // Helper method for rounded rectangles
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

        // Optional button click handlers
        private void btnStdReg_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional
        }
    }
}
