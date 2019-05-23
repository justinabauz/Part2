using System;

namespace ManoIslaidosStruct
{
    public struct Islaidos
    {
        public decimal maistas;
        public decimal buitis;
        public decimal mokesciai;
        public decimal laisvalaikis;
        public decimal saviugda;

        public decimal IsleistaPinigu()

        {
            decimal Isleista = maistas + buitis + mokesciai + laisvalaikis + saviugda;
            return Isleista;

        }

        public decimal ProcentaiPagalKategorija(int kategorija)
        {
        if (kategorija == 1)
            {
                decimal procentas = maistas / IsleistaPinigu() * 100;
                return procentas;
            }
        else if (kategorija == 2)
            { 
            decimal procentas = buitis/IsleistaPinigu()*100;
            return procentas;
            }
        else if (kategorija == 3)
            {
            decimal procentas = mokesciai/IsleistaPinigu()*100;
            return procentas;
            }
        else if (kategorija == 4)
            {
            decimal procentas = laisvalaikis/IsleistaPinigu()*100;
            return procentas;

            }
        else if (kategorija == 5)
            {
            decimal procentas = saviugda/IsleistaPinigu()*100;
            return procentas;
            }
        else 
            {
            decimal procentas = 0;
            return procentas;
            }
        }
    }
}
