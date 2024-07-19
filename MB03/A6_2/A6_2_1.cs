using System;
using System.Windows.Forms;

namespace MB03.A6_2
{
    public partial class A6_2_1 : Form
    {
        private int randomNumber = 0;
        public A6_2_1()
        {
            InitializeComponent();
        }

        private void CmdRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            randomNumber = r.Next(10, 10000);
            TxtValue.Text = Convert.ToString(randomNumber);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (randomNumber > 0)
            {
                int counter = 0;
                TxtShow.Text = "";
                double aktRandomNumber = randomNumber;
                while (aktRandomNumber > 1)
                {
                    TxtShow.Text += aktRandomNumber + " / 2 = ";
                    aktRandomNumber /= 2;
                    TxtShow.Text += "" + aktRandomNumber + "\r\n";
                    TxtCountLoops.Text = Convert.ToString(counter++);
                }
            }
            else
            {
                MessageBox.Show(this, "Bitte generieren Sie eine Zufallszahl!");
            }
        }
    }
}
