using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A5_1
{
    public partial class A5_1_1 : Form
    {
        public A5_1_1()
        {
            InitializeComponent();
        }

        private void Color_Scroll(object sender, EventArgs e)
        {
            int trk1 = Convert.ToInt16(Trk1.Value);
            int trk2 = Convert.ToInt16(Trk2.Value);
            int trk3 = Convert.ToInt16(Trk3.Value);

            string trk1Hex = Convert.ToString(trk1, 16);
            string trk2Hex = Convert.ToString(trk2, 16);
            string trk3Hex = Convert.ToString(trk3, 16);

            PnlColor.BackColor = Color.FromArgb(trk1, trk2, trk3);

            if (trk1Hex.Length < 2)
                trk1Hex = "0" + trk1Hex;
            if (trk2Hex.Length < 2)
                trk2Hex = "0" + trk2Hex;
            if (trk3Hex.Length < 2)
                trk3Hex = "0" + trk3Hex;

            if (RadHex.Checked)
                LblRgb.Text = "#" + trk1Hex + trk2Hex + trk3Hex;
            else
                LblRgb.Text ="Rot: " + trk1 + " Grün: " + trk2 + " Blau: " + trk3;

        }

        private void ChkRed_CheckedChanged(object sender, EventArgs e)
        {
            Trk1.Enabled = !Trk1.Enabled;
            
        }

        private void ChkGreen_CheckedChanged(object sender, EventArgs e)
        {
            Trk2.Enabled = !Trk2.Enabled;
        }

        private void ChkBlue_CheckedChanged(object sender, EventArgs e)
        {
            
            Trk3.Enabled = !Trk3.Enabled;
        }
    }
}
