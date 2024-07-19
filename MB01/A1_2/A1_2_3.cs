using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A1_2
{
    public partial class A1_2_3 : Form
    {
        public A1_2_3()
        {
            InitializeComponent();
        }

 
        private void CmdRauf_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X, CmdPoint.Location.Y - 10);
        }

        private void CmdRunter_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X, CmdPoint.Location.Y + 10);
        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X - 10, CmdPoint.Location.Y);
        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(CmdPoint.Location.X + 10, CmdPoint.Location.Y);
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            CmdPoint.Location = new Point(140, 230);
        }
    }
}
