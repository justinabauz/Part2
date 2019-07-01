using System;
using System.Collections.Generic;
using HumanLibraryBL;
using HumanTracking_BL;

namespace HumanLibrary
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            EventController eventController = new EventController();

            // GateRepositoryLocal gate = new GateRepositoryLocal();
            //List<Gate> gates = gate.Retrieve();
           int testi = 1;

            while (testi == 1)
            {
                Console.Clear();
                Console.WriteLine("Iveskite Human ID ir Gate ID");
                int humanId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite Gate ID:");
                int gateID = Convert.ToInt32(Console.ReadLine());

                if (eventController.TryPass(humanId, gateID) == true)
                {
                    Console.WriteLine("Zmogus praejo sekmingai");


                }
                else
                {
                    Console.WriteLine("Zmogus nepraejo");
                }
                foreach (var oneEvent in eventController.events)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                        oneEvent.Id,
                        oneEvent.HumanId,
                        oneEvent.GateId,
                        oneEvent.Date,
                        oneEvent.Pass);

                }
                Console.WriteLine("Ar norite testi? [1] - taip, [2] - ne");
                testi = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
