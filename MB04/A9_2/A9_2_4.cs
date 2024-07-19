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
    public partial class A9_2_4 : Form
    {
        int[] data;

        public A9_2_4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new int[10];
            Random r = new Random();
            for(int c=0; c<data.Length; c++)
            {
                data[c] = r.Next(0, 100);
                TxtValues.Text += Convert.ToString(data[c]) + ", ";
            }
        }

        private void CmdLargestNumber_Click(object sender, EventArgs e)
        {
            int largestNumber = data[0];
            for(int c=1; c<data.Length; c++)
            {
                if (data[c] > largestNumber)
                {
                    largestNumber = data[c];
                }
            }
            LblLargestNumber.Text = Convert.ToString(largestNumber);
        }

        private void CmdSmallestNumber_Click(object sender, EventArgs e)
        {
            int smallestNumber = data[0];
            for (int c = 1; c < data.Length; c++)
            {
                if (data[c] < smallestNumber)
                {
                    smallestNumber = data[c];
                }
            }

            LblSmallestNumber.Text = Convert.ToString(smallestNumber);
        }

        private void CmdAverage_Click(object sender, EventArgs e)
        {
            int sum = 0;
            double avarage = 0;
            for (int c = 0; c < data.Length; c++)
            {
                sum += data[c];
            }

            avarage = (double)sum / data.Length;

            LblAverage.Text = Convert.ToString(avarage);
        }
    }
}
