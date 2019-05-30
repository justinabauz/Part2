using System;
using System.Collections.Generic;
using PirkinysStruct;

namespace PirkiniuKrepselis
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Pirkinys> prekiuSarasas = new List<Pirkinys>();

            prekiuSarasas.Add(new Pirkinys("Knyga", 12, 35));
            prekiuSarasas.Add(new Pirkinys("Piestukas", 1, 16));
            prekiuSarasas.Add(new Pirkinys("Puodelis", 5, 45));
            prekiuSarasas.Add(new Pirkinys("Kompiuteris", 2, 10000));
            prekiuSarasas.Add(new Pirkinys("Zaislas", 3, 78));

            int Visokaina = 0;
            for (int i = 0; i < prekiuSarasas.Count; i++)

            {
                Visokaina = Visokaina + prekiuSarasas[i].KainaViso;
                Console.WriteLine("Prekes: {0}, {1}, {2}", prekiuSarasas[i].PrekesPavadinimas, prekiuSarasas[i].Kiekis,
                    prekiuSarasas[i].KainaVieneto);
            }

            Console.WriteLine("Viso kaina: {0}", Visokaina);
            bool iseiti = false;
            while (iseiti == false)
            {
                Console.WriteLine("Iveskite, kokia operacija atliksite: [1] - prideti preke, [2] - istrinti preke, [3] - parodyti visa sarasa, [4] - Koreguoti kieki ");
                int operacija = Convert.ToInt32(Console.ReadLine());


                if (operacija == 1)
                {
                    Console.WriteLine("Iveskite prekes pavadinima:");
                    string naujaPreke = Console.ReadLine();
                    Console.WriteLine("Iveskite prekes kieki:");
                    int naujosPrekeskiekis = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite naujos prekes vieneto kieki:");
                    int naujosPrekesVienetoKiekis = Convert.ToInt32(Console.ReadLine());
                    prekiuSarasas.Add(new Pirkinys(naujaPreke, naujosPrekeskiekis, naujosPrekesVienetoKiekis));


                }
                else if (operacija == 2)
                {
                    Console.WriteLine("Iveskite kuria preke norite istrinti:");
                    int istrintiPreke = Convert.ToInt32(Console.ReadLine());
                    if (0 <= istrintiPreke && istrintiPreke < prekiuSarasas.Count)
                    {
                        prekiuSarasas.RemoveAt(istrintiPreke-1);
                    }
                    else
                    {
                        Console.WriteLine("Tokia preke neegzistuoja");
                    }

                }

                else if (operacija == 3)
                    for (int i = 0; i < prekiuSarasas.Count; i++)

                    {
                        Visokaina = Visokaina + prekiuSarasas[i].KainaViso;
                        Console.WriteLine("Prekes: {0}, {1}, {2}", prekiuSarasas[i].PrekesPavadinimas, prekiuSarasas[i].Kiekis,
                            prekiuSarasas[i].KainaVieneto);
                    }
                else if (operacija == 4)
                {
                    Console.WriteLine("Iveskite, kuria preke koreguosime");
                    int koreguotiPreke = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prekes: {0}, {1}, {2}", prekiuSarasas[koreguotiPreke-1].PrekesPavadinimas, prekiuSarasas[koreguotiPreke-1].Kiekis,
                                 prekiuSarasas[koreguotiPreke-1].KainaVieneto);
                    Console.WriteLine("Iveskite nauja kieki");
                    int naujasKiekis = Convert.ToInt32(Console.ReadLine());
                    Pirkinys tarpinis = new Pirkinys();
                    tarpinis.Kiekis = naujasKiekis;
                    tarpinis.PrekesPavadinimas = prekiuSarasas[koreguotiPreke-1].PrekesPavadinimas;
                    tarpinis.KainaVieneto = prekiuSarasas[koreguotiPreke-1].KainaVieneto;
                    prekiuSarasas[koreguotiPreke-1] = tarpinis;

                }
                Console.WriteLine("Iveskite, kokia operacija atliksite: [1] - testi darba, [2] - iseiti");
                int testidarba = Convert.ToInt32(Console.ReadLine());
                if (testidarba == 1)
                {
                    iseiti = false;
                }
                else if (testidarba == 2)
                {
                    iseiti = true;
                }
            }
        }
    }
}
