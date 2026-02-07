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

        }
    }
}
