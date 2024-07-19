namespace MB09.A13_2._2.Model
{
    public class CD : Medium
    {
        private string kuenstler;
        private int titelAnzahl;

        public string Kuenstler
        {
            get { return kuenstler; }
            set
            {
                if (value != null && value.Length > 0)
                    kuenstler = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }

        public int TitelAnzahl
        {
            get { return titelAnzahl; }
            set
            {
                if (value > 0)
                    titelAnzahl = value;
                else
                    throw new ArgumentException("argument may not be empty!");
            }
        }

        public CD(string titel, string kuenstler, int titelAnzahl, int spielzeit) : base(titel, spielzeit)
        {
            Kuenstler = kuenstler;
            TitelAnzahl = titelAnzahl;
        }

        public string Ausgeben()
        {
            string data = base.Ausgeben();
            const string delimiter = " | ";
            data += "Künster: " + Kuenstler + delimiter;
            data += "Titelanzahl: " + TitelAnzahl + delimiter;
            return data;
        }
    }
}
