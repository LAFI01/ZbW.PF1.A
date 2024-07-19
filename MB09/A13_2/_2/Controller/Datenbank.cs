using MB09.A13_2._2.Model;

namespace MB09.A13_2._2.Controller
{
    public class Datenbank
    {
        private CD[] cds;
        private int cdCounter;

        private DVD[] dvds;
        private int dvdCounter;

        public Datenbank()
        {
            cds = new CD[100];
            cdCounter = 0;

            dvds = new DVD[100];
            dvdCounter = 0;
        }

        public bool ErfasseCD(CD neueCD)
        {
            if (cdCounter < cds.Length)
            {
                cds[cdCounter++] = neueCD;
            }
            return false;
        }

        public bool ErfasseDVD(DVD neueDVD)
        {
            if(dvdCounter < dvds.Length)
            {
                dvds[dvdCounter++] = neueDVD;
                return true;
            }
            return false;
        }

        public string[] GibAlleCdAlsArray()
        {
            string[] data = new string[cdCounter];
            for(int c=0; c<data.Length; c++)
            {
                data[c] = cds[c].Ausgeben();
            }
            return data;
        }

        public string[] GibAlleDvdAlsArray()
        {
            string[] data = new string[dvdCounter];
            for (int c = 0; c < data.Length; c++)
            {
                data[c] = dvds[c].Ausgeben();
            }
            return data;
        }
    }
}