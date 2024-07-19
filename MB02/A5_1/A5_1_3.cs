using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A5_1
{
    public partial class A5_1_3 : Form
    {
        private int goal = 0;               // Zielpunkte
        private int live = 5;               // Anzahl Leben
        private int points = 0;             // Erreichte Spielpunkte
        private Random r = new Random();    // Zufallszahlgenerator
        private int step = 5;               // Schrittweite
        public A5_1_3()
        {
            InitializeComponent();
        }

        private void TrkbShelf_Scroll(object sender, EventArgs e)
        {
            int value = TrkbShelf.Value;
            PnlShelf.Location = new Point(PnlShelf.Location.X, 200 - value * 10);
        }

        private void TmrBall_Tick(object sender, EventArgs e)
        {
            if (live <= 0 && points < goal)
            {
                TmrBall.Enabled = false;
                MessageBox.Show(this, "Sie haben verloren!");
                CmdStart.Text = "Neues Spiel";
                CmdStart.Visible = true;
            }
            else if (points >= goal)
            {
                TmrBall.Enabled = false;
                MessageBox.Show(this, "Sie haben gewonnen!");
                CmdStart.Text = "Neues Spiel";
                CmdStart.Visible = true;
            }

            int posX = PnlBall.Location.X;
            if (posX >= Width - 50)
            {
                posX = 0;
                live--;
                points -= 150;
                PnlBall.Location = new Point(PnlBall.Location.X, r.Next(50, 180));
                LblLives.Text = "Leben: " + live;
                LblPoints.Text = "Punkte: " + points;
                step = r.Next(5, 15);
            }

            if (PnlBall.Bounds.IntersectsWith(PnlShelf.Bounds))
            {
                points += 100;
                posX = 0;
                PnlBall.Location = new Point(PnlBall.Location.X, r.Next(50, 240));
                LblLives.Text = "Leben: " + live;
                LblPoints.Text = "Punkte: " + points;
                step = r.Next(5, 15);
            }

            PnlBall.Location = new Point(posX + step, PnlBall.Location.Y);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            live = 5;
            points = 0;
            goal = r.Next(1000, 10000);

            LblLives.Text = "Leben: " + live;
            LblPoints.Text = "Punkte: " + points;
            LblGoal.Text = "Ziel: " + goal + " Punkte";

            TmrBall.Enabled = true;
            CmdStart.Visible = false;
        }
    }
}