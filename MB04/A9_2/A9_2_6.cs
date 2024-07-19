using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB04.A9_2
{
    public partial class A9_2_6 : Form
    {
        char[] vocals = { 'A', 'E', 'I', 'O', 'U' };
        char[] characters = new char[18];
        public A9_2_6()
        {
            InitializeComponent();
        }

        private void CmdGenerate_Click(object sender, EventArgs e)
        {
            TxtCharacters.Text = "";
            Random r = new Random();
            for(int c=0; c<characters.Length; c++)
            {
                characters[c] = (char)r.Next(65, 91);
                TxtCharacters.Text += Convert.ToString(characters[c]) + ", ";
            }
        }

        private void CmdVocals_Click(object sender, EventArgs e)
        {
            TxtVocals.Text = "";
            for (int c=0; c<characters.Length; c++)
            {
                for(int c2=0; c2<vocals.Length; c2++)
                {
                    if (characters[c] == vocals[c2])
                    {
                        TxtVocals.Text += vocals[c2] + ", ";
                    }
                }
            }
        }

        private void CmdConsonants_Click(object sender, EventArgs e)
        {
            TxtConsonants.Text = "";
            int found = 0;
            for(int c=0; c<characters.Length; c++)
            {
                found = 0;
                for (int c2=0; c2<vocals.Length; c2++)
                {
                    if (characters[c] == vocals[c2])
                    {
                        found++;
                    }
                   
                }
                if(found==0)
                {
                    TxtConsonants.Text += Convert.ToString(characters[c])+ ", ";
                }
            }

        }
    }
}
