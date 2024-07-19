namespace MB09.A13_2._2.Model
{
    public class DVD : Medium
    {
        private string regisseur;

        public string Regisseur
        {
            get { return regisseur; }
            set
            {
                if (value != null && value.Length > 0)
                    regisseur = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }


        public DVD(string titel, string regisseur, int spielzeit) : base (titel, spielzeit)
        {
            Regisseur = regisseur;
        }

        public string Ausgeben()
        {
            string data = base.Ausgeben();
            const string delimiter = " | ";
            data += "Regisseur: " + Regisseur + delimiter;
            return data;
        }
    }
}
