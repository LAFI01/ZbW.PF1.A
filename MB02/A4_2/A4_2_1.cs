using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A4_2
{
    public partial class A4_2_1 : Form
    {
        private Color greater = Color.FromArgb(0, 255, 0);
        private Color equal = Color.FromArgb(255, 0, 0);
        public A4_2_1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(NumNumber1.Value);
            int zahl2 = Convert.ToInt32(NumNumber2.Value);

            if (zahl1 > zahl2)
            {
                NumNumber1.BackColor = greater;
                LblMessage1.Text = "Zahl 1 ist grösser!";
            }
            else if (zahl2 > zahl1)
            {
                NumNumber2.BackColor = greater;
                LblMessage2.Text = "Zahl 2 ist grösser!";
            }
            else
            {
                NumNumber1.BackColor = equal;
                NumNumber2.BackColor = equal;
                LblMessage1.Text = "Zahl 1 ist gleich gross wie Zahl 2";
                LblMessage1.Text = "Zahl 2 ist gleich gross wie Zahl 1";

            }
        }

        private void NumNumber1_ValueChanged(object sender, EventArgs e)
        {
            NumNumber1.BackColor = Color.White;
            LblMessage1.Text = "";

            NumNumber2.BackColor = Color.White;
            LblMessage2.Text = "";
        }

        private void NumNumber2_ValueChanged(object sender, EventArgs e)
        {
            NumNumber1.BackColor = Color.White;
            LblMessage1.Text = "";

            NumNumber2.BackColor = Color.White;
            LblMessage2.Text = "";
        }
    }
}
