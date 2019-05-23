using System;
using Saskaita_Struct;

namespace Saskaita_Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Saskaita invoice = new Saskaita("Vardas", "siutejass", 568);
            Console.WriteLine(invoice.Siuntejas);
            Console.WriteLine(invoice.Gavejas);
            Console.WriteLine(invoice.MoketiViso);

            Console.WriteLine(invoice.SaskaitosNumeris);
        }
    }
}
