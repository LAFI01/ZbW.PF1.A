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
    public partial class A1_2_4 : Form
    {
        public A1_2_4()
        {
            InitializeComponent();
        }

        private void CmdFhVergr_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height + 10);
            Location = new Point(Location.X , Location.Y - 5);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimension.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdFhVerkl_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width , Size.Height - 10);
            Location = new Point(Location.X, Location.Y + 5);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimension.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdFbVergr_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width + 10, Size.Height);
            Location = new Point(Location.X - 5, Location.Y);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimension.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdFbVerkl_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width - 10, Size.Height);
            Location = new Point(Location.X + 5, Location.Y);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimension.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }
    }
}
