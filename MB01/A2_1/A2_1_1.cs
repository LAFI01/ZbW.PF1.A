using System;
using System.Windows.Forms;

namespace MB01.A2_1
{
    public partial class A2_1_1 : Form
    {
        public A2_1_1()
        {
            InitializeComponent();
        }

        private void CmdEnter_Click(object sender, EventArgs e)
        {
            LblOutput.Text = TxtFirstname.Text + " " + TxtLastname.Text;
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "...";
            TxtFirstname.Text = "";
            TxtLastname.Text = "";
        }
    }
}
