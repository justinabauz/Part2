using System;
using System.Collections.Generic;
using IAC.BL.Repositories;
using IAC.BL;
using IAC;

namespace AircraftMain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ReportGenerator generatorius = new ReportGenerator(new AircraftRepository(), new AircraftModelRepository(),
                new CompanyRepository(), new CountryRepository());

            List<ReportItem> ataskaita = generatorius.GenerateReportAircraftInEurope();

           foreach(var eilute in ataskaita)
            {
                Console.WriteLine("Numeris {0}, modelis {1}, kompanija {2}, savininkas {3}, imones salies kodas{4}" +
                	"imones salis {5}, priklauso Europai? {6}",
                    eilute.AircraftTailNumber, eilute.ModelNumber, 
                    eilute.ModelDescription, eilute.OwnerCompanyName,
                    eilute.CompanyCountryCode, eilute.CompanyCountryName, eilute.BelongsToEU);
            }

        }
    }
}
