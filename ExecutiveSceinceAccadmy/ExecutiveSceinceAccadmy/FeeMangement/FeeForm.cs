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

namespace ExecutiveSceinceAccadmy.FeeMangement
{
    public partial class FeeForm : Form
    {

        public FeeForm()
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
            UI.Instance.StylePanel(pnMain,
                backColor: Color.White,
                borderColor: Color.FromArgb(0, 120, 215),
                borderRadius: 20,
                borderThickness: 2);
            UI.Instance.StyleButton(btnDefault, borderRadius: 20);
            //UI.Instance.StyleButton(btnPrimary, borderRadius: 20);
            UI.Instance.StyleButton(btnRegularFee, borderRadius: 20);
            //UI.Instance.StyleButton(btnSupp, borderRadius: 20);
            UI.Instance.StyleButton(btnSearchFee, borderRadius: 20);
            UI.Instance.StyleButton(btnDefault, borderRadius: 20);
            //UI.Instance.StyleButton(btnRts, borderRadius: 20);
            UI.Instance.AddFormShadow(this);
            UI.Instance.setFormSize(this, 1373, 687);

        }

        private void FeeForm_Load(object sender, EventArgs e)
        {
           lblDay.Text= DB.showTotalCollectionOfToday(dataHandler.getCurrentMonthStr());
           lblMonth.Text= DB.showTotalCollectionOfThisMonth( dataHandler.getCurrentMonthStr());
           lblYear.Text=DB.showTotalCollectionOfThisYear(dataHandler.getCurrentMonthStr());
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {


        }

        private void btnRegularFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var feeSubMission = new FeeSubMission())
            {
                feeSubMission.ShowDialog();
            }
            this.Show();
        }

        private void btnRts_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var feeSubMission = new FeeSubMission())
            {
                feeSubMission.ShowDialog();
            }
            this.Show();
        }

        private void btnPrimary_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var feeSubMission = new FeeSubMission())
            {
                feeSubMission.ShowDialog();
            }
            this.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var feeSubMission = new FeeSubMission())
            {
                feeSubMission.ShowDialog();
            }
            this.Show();
        }

        private void btnSearchFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var searchFeeRecord = new feeRecordSearch())
            {
                searchFeeRecord.ShowDialog();
            }
            this.Show();
        }



        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var defulter = new Defulter())
            {
                defulter.ShowDialog();
            }
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
