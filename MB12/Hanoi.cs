namespace MB12
{
    public static class Hanoi
    {

        public static void Bewege(int n, string start, string hilf, string ziel)
        {
            if (n > 0)
            {
                Bewege(n - 1, start, ziel, hilf);  // es werden die oberen n-1 Scheiben auf den Hilfsstab verschoben
                Console.WriteLine("Scheibe von Platz " + start + " auf Platz " + ziel + ".");   // Die einzig verbleibende Scheibe wird zum Ziel verschoben
                Bewege(n - 1, hilf, start, ziel);  // nun wird der Turm, der sich auf dem Hilfsstab befindet zum Ziel verschoben
            }
        }

    }
}
