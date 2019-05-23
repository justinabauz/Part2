using System;
using ManoIslaidosStruct;

namespace ManoIslaidos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Islaidos islaidos;
            islaidos.maistas = 25;
            islaidos.buitis = 90;
            islaidos.mokesciai = 45;
            islaidos.laisvalaikis = 67;
            islaidos.saviugda = 56;

            Console.WriteLine("Mano islaidos is viso: {0}", islaidos.IsleistaPinigu());
            Console.WriteLine("Mano islaidos maistui: {0}", islaidos.ProcentaiPagalKategorija(1));
            Console.WriteLine("Mano islaidos buiciai: {0}", islaidos.ProcentaiPagalKategorija(2));
            Console.WriteLine("Mano islaidos mokesciams: {0}", islaidos.ProcentaiPagalKategorija(3));
            Console.WriteLine("Mano islaidos laisvalaikiui: {0}", islaidos.ProcentaiPagalKategorija(4));
            Console.WriteLine("Mano islaidos saviugdai: {0}", islaidos.ProcentaiPagalKategorija(5));
            Console.WriteLine("Mano kitos islaidos: {0}", islaidos.ProcentaiPagalKategorija(6));
            Console.WriteLine("Viso: {0}", islaidos.ProcentaiPagalKategorija(1) + islaidos.ProcentaiPagalKategorija(2) +
                islaidos.ProcentaiPagalKategorija(3) + islaidos.ProcentaiPagalKategorija(4) +
                islaidos.ProcentaiPagalKategorija(5));

        }
    }
}
