using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.A13_2._2.Analyse.Model
{
    public class CD
    {
        private string titel;
        private string kuenstler;
        private int titelAnzahl;
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

        public CD(string titel, string kuenstler, int titelAnzahl, int spielzeit)
        {
            Titel = titel;
            Kuenstler = kuenstler;
            TitelAnzahl = titelAnzahl;
            Spielzeit = spielzeit;
            HabIch = false;
            Kommentar = "<kein Kommentar>";
        }

        public string Ausgeben()
        {
            string data = "";
            const string delimiter = " | ";
            data = "CD: " + Titel + " (" + Spielzeit + " Min)" + delimiter;
            data += HabIch == true ? "*" + delimiter : "" + delimiter;
            data += "Künster: " + Kuenstler + delimiter;
            data += "Titelanzahl: " + TitelAnzahl + delimiter;
            data += "Kommentar: " + Kommentar + delimiter;
            return data;
        }
    }
}
