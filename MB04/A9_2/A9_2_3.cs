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
    public partial class A9_2_3 : Form
    {
        int[] data;
        int[] dataCopy;

        public A9_2_3()
        {
            InitializeComponent();
        }

        private void CmdGenerateValues_Click(object sender, EventArgs e)
        {
            TxtOriginalValues.Text = "";
            TxtCopyValues.Text = "";
            data = new int[10];
            Random r = new Random();
            
            for(int c=0; c<data.Length; c++)
            {
                data[c] = r.Next(-10, 10);
                TxtOriginalValues.Text += Convert.ToString(data[c]) + ", ";
            }
        }

        private void CmdCopyValues_Click(object sender, EventArgs e)
        {
            dataCopy = new int[data.Length];

            for (int c = data.Length - 1,  c2 = 0; c>=0; c--, c2++)
            {
                dataCopy[c2] = data[c];
                TxtCopyValues.Text += Convert.ToString(dataCopy[c2]) + ", ";
            }
        }
    }
}
