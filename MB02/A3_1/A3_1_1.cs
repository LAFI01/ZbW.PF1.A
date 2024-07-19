
using System;
using System.Windows.Forms;

namespace MB02
{
    enum DayOfWeek 
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public partial class A3_1_1 : Form
    {
        // Globale Variable 
        const string textForLabel = ". Tag der Woche";
        public A3_1_1()
        {
            InitializeComponent();
        }

        private void CmdMonday_Click(object sender, EventArgs e)
        {
            LblDayOfWeek.Text = (int)DayOfWeek.Monday + textForLabel;          
        }

        private void CmdTuesday_Click(object sender, EventArgs e)
        {
            DayOfWeek dienstag = DayOfWeek.Tuesday;

            LblDayOfWeek.Text = (int)dienstag + textForLabel; 
        }

        private void CmdWednesday_Click(object sender, EventArgs e)
        {
            DayOfWeek mittwoch = DayOfWeek.Wednesday;
            int mittwochAlsWert = (int)mittwoch;

            LblDayOfWeek.Text = mittwochAlsWert + textForLabel;
        }

        private void CmdThursday_Click(object sender, EventArgs e)
        {
            LblDayOfWeek.Text = Convert.ToString((int)DayOfWeek.Thursday) + textForLabel;
        }

        private void CmdFriday_Click(object sender, EventArgs e)
        {
            LblDayOfWeek.Text = Convert.ToString((int)DayOfWeek.Friday) + textForLabel;
        }

        private void CmdSaturday_Click(object sender, EventArgs e)
        {
            LblDayOfWeek.Text = Convert.ToString((int)DayOfWeek.Saturday) + textForLabel;
        }

        private void CmdSunday_Click(object sender, EventArgs e)
        {
            LblDayOfWeek.Text = Convert.ToString((int)DayOfWeek.Sunday) + textForLabel;
        }
    }
}
