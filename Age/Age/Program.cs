using System;
using VardasPavarde;

namespace Age
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           AgeClass Asmuo = new AgeClass("Justina", "Bauz", new DateTime(2018, 2, 13));
           Console.WriteLine("Vardas  - {0}, Pavarde - {1}, Gimimo Metai - {2}, Metai - {3}", Asmuo.Vardas, Asmuo.Pavarde, 
               Asmuo.GimimoMetai, Asmuo.GetAge());
        }
    }
}
