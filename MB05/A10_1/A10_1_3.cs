using System;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_3 : Form
    {
        public A10_1_3()
        {
            InitializeComponent();
        }

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt16(TxtValue1.Text);
            int value2 = Convert.ToInt16(TxtValue2.Text);
            BestimmeMaximum(value1, value2);
        }

        private void CmdMax2_Click(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt16(TxtValue2.Text);
            int value2 = Convert.ToInt16(TxtValue3.Text);
            BestimmeMaximum(value1, value2);
        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            // Alternativ könnte auf die beiden Variablen value1 sowie value2
            // verzichtet werden, indem die Argumente direkt dem rechten
            // Teil der Zuweisung entsprechen:
            // BestimmeMaximum(Convert.ToInt16(TxtValue1.Text), Convert.ToInt16(TxtValue2.Text);

            BestimmeMaximum(Convert.ToInt16(TxtValue1.Text),
                Convert.ToInt16(TxtValue3.Text));
        }

        private void BestimmeMaximum(int v1, int v2)
        {
            string result = "";
            if (v1 > v2)
                result = Convert.ToString(v1);
            else if (v2 > v1)
                result = Convert.ToString(v2);
            else
                result = "Identisch";

            ZeigeWert(result);
        }

        private void ZeigeWert(string value)
        {
            LblMax.Text = value;
        }
    }
}