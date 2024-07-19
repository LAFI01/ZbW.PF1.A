using MB08.A12_1._6.Controller;
using System;
using System.Windows.Forms;

namespace MB08.A12_1._6
{
    public partial class A12_1_6 : Form
    {
        private ClassManager cm;
        public A12_1_6()
        {
            ClassManager cm = new ClassManager();
            this.cm = cm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = cm.GetDataOfStudents();
            foreach (string name in data)
            {
                LstStudents.Items.Add(name);
            }
        }

        private void CmdStudentDetails_Click(object sender, EventArgs e)
        {
            if (LstStudents.SelectedIndex >= 0)
            {
                string data = cm.GetDataOfStudent(LstStudents.SelectedIndex);
                MessageBox.Show(this, data);
            }
            else
            {
                MessageBox.Show(this, "Wählen Sie einen Datensatz aus!");
            }
        }

        private void CmdBestStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, cm.GetBestStudent());
        }
    }
}
