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
    public partial class A1_2_1 : Form
    {
        public A1_2_1()
        {
            InitializeComponent();
        }

        private void CmdYellow_Click(object sender, EventArgs e)
        {
            LblYellow.Text = "Gelbe Hintergrundfarbe";
            LblYellow.BackColor = Color.FromArgb(255, 255, 0);
        }

        private void CmdRed_Click(object sender, EventArgs e)
        {
            LblRed.Text = "Rote Hintergrundfarbe";
            LblRed.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void CmdGreen_Click(object sender, EventArgs e)
        {
            LblGreen.Text = "Grüne Hintergrundfarbe";
            LblGreen.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void CmdBlue_Click(object sender, EventArgs e)
        {
            LblBlue.Text = "Blaue Hintergrundfarbe";
            LblBlue.BackColor = Color.FromArgb(0, 0, 255);
        }
    }
}
