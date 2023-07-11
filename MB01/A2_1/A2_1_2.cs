using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A2_1
{
    public partial class A2_1_2 : Form
    {
        public A2_1_2()
        {
            InitializeComponent();
        }

        private void CmdEnter_Click(object sender, EventArgs e)
        {
            LblOutput.Text = TxtFirstname.Text + " " + TxtLastname.Text + " " + NumAge.Value;
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "...";
            TxtFirstname.Text = "";
            TxtLastname.Text = "";
            NumAge.Value = 0;
        }
    }
}
