using System;
using MB09.A13_2._1.Entity;

using System.Windows.Forms;

namespace MB09.A13_2._1
{
    public partial class A13_2_1 : Form
    {
        public A13_2_1()
        {
            InitializeComponent();
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            Person p = new Person("Max", "Muster", 44);
            LblPerson.Text = p.GetData();
        }

        private void CmdCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer("Anna", "Bolika", CustomerType.B, 123);
            LblCustomer.Text = c.GetData();
        }

        private void CmdEmployee_Click(object sender, EventArgs e)
        {
            Employee m = new Employee("Hugo", "Müffler", 56, 7800.00);
            LblEmployee.Text = m.GetData();
        }

        private void CmdLead_Click(object sender, EventArgs e)
        {
            Lead l = new Lead("Berna", "Spierig", 34, 9200, 4);
            LblLead.Text = l.GetData();
        }

        private void CmdTrainee_Click(object sender, EventArgs e)
        {
            Trainee t = new Trainee("Beni", "Flunder", 16, 800.00, 4, 1);
            LblTrainee.Text = t.GetData();
        }
    }
}