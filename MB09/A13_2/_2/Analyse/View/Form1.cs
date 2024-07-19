using MB09.A13_2._2.Analyse.Controller;
using MB09.A13_2._2.Analyse.Model;

namespace MB09.A13_2._2.Analyse.View
{
    public partial class Form1 : Form
    {
        private Datenbank Db { get; set; }

        public Form1(Datenbank db)
        {
            InitializeComponent();
            if (db == null)
                throw new ArgumentNullException("argument may not be null!");
            else
            {
                Db = db;
                SimuliereObjektErzeugung();
            }   
        }

       private void SimuliereObjektErzeugung()
        {
            Db.ErfasseCD(new CD("500 PS", "Bonez MC & RAF Camora", 12, 54));
            Db.ErfasseCD(new CD("Melodien", "Capital Bra", 19, 68));
            Db.ErfasseCD(new CD("Promises", "Calvin Harris, Sam Smith", 3, 12));

            Db.ErfasseDVD(new DVD("Ready Player One", "Steven Spielberg", 182));
            Db.ErfasseDVD(new DVD("A Beautiful Day", "John Francis Daley,", 102));
            Db.ErfasseDVD(new DVD("Game Night", "Lynne Ramsay", 98));
        }

        private void CmdShowCDs_Click(object sender, EventArgs e)
        {
            TxtCDList.Text = "";
            foreach(string cd in Db.GibAlleCdAlsArray())
            {
                TxtCDList.Text += cd + "\r\n";
            }
        }

        private void CmdShowDVDs_Click(object sender, EventArgs e)
        {
            TxtDVDList.Text = "";
            foreach (string dvd in Db.GibAlleDvdAlsArray())
            {
                TxtDVDList.Text += dvd + "\r\n";
            }
        }
    }
}
