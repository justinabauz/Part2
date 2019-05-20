using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_01.@struct
{
    class Program
    {
        public struct Mokinys
        {
            public int trim1;
            public int trim2;
            public int trim3;

            public int MetinisVidurkis()
            {
                return (trim1 + trim2 + trim3) / 3;

            }
        
        }
        static void Main(string[] args)
        {
            List<Mokinys> mokiniai = new List<Mokinys>();
            SukurtiMokinius(mokiniai);

            for (int i = 0; i< mokiniai.Count; i++)
            {
                Console.WriteLine("trimestras1: {0}, trimestras2: {1}, trimestras3: {2}",
                    mokiniai[i].trim1, mokiniai[i].trim2, mokiniai[i].trim3);
                int metVid = mokiniai[i].MetinisVidurkis();
                Console.WriteLine(metVid);
            }

        }

        private static void SukurtiMokinius(List<Mokinys> sarasas)
        {
            Mokinys mok = new Mokinys();
            mok.trim1 = 10;
            mok.trim2 = 9;
            mok.trim3 = 7;

            sarasas.Add(mok);

            mok.trim1 = 6;
            mok.trim2 = 8;
            mok.trim3 = 9;

            sarasas.Add(mok);

            mok.trim1 = 5;
            mok.trim2 = 10;
            mok.trim3 = 9;

            sarasas.Add(mok);

            mok.trim1 = 7;
            mok.trim2 = 6;
            mok.trim3 = 9;

            sarasas.Add(mok);

            mok.trim1 = 9;
            mok.trim2 = 10;
            mok.trim3 = 9;

            sarasas.Add(mok);



        }
    }
}
