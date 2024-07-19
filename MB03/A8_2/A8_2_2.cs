using System;
using System.Windows.Forms;

namespace MB03.A8_2
{
    public partial class CmdCalculate : Form
    {
        public CmdCalculate()
        {
            InitializeComponent();
        }
        private void Click_CmdCalculateBMI(object sender, EventArgs e)
        {
            int bodySize = Convert.ToInt16(NumBodySize.Value);
            int bodyWeight = Convert.ToInt16(NumBodyWeight.Value);
            string text = "";

            int bmi = (int)(bodyWeight / (((double)bodySize / 100) * ((double)bodySize / 100)));
            TxtBMI.Text = Convert.ToString(bmi);

            int level1 = 0;
            int level2 = 0;
            int level3 = 30;
            int level4 = 40;

            if (RadMale.Checked)
            {
                level1 = 20;
                level2 = 25;
            }
            else
            {
                level1 = 19;
                level2 = 24;
            }

            if (bmi < level1)
            {
                text = "Sie haben Untergewicht!";
            }
            else if (bmi >= level1 && bmi <= level2)
            {
                text = "Sie haben Normalgewicht";
            }
            else if (bmi > level2 && bmi <= level3)
            {
                text = "Sie haben leichtes Übergewicht";
            }
            else if (bmi > level3 && bmi <= level4)
            {
                text = "Sie leiden unter Adipositas";
            }
            else
            {
                text = "Sie haben starke Adiposita!!!";
            }
            TxtDescription.Text = text;
        }
    }
}
