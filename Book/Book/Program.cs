using System;
using BookStruct;

namespace BookProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book knyga = new Book("Vardas", "id");

    
            Console.WriteLine(knyga.Name);
            Console.WriteLine(knyga.Id);

            Console.WriteLine(knyga.LocalID);
        }
    }
}
//Inkapsuliacija - Public Private ir Get SeT
