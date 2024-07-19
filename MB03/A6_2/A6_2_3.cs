using System;
using System.Windows.Forms;

namespace MB03.A6_2
{
    public partial class A6_2_3 : Form
    {
        public A6_2_3()
        {
            InitializeComponent();
        }

        private void CmdGgT_Click(object sender, EventArgs e)
        {
            // Werte aus Form einlesen
            int value1 = Convert.ToInt32(NumValue1.Value);
            int value2 = Convert.ToInt32(NumValue2.Value);

            // Variablen deklarieren und initialisieren
            int divisor = 0;
            int dividend = 0;
            int left = 0;

            // Bestimme die grösssere und die kleinere Zahl. 
            // Speichere die grössere Zahl in der Variable dividend
            // Speichere die kleinere Zahl im Divisor.
            if (value1 > value2)
            {
                dividend = value1;
                divisor = value2;
            }
            else
            {
                dividend = value2;
                divisor = value1;
            }

            // Überprüfung von Sonderfällen

            // Wenn beide Werte gleich sind, dann muss der ggT
            // nicht bestimmt werden.
            if (value1 == value2)
            {
                MessageBox.Show(this, "Zahlen sind gleich. Berechnung nicht nötig.", "Hinweis!");
            }
            // Falls einer der beiden Zahlen 0 ist, kann der ggT
            // nicht bestimmt werden
            else if (value1 == 0 || value2 == 0)
            {
                MessageBox.Show(this, "Keine der Zahlen darf 0 sein.", "Warnung!");
            }
            // Falls sich der Dividend durch den Divisor restlos teilen lässt
            // ist der Divisor der ggT.
            else if (dividend % divisor == 0)
            {
                TxtGgtResult.Text = Convert.ToString(divisor);
            }
            else
            {
                // Hier sieht man schön den Einsatz einer kopfgesteuerten
                // Schleife. Durch die Spezialfälle ist gewiss, dass in
                // die Schleife eingetreten werden muss.
                do
                {
                    // Bestimme Rest einer Division
                    left = dividend % divisor;
                    // Dividend erhält Wert von Divisor
                    dividend = divisor;
                    // Divisor erhält den Rest der Division
                    divisor = left;

                    // Solange die Division nicht aufgeht, wiederholen
                } while (dividend % divisor != 0);

                TxtGgtResult.Text = Convert.ToString(divisor);
            }
        }
    }
}
