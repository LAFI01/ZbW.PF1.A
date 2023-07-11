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
    public partial class A1_2_2 : Form
    {
        public A1_2_2()
        {
            InitializeComponent();
        }

        private void Cmd1ner_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = LblPunkte.Text + ".";
        }

        private void Cmd2er_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = LblPunkte.Text + "..";
        }

        private void Cmd3er_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = LblPunkte.Text + "...";
        }
    }
}
