using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB02.A5_1
{
    public partial class A5_1_2 : Form
    {
        public A5_1_2()
        {
            InitializeComponent();
        }

        private int step = 5;
        
        private void CmdStartStop_Click(object sender, EventArgs e)
        {
            if (TmrStep.Enabled)
            {
                TmrStep.Enabled = false;
                CmdStartStop.Text = "Start";
            }
            else
            {
                TmrStep.Enabled = true;
                CmdStartStop.Text = "Stop";
            }
        }

        private void TmrStep_Tick(object sender, EventArgs e)
        {
            int xPos = PnlAnim.Location.X;
            if (step == 5)
            {
                if (xPos <= Size.Width - 50)
                    PnlAnim.Location = new Point(xPos + step, PnlAnim.Location.Y);
                else
                    step = -5;
            }
            else
            {
                if (xPos >= 0)
                    PnlAnim.Location = new Point(xPos + step, PnlAnim.Location.Y);
                else
                    step = 5;
            }
        }

        private void TrkbSpeed_Scroll(object sender, EventArgs e)
        {
            int value = TrkbSpeed.Value;
            TmrStep.Interval = value * 10;
        }
    }
}