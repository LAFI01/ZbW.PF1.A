using System;
using System.Windows.Forms;

namespace MB03.A6_2
{
    public partial class A6_2_4 : Form
    {
        public A6_2_4()
        {
            InitializeComponent();
        }

        private void CmdKgv_Click(object sender, EventArgs e)
        {
            // Werte aus Form einlesen
            int value1 = Convert.ToInt32(NumValue1.Value);
            int value2 = Convert.ToInt32(NumValue2.Value);

            int max = value1 < value2 ? value2 : value1;
            int min = value1 < value2 ? value1 : value2;

            bool isKgv = false;
            int kgv = 0;
            int counter = 1;
            while (!isKgv)
            {
                if ((counter * max) % min == 0)
                {
                    isKgv = true;
                    kgv = counter * max;
                }
                counter++;
            }
            TxtGgtResult.Text = kgv + "";
        }
    }
}
