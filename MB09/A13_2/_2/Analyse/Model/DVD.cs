using System;

namespace MB09.A13_2._2.Analyse.Model
{
    public class DVD
    {
        private string titel;
        private string regisseur;
        private int spielzeit;
        private string kommentar;

        public string Titel
        {
            get { return titel; }
            set
            {
                if (value != null && value.Length > 0)
                    titel = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }

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

        public int Spielzeit
        {
            get { return spielzeit; }
            set
            {
                if (value > 0)
                    spielzeit = value;
                else
                    throw new ArgumentException("argument may not be less than 0!");

            }
        }

        public bool HabIch { get; set; }

        public string Kommentar
        {
            get { return kommentar; }
            set
            {
                if (value != null && value.Length > 0)
                    kommentar = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }

        public DVD(string titel, string regisseur, int spielzeit)
        {
            Titel = titel;
            Regisseur = regisseur;
            Spielzeit = spielzeit;
            HabIch = false;
            Kommentar = "<kein Kommentar>";
        }

        public string Ausgeben()
        {
            string data = "";
            const string delimiter = " | ";
            data = "DVD: " + Titel + " (" + Spielzeit + " Min)" + delimiter;
            data += HabIch == true ? "*" + delimiter : "" + delimiter;
            data += "Regisseur: " + Regisseur + delimiter;
            data += "Kommentar: " + Kommentar + delimiter;
            return data;
        }
    }
}
