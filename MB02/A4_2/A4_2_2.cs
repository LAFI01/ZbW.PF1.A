using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A4_2
{
    public partial class A4_2_2 : Form
    {
        // Diese globalen Variablen definieren den Zustand 
        // der Ampel. Jede Variable steht für eine Lampe
        // der Ampel
        private bool red = true;
        private bool orange = false;
        private bool green = false;

        // Damit die Farben der Ampel an einer zentralen Stelle
        // verwaltet werden können, werden diese hier ebenso 
        // global definiert.
        private Color cRed = Color.Red;
        private Color cOrange = Color.Orange;
        private Color cGreen = Color.Green;
        private Color cDark = Color.FromArgb(90, 90, 90);

        public A4_2_2()
        {
            InitializeComponent();
        }

        private void CmdStep_Click(object sender, EventArgs e)
        {
            // Wenn Ampel auf Rot steht, dann wechsle auf Rot und Gelb
            if (red==true && orange==false && green==false)
            {
                red = true;
                PnlRed.BackColor = cRed;
                orange = true;
                PnlOrange.BackColor = cOrange;
                green = false;
                PnlGreen.BackColor = cDark;

            }
            // Wenn Ampel auf Rot und Gelb steht, dann wechsle auf Grün
            else if (red==true && orange==true && green==false)
            {
                red = false;
                PnlRed.BackColor = cDark;
                orange = false;
                PnlOrange.BackColor = cDark;
                green = true;
                PnlGreen.BackColor = cGreen;
            }

            // Wenn Ampel auf Grün steht, dann wechsle auf Orange
            else if (red==false && orange==false && green==true)
            {
                red = false;
                PnlRed.BackColor = cDark;
                orange = true;
                PnlOrange.BackColor = Color.Orange;
                green = false;
                PnlGreen.BackColor = cDark;
            }

            // Wenn Ampel auf Orange steht, dann wechlse auf Rot
            else if (red==false && orange==true && green==false)
            {
                red = true;
                PnlRed.BackColor = cRed;
                orange = false;
                PnlOrange.BackColor = cDark;
                green = false;
                PnlGreen.BackColor = cDark;
            }
        }
    }
}
