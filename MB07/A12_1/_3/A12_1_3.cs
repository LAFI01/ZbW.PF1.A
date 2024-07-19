using System;
using System.Windows.Forms;

namespace MB07.A12_1._3
{
    public partial class A12_1_3 : Form
    {
        private Person p1;
        private Person p2;
        private Person p3;

        // Konstruktor
        public A12_1_3()
        {
            InitializeComponent();
        }


        private void CmdCreate1_Click(object sender, EventArgs e)
        {
            p1 = new Person("Max", "Muster", 23);
            LblP1.Text = p1.GetPersonAsString();
        }

        private void CmdCreate2_Click(object sender, EventArgs e)
        {
            p2 = new Person("Max", "Muster", 23);
            LblP2.Text = p2.GetPersonAsString();
        }

        private void CmdCreate3_Click(object sender, EventArgs e)
        {
            p3 = new Person("Anna", "Bolika", 45);
            LblP3.Text = p3.GetPersonAsString();
        }

        private void CmdEqualP1P2_Click(object sender, EventArgs e)
        {
            if (p1.Equals(p2))
                MessageBox.Show("p1 und p2 sind inhaltlich identisch!");
            else
                MessageBox.Show("p1 und p2 sind inhaltlich nicht identisch!");
        }

        private void CmdEqualP2P1_Click(object sender, EventArgs e)
        {
            if (p2.Equals(p1))
                MessageBox.Show("p2 und p1 sind inhaltlich identisch!");
            else
                MessageBox.Show("p2 und p1 sind inhaltlich nicht identisch!");
        }

        private void CmdEqualP1P3_Click(object sender, EventArgs e)
        {
            if (p1.Equals(p3))
                MessageBox.Show("p1 und p3 sind inhaltlich identisch!");
            else
                MessageBox.Show("p1 und p3 sind inhaltlich nicht identisch!");
        }

        private void CmdEqualP2P3_Click(object sender, EventArgs e)
        {
            if (p2.Equals(p3))
                MessageBox.Show("p2 und p3 sind inhaltlich identisch!");
            else
                MessageBox.Show("p2 und p3 sind inhaltlich nicht identisch!");
        }
    }
}