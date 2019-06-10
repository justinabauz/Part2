using System;

namespace BookBL
{
    public class BibliotekosKnyga
    {
        public BibliotekosKnyga()
        {

        }

        public BibliotekosKnyga(string id, string pavadinimas, int grazintiPertTiekDienu, decimal delspinigiuIkainis)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            GrazintiPertTiekDienu = grazintiPertTiekDienu;
            DelspinigiuIkainis = delspinigiuIkainis;

        }
        public string ID { get; private set; }
        public string Pavadinimas { get; private set; }
        public int GrazintiPertTiekDienu { get; private set; }
        public decimal DelspinigiuIkainis { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime PaemimoData { get; set; }

        public bool ArVelavo()
        {
            if (PaemimoData.AddDays(GrazintiPertTiekDienu) < DateTime.Now)
            {
                return true;

            }

            else
            {
                return false;
            }

        }
        public decimal DelspinigiuSkaiciavimas()
        {
            decimal visoDelspinigiu = 0;
            if (ArVelavo() == true)
            {
             return (decimal)((DateTime.Today - PaemimoData).TotalDays - GrazintiPertTiekDienu) * DelspinigiuIkainis;

            }
            return visoDelspinigiu;
        }
    }
}
