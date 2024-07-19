using System;
using System.Windows.Forms;

namespace MB09.A13_1._2
{
    public partial class A13_1_2 : Form
    {
        public A13_1_2()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            string value = TxtYear.Text;
            if (value.Length == 4) 
            {
                try
                {
                    int year = Convert.ToInt16(value);
                    if (Calendar.LeapYear(year))
                        LblAnswer.Text = year + " ist ein Schaltjahr!";
                    else
                        LblAnswer.Text = year + " ist kein Schaltjahr!";
                    LblShowCount.Text = Convert.ToString(Calendar.Count);
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "Nur Zahlen erlaubt", "Fehler");
                }
            }
            else
            {
                MessageBox.Show(this, "Eine vierstellige Jahreszahl wird erwartet!", "Fehleingabe");
            }
        }
    }
}