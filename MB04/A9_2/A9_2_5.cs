using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB04.A9_2
{
    public partial class A9_2_5 : Form
    {
        char[] data = new char[1000];

        public A9_2_5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int c=0; c<data.Length; c++)
            {
                data[c] = Convert.ToChar(r.Next(65, 92));
            }
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            for (char charakter = 'A'; charakter <= 'Z'; charakter++)
            {
                int charCounter = 0;
                for (int c = 0; c < data.Length; c++)
                {
                    if (data[c] == charakter)
                    {
                        charCounter++;
                    }
                }
                TxtValues.Text += "Buchstabe " + charakter + ": " + charCounter + "\r\n";
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            TxtValues.Text = "";
            Form1_Load(sender, e);
        }
    }
}
