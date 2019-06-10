using System;
using BookBL;

namespace Knygugrazinimas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BibliotekosKnyga knyga = new BibliotekosKnyga("15", "Knygute", 15, 1);
            knyga.PaemimoData = new DateTime(2019, 05, 01);
            knyga.SkaitytojoVardas = "Jonas";
            Console.WriteLine("Ar {0} velavo grazinti knyga? {1}", knyga.SkaitytojoVardas, knyga.ArVelavo());
            Console.WriteLine("Viso delspinigiu: {0}", knyga.DelspinigiuSkaiciavimas());
        }
    }
}