using System;
using System.Windows.Forms;

namespace MB04.A9_2
{
    public partial class A9_2_2 : Form
    {
        int[] data;
        int accessCounter = 0;

        public A9_2_2()
        {
            InitializeComponent();
        }

        private void CmdNewValues_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt16(TxtArraySize.Text);
                if(size<=0 && size>=65000)
                {
                    MessageBox.Show("Werte zwischen 1 - 650000 erlaubt!", "Fehler!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    data = new int[size];
                    Random r = new Random();
                    for(int c=0; c<data.Length; c++)
                    {
                        data[c] = r.Next(0, 1000);
                    }
                    MessageBox.Show("Daten wurden erzeugt!", "Erfolg!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CmdNewValues.Enabled = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Falsche Eingabe. Bitte geben Sie eine ganze," +
                    " nicht negative Zahl ein!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdWriteValue_Click(object sender, EventArgs e)
        {
            try
            {
                int position = Convert.ToInt16(TxtPosition.Text);
                int value = Convert.ToInt16(data[position]);
                
                TxtValue.Text = Convert.ToString(value);
                accessCounter++;
                TxtHistory.Text = accessCounter + ". Zugriff auf Position: " +
                    position + ": Wert: " + value + "\r\n" + TxtHistory.Text;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Zugriff auf diese Position nicht erlaubt.", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
