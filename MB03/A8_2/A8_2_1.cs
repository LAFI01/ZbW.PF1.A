using System.Diagnostics;

namespace MB03.A8_1
{
    public partial class A8_2_1 : Form
    {
        public A8_2_1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            sbyte value1 = 0, value2;
            double result = 0.0;
            try
            {
                value1 = Convert.ToSByte(TxtValue1.Text);
                Debug.WriteLine("Wert von value1: " + value1);
                value2 = Convert.ToSByte(TxtValue2.Text);

                if (RadbAdd.Checked)
                {
                    result = value1 + value2;

                }
                else if (RadbSub.Checked)
                {
                    result = value1 - value2;
                }

                else if (RadbMul.Checked)
                {
                    result = value1 * value2;
                }
                else
                {
                    if (value2 == 0)
                        throw new DivideByZeroException();
                    result = value1 / (double)value2;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nur ganze Zahlen sind erlaubt!", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (DivideByZeroException)
            {

                MessageBox.Show("Division durch 0 nicht erlaubt", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (OverflowException)
            {
                MessageBox.Show("Zahlen sind zu gross. Maximal:" + sbyte.MaxValue +
                    ", Minimal: " + sbyte.MinValue, "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unterwarteter Fehler ist aufgetreten: " +
                    ex.GetType(), "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtResult.Text = Convert.ToString(result);
        }
    }
}