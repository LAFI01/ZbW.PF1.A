

using MB08.A12_1._5.Controller;

namespace MB08.A12_1._5.View
{
    public partial class A12_1_5 : Form
    {
        private Clock clock;

        public A12_1_5()
        {
            var clock = new Clock();
            if (clock != null)
            {
                InitializeComponent();
                this.clock = clock;
                UpdateClock();
            }
            else
                throw new ArgumentNullException("Reference may not be null!");
        }

        private void CmdTick_Click(object sender, EventArgs e)
        {
            clock.TriggerClockSignal();
            UpdateClock();
        }


        private void CmdStartTimer_Click(object sender, EventArgs e)
        {
            if (TmrTick.Enabled)
            {
                TmrTick.Enabled = false;
                CmdStartTimer.Text = "Starte Automatik";
                CmdTick.Enabled = true;
            }
            else
            {
                TmrTick.Enabled = true;
                CmdStartTimer.Text = "Stoppe Automatik";
                CmdTick.Enabled = false;
            }
        }

        private void UpdateClock()
        {
            TxtHour.Text = clock.Hour;
            TxtMinute.Text = clock.Minute;
            TxtSecond.Text = clock.Second;
        }
    }
}
