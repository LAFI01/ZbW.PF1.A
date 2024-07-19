using System;
using System.Windows.Forms;

namespace MB03.A6_2
{
    public partial class A6_2_2 : Form
    {
        public A6_2_2()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TxtBinaryResult.Text = "";
            int value = Convert.ToInt32(NumValue.Value);
            while (value != 0)
            {
                TxtBinaryResult.Text = (value % 2) + TxtBinaryResult.Text;
                value /= 2;
            }
        }
    }
}
