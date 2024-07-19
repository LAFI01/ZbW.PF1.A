using System;
using System.Windows.Forms;

namespace MB04.A9_2
{
    public partial class A9_2_1 : Form
    {
        public A9_2_1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            int[] data = new int[20];
            Random r = new Random();

            for (int c = 0; c < data.Length; c++)
            {
                data[c] = r.Next(0, 100);
            }

            TxtValues.Text = "";
            int count = 0;
            while (count < data.Length)
            {
                TxtValues.Text += Convert.ToString(data[count] + "\r\n");
                count++;
            }
        }
    }
}