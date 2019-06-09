using System;
using VardasPavarde;

namespace Age
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           DateTime date = new DateTime(2018, 2, 13);
           AgeClass Asmuo = new AgeClass("Juste", "Bauz", date);
           Console.WriteLine("Vardas  - {0}, Pavarde - {1}, Gimimo Metai - {2}", Asmuo.Vardas, Asmuo.Pavarde, Asmuo.GimimoMetai);
        }
    }
}
