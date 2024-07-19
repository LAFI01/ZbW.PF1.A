using System;
using System.Windows.Forms;

namespace MB07.A12_1._2
{
    public partial class A12_1_2 : Form
    {
        public A12_1_2()
        {
            InitializeComponent();
        }

        private void ButtonEvents_Click(object sender, EventArgs e)
        {
            Button aktButton = (Button)sender;
            if (aktButton.Text == "Aufgabe A")
            {
                Person p1 = new Person("Max", "Muster", 22);
                Lbl1.Text = p1.GetFieldsAsString();
            }
            else if (aktButton.Text == "Aufgabe B")
            {
                Person p1 = new Person("Max", "Muster", 22);
                Person p2 = p1;
                Person p3 = p2;
                p3.Firstname = "Hans";
                Lbl1.Text = p1.GetFieldsAsString();
                Lbl1.Text += "\r\n";
                Lbl1.Text += p2.GetFieldsAsString();
                Lbl1.Text += "\r\n";
                Lbl1.Text += p3.GetFieldsAsString();
            }

            else if (aktButton.Text == "Aufgabe C")
            {
                Person p1 = new Person("Max", "Muster", 22);
                Person p2 = new Person("Anna", "Boli-ka", 33);
                Person p3;
                p3 = p1;
                p1 = p2;
                p2 = p3;
                Lbl1.Text = p1.GetFieldsAsString();
                Lbl1.Text += "\r\n";
                Lbl1.Text += p2.GetFieldsAsString();
            }

            else if (aktButton.Text == "Aufgabe D")
            {
                Person p1 = new Person("Max", "Muster", 22);
                Person p2 = p1;
                Person p3 = p2;
                p1 = p3;
                p2.Lastname = "Keller";
                p3.Firstname = "Hans";
                p1 = null;
                p2 = null;
                Lbl1.Text = p3.GetFieldsAsString();
            }
        }
    }
}
