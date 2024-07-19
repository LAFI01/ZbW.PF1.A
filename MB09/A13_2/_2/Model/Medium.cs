using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.A13_2._2.Model
{
    public class Medium
    {
        private string titel;
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

        public Medium(string titel, int spielzeit)
        {
            Titel = titel;
            Spielzeit = spielzeit;
            HabIch = false;
            Kommentar = "<kein Kommentar>";
        }

        public string Ausgeben()
        {
            string data = "";
            const string delimiter = " | ";
            data = GetType().Name + ": " + Titel + " (" + Spielzeit + " Min)" + delimiter;
            data += HabIch == true ? "*" + delimiter : "" + delimiter;
            data += "Kommentar: " + Kommentar + delimiter;
            return data;
        }
    }
}