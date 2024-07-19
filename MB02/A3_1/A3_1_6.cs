using System;
using System.Windows.Forms;

namespace MB02
{
    public partial class A3_1_6 : Form
    {
        private byte byte1=0;  // 0 0 0 0 0 0 0 1
        private byte byte2=0;  // 0 0 0 0 0 0 0 0

        private const string desc1 = "Dezimal: ";
        private const string desc2 = "Ergebnis Dezimal: ";
        private const string desc3 = "Ergebnis Binär: ";

        public A3_1_6()
        {
            InitializeComponent();
        }

        private void NumByte1_1_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 1; // byte1 = byte1 ^ 1;
     

            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_2_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 2;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_3_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 4; 
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_4_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 8;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_5_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 16;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_6_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 32;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_7_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 64;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte1_8_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 128;
            LblByte1Decimal.Text = Convert.ToString(desc1 + byte1);
        }

        private void NumByte2_1_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 1;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_2_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 2;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_3_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 4;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_4_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 8;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_5_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 16;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_6_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 32;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_7_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 64;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void NumByte2_8_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 128;
            LblByte2Decimal.Text = Convert.ToString(desc1 + byte2);
        }

        private void CmdAnd_Click(object sender, EventArgs e)
        {
            string resultDez = Convert.ToString(byte1 & byte2);
            string resultBin = Convert.ToString((byte1 & byte2),2);
            LblResultDez.Text = desc2 + resultDez;
            LblResultBin.Text = desc3 + resultBin;
        }

        private void CmdOr_Click(object sender, EventArgs e)
        {
            string resultDez = Convert.ToString(byte1 | byte2);
            string resultBin = Convert.ToString((byte1 | byte2), 2);
            LblResultDez.Text = desc2 + resultDez;
            LblResultBin.Text = desc3 + resultBin;
        }

        private void CmdXor_Click(object sender, EventArgs e)
        {
            string resultDez = Convert.ToString(byte1 ^ byte2);
            string resultBin = Convert.ToString((byte1 ^ byte2), 2);
            LblResultDez.Text = desc2 + resultDez;
            LblResultBin.Text = desc3 + resultBin;
        }
    }
}
