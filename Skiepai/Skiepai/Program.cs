using System;
using System.Collections.Generic;
using SkiepasStr;

namespace SkiepaiMain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Skiepas> skiepuKalendorius = new List<Skiepas>();

            Skiepas skiepai;
            skiepai.skiepoData = new DateTime(2019, 1, 18);
            skiepai.skiepoPavadinimas = "Tymai";
            skiepuKalendorius.Add(skiepai);

            skiepai.skiepoData = new DateTime(2019, 2, 17);
            skiepai.skiepoPavadinimas = "Maliarija";
            skiepuKalendorius.Add(skiepai);

            skiepai.skiepoData = new DateTime(2019, 5, 14);
            skiepai.skiepoPavadinimas = "Raudoniuke";
            skiepuKalendorius.Add(skiepai);

            skiepai.skiepoData = new DateTime(2019, 4, 10);
            skiepai.skiepoPavadinimas = "hepatitas A";
            skiepuKalendorius.Add(skiepai);

            skiepai.skiepoData = new DateTime(2019, 4, 10);
            skiepai.skiepoPavadinimas = "hepatitas B";
            skiepuKalendorius.Add(skiepai);

            int zmogausSkiepuKiekis = skiepuKalendorius.Count;
            Console.WriteLine("Zmogus skiepintas {0}", zmogausSkiepuKiekis);

            Console.Write("Zmogui padaryti sie skiepai:");

            for (int i = 0; i < skiepuKalendorius.Count; i++)

            {
                if (i == 0)
                {
                    Console.Write(skiepuKalendorius[i].skiepoPavadinimas);
                }
                else
                {
                    Console.Write(", {0}", skiepuKalendorius[i].skiepoPavadinimas);
                }
            }

            DateTime veliausiasSkiepas = skiepuKalendorius[0].skiepoData;
            for (int j = 0; j < skiepuKalendorius.Count; j++)
            {

                if (veliausiasSkiepas < skiepuKalendorius[j].skiepoData)
                {
                    veliausiasSkiepas = skiepuKalendorius[j].skiepoData;
                }
                j++;
          }
            Console.Write("Veliausias skiepas atliktas: {0}", veliausiasSkiepas);
    }
  }
}
