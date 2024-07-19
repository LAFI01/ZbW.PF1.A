using System;
using System.Windows.Forms;

namespace MB02
{
    enum Months
    {
        Januar=1, Februar, März, April, Mai, Juni, July, August, 
        September, Oktober, November, Dezember
    }

    public partial class A3_1_2 : Form
    {
        public A3_1_2()
        {
            InitializeComponent();
        }

        private void NumMonths_ValueChanged(object sender, EventArgs e)
        {
           
            int numberOfMonth = Convert.ToInt32(NumMonths.Value);
            Months currentMonth = (Months)numberOfMonth;
            
            LblMonth.Text = Convert.ToString(currentMonth);
        }
    }
}
