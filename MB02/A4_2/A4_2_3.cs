using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A4_2
{
    public partial class A4_2_3 : Form
    {
        public A4_2_3()
        {
            InitializeComponent();
        }

        private void CmdPaint_Click(object sender, EventArgs e)
        {
            TxtValue1.BackColor = Color.White;
            TxtValue2.BackColor = Color.White;

                int laenge = Convert.ToInt32(TxtValue1.Text);
                int breite = Convert.ToInt32(TxtValue2.Text);

                if(laenge <50 || laenge >200)
                {
                    MessageBox.Show("Länge muss > 50 und < 200 sein");
                    TxtValue1.BackColor = Color.Red;
                }

                else if(breite <50 || breite >200)
                {
                    MessageBox.Show("Breite muss > 50 und < 200 sein");
                    TxtValue2.BackColor = Color.Red;
                }

                else
                {
                    PnlGeometric.Width = laenge;
                    PnlGeometric.Height = breite;

                    LblLength.Location = new Point(PnlGeometric.Location.X + laenge / 2 - LblLength.Width / 2, LblLength.Location.Y);
                    LblHeight.Location = new Point(PnlGeometric.Location.X + laenge, PnlGeometric.Location.Y + breite/2 - LblHeight.Height/2);

                    LblLength.Text = laenge + " cm";
                    LblHeight.Text = breite + " cm";

                    if(laenge==breite)
                    {
                        PnlGeometric.BackColor = Color.Purple;
                        LblSquare.Text = "Quadrat!";
                        LblSquare.Location = new Point(PnlGeometric.Location.X + laenge / 2 - LblLength.Width / 2, PnlGeometric.Location.Y + breite + 5);
                        LblSquare.Visible = true;
                }
                    else
                    {
                        PnlGeometric.BackColor = Color.SkyBlue;
                        LblSquare.Visible = false;
                    }

                }
            }
    }
}
