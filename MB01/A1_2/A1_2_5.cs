using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A1_2
{
    public partial class A1_2_5 : Form
    {
        public A1_2_5()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LblResultat.Text =Convert.ToString( Convert.ToInt32(Cmd8.Text+Cmd7.Text + Cmd6.Text + Cmd5.Text + Cmd4.Text + Cmd3.Text + Cmd2.Text + Cmd1.Text, 2));
        }

        private void CmdLeer_Click(object sender, EventArgs e)
        {
            Cmd1.Text = "0";
            Cmd2.Text = "0";
            Cmd3.Text = "0";
            Cmd4.Text = "0";
            Cmd5.Text = "0";
            Cmd6.Text = "0";
            Cmd7.Text = "0";
            Cmd8.Text = "0";
            LblResultat.Text = "0";
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            Cmd1.Text = "1";
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            Cmd2.Text = "1";

        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            Cmd3.Text = "1";
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            Cmd4.Text = "1";
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            Cmd5.Text = "1";
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            Cmd6.Text = "1";
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            Cmd7.Text = "1";
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            Cmd8.Text = "1";
        }
    }
}
