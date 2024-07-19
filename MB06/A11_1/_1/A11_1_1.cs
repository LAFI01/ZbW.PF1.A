using System;
using System.Windows.Forms;

namespace MB06.A11_1._1
{
    public partial class A11_1_1 : Form
    {
        public A11_1_1()
        {
            InitializeComponent();
        }

        private void CmdCreateP1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.Firstname = "Max";
            p1.Lastname = "Muster";
            p1.Age = 18;
            p1.Height = 1.83;
            p1.HairColor = Color.brown;


            TxtOutputArea.Text += p1.ShowValues() + "\r\n";
            CmdCreateP1.Enabled = false;
        }

        private void CmdCreateP2_Click(object sender, EventArgs e)
        {
            Person p2 = new Person();
            p2.Firstname = "Anna";
            p2.Lastname = "Bolika";
            p2.Age = 44;
            p2.Height = 1.67;
            p2.HairColor = Color.red;

            TxtOutputArea.Text += p2.ShowValues() + "\r\n";
            CmdCreateP2.Enabled = false;
        }

        private void CmdCreateP3_Click(object sender, EventArgs e)
        {
            Person p3 = new Person();
            p3.Firstname = "Thomas";
            p3.Lastname = "Bichsel";
            p3.Age = 26;
            p3.Height = 1.89;
            p3.HairColor = Color.brown;
  

            TxtOutputArea.Text += p3.ShowValues() + "\r\n";
            CmdCreateP3.Enabled = false;
        }
    }
}
