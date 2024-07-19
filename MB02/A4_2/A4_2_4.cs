using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02.A4_2
{
    public partial class A4_2_4 : Form
    {
        public A4_2_4()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(TxtValue1.Text);
            double zahl2 = Convert.ToDouble(TxtValue2.Text);
            double result = 0.0;
            char operation = Convert.ToChar(TxtOperation.Text);

            switch (operation)
            {
                case '+':
                    result = zahl1 + zahl2;
                    break;
                case '-':
                    result = zahl1 - zahl2;
                    break;
                case '*':
                    result = zahl1 * zahl2;
                    break;
                case '/':
                    if (zahl2 == 0)
                        LblResult.Text = "Division durch 0 nicht erlaubt!";
                    else
                        result = zahl1 / zahl2;
                    break;
                default:
                    LblResult.Text = "Falsches Operationszeichen eingegeben!";
                    break;
            }

            TxTResult.Text = Convert.ToString(result);
         
        }
    }
}
