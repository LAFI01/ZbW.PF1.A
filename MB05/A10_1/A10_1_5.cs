using System;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_5 : Form
    {
        private int global1 = 1;
        private int global2 = 2;
        public A10_1_5()
        {
            InitializeComponent();
        }

        private void CmdCopyByValue_Click(object sender, EventArgs e)
        {
            ShowValues(true);
            CopyByValue(global1, global2);
            ShowValues(false);
        }

        private void CmdCopyByReference_Click(object sender, EventArgs e)
        {
            ShowValues(true);
            CopyByReference(ref global1, ref global2);
            ShowValues(false);
        }

        private void CopyByValue(int local1, int local2)
        {
            local1 = 100;
            local2 = 200;
        }

        private void CopyByReference(ref int local1, ref int local2)
        {
            local1 = 100;
            local2 = 200;
        }

        private void ShowValues(bool textSection)
        {
            if (textSection == true)
            {
                LblValueGlobalVal1.Text = Convert.ToString(global1);
                LblValueGlobalVal2.Text = Convert.ToString(global2);
            }
            else
            {
                LblValueGlobalVal1_1.Text = Convert.ToString(global1);
                LblValueGlobalVal2_2.Text = Convert.ToString(global2);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblValueGlobalVal1.Text = "...";
            LblValueGlobalVal2.Text = "...";
            LblValueGlobalVal1_1.Text = "...";
            LblValueGlobalVal2_2.Text = "...";
            global1 = 1;
            global2 = 2;
        }
    }
}