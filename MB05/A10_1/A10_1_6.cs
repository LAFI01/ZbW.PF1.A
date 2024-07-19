using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_6 : Form
    {
        private int[] data = new int[100];

        public A10_1_6()
        {
            InitializeComponent();
        }

        private void CmdGenerateRandomValues_Click(object sender, EventArgs e)
        {
            TxtValues.Text = "";
            Random r = new Random();
            for (int c = 0; c < data.Length; c++)
            {
                data[c] = r.Next(-1000, 1000);
                TxtValues.Text += Convert.ToString(data[c]) + ", ";
            }
        }

        private void Max(int[] data)
        {
            int largest = data[0];
            for (int c = 0; c < data.Length; c++)
            {
                if (data[c] > largest)
                {
                    largest = data[c];
                }
            }
            ShowResult(LblLargestNumber, largest);
        }

        private void Min(int[] data)
        {
            int smallest = data[0];
            for (int c = 0; c < data.Length; c++)
            {
                if (data[c] < smallest)
                {
                    smallest = data[c];
                }
            }
            ShowResult(LblSmallestNumber, smallest);
        }

        private void Average(int[] data)
        {
            int sum = 0;
            double avarage = 0.0;
            for (int c = 0; c < data.Length; c++)
            {
                sum += data[c];
            }
            avarage = sum / (double)data.Length;
            ShowResult(LblAverage, avarage);
        }

        private void ShowResult(Label l, double result)
        {
            l.Text = Convert.ToString(result);
        }

        private void CmdSmallestNumber_Click(object sender, EventArgs e)
        {
            Min(data);
        }


        private void CmdAverage_Click(object sender, EventArgs e)
        {
            Average(data);
        }

        private void CmdLargestNumber_Click(object sender, EventArgs e)
        {
            Max(data);
        }
    }
}
