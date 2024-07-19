using System;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_1 : Form
    {
        private int value1;
        private int value2;

        public A10_1_1()
        {
            InitializeComponent();
        }

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt16(TxtValue1.Text);
            value2 = Convert.ToInt16(TxtValue2.Text);
            BestimmeMaximum();
        }

        private void CmdMax2_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt16(TxtValue2.Text);
            value2 = Convert.ToInt16(TxtValue3.Text);
            BestimmeMaximum();
        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt16(TxtValue1.Text);
            value2 = Convert.ToInt16(TxtValue3.Text);
            BestimmeMaximum();
        }

        private void BestimmeMaximum()
        {
            string ausgabe = "";
            if (value1 > value2)
            {
                ausgabe = Convert.ToString(value1);
            }
            else if(value2 > value1)
            {
                ausgabe = Convert.ToString(value2);
            }
            else
            {
                ausgabe = "Identisch";
            }
            AusgabeMaske(ausgabe);
        }

        private void AusgabeMaske(string text)
        {
            LblMax.Text = Convert.ToString(text);
        }
    }
}