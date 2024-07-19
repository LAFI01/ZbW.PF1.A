using System;
using System.Drawing;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_7 : Form
    {
        private int[] data = new int[100];

        public A10_1_7()
        {
            InitializeComponent();
        }

        private void CmdGenerateRandomValues_Click(object sender, EventArgs e)
        {
            data = GenerateRandomValues(100, -100, 100);
            TxtValues.Text = "";
            for (int c = 0; c < data.Length; c++)
            {
                TxtValues.Text += Convert.ToString(data[c]) + ", ";
            }
        }

        private void CmdSmallestNumber_Click(object sender, EventArgs e)
        {
            ShowResult(LblSmallestNumber, Min(data));
        }

        private void CmdLargestNumber_Click(object sender, EventArgs e)
        {
            ShowResult(LblLargestNumber, Max(data));
        }

        private void CmdAverage_Click(object sender, EventArgs e)
        {
            ShowResult(LblAverage, Average(data));
        }

        private void CmdDeltaMax_Click(object sender, EventArgs e)
        {
            ShowResult(LblDeltaMax, DeltaMax(data));
        }

        private void CmdDeltaMin_Click(object sender, EventArgs e)
        {
            ShowResult(LblDeltaMin, DeltaMin(data));
        }

        private int[] GenerateRandomValues(int amount, int max, int min)
        {
            Random r = new Random();
            int[] randomNumbers = new int[amount];
            for (int c = 0; c < randomNumbers.Length; c++)
            {
                randomNumbers[c] = r.Next(max, min);
            }
            return randomNumbers;
        }

        private int Max(int[] data)
        {
            int largest = data[0];
            for (int c = 0; c < data.Length; c++)
            {
                if (data[c] > largest)
                {
                    largest = data[c];
                }
            }
            return largest;
        }

        private int Min(int[] data)
        {
            int smallest = data[0];
            for (int c = 0; c < data.Length; c++)
            {
                if (data[c] < smallest)
                {
                    smallest = data[c];
                }
            }
            return smallest;
        }

        private double Average(int[] data)
        {
            int sum = 0;
            double avarage = 0.0;
            for (int c = 0; c < data.Length; c++)
            {
                sum += data[c];
            }
            avarage = sum / (double)data.Length;
            return avarage;
        }

        private void ShowResult(Label l, double result)
        {
            l.Text = Convert.ToString(result);
        }

        private int DeltaMax(int[] data)
        {
            int max = Max(data);
            int min = Min(data);
            return max - min;
        }

        private int DeltaMin(int[] data)
        {
            // Hier wird sichergestellt, dass die Initialisierung
            // der Variablen mit einem unmöglichen Delta erzeugt
            // wird.
            int deltaMin = this.DeltaMax(data);

            // Es werden jeweils zwei benachbarte Zahlen betrachtet
            for (int c=0; c<data.Length-1; c++)
            {
                for(int d=c +1; d<data.Length; d++)
                {
                    // Von beiden Werten wird die Differenz berechnet
                    int delta = data[c] - data[d];

                    // Ist die Zahl negativ, wird Sie positiv dargestellt
                    // Könnte auch mit Math.Abs() erledigt werden.
                    delta = (delta < 0 ? -delta : delta);
                    
                    // Ist die Differenz kleiner als das letzte
                    // deltaMin, wird die kleinere Differenz beider
                    // Zahlen zum deltaMin
                    deltaMin = (delta < deltaMin ? delta : deltaMin);
                }
            }
            return deltaMin;
        }
    }
}