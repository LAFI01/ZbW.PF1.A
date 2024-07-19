using System;
using System.Windows.Forms;

namespace MB09.A13_1._1
{
    public partial class A13_1_1 : Form
    {
        private Person[] personen; 
 
        public A13_1_1()
        {
            personen = new Person[1000];

            InitializeComponent();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = TxtFirstname.Text;
                string lastname = TxtLastname.Text;
                int age = Convert.ToInt16(TxtAge.Text);

                personen[Person.Counter] = new Person(firstname, lastname, age);

                TxtObjectCounter.Text = Convert.ToString(Person.Counter);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte beachten Sie die korrekte Eingabe der Werte");
            }
        }
    }
}