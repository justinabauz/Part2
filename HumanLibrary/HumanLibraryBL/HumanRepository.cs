using System;
using System.Collections.Generic;

namespace HumanLibraryBL
{
    public class HumanRepository
    {
        private List<Human> humen = new List<Human>();
        public List<Human> Retrieve()
        {
            return humen;
        }

        public HumanRepository()
        {
            humen.Add(new Human(1, "Jonas", "Jonaitis", new List<int>() { 1, 2, 3 }));
            humen.Add(new Human(2, "Petras", "Petraitis", new List<int>() { 1, 2 }));
            humen.Add(new Human(3, "Tadas", "Tadaitis", new List<int>() { 2, 4 }));
            humen.Add(new Human(4, "Justas", "Justaitis", new List<int>() { 1, 2,3, 4, 5, 6 }));
            humen.Add(new Human(5, "Juozas", "Juozaitis", new List<int>() { 5, 6 }));
            humen.Add(new Human(6, "Benas", "Benaitis", new List<int>() { 2, 5, 6 }));
            humen.Add(new Human(7, "Rokas", "Rokaitis", new List<int>() { 3, 5 }));
            humen.Add(new Human(8, "Lukas", "Lukaitis", new List<int>() { 6, 7, 8, 9,2 }));
            humen.Add(new Human(9, "Vidas", "Vidaitis", new List<int>() { 8, 2 }));
            humen.Add(new Human(10, "Ignas", "Ignaitis", new List<int>() { 1, 2 , 3, 4, 5}));

        }

        public Human Retrieve(int id)
        { 
        foreach (var humans in humen)
            { 
            if (humans.Id == id)
                {
                    return humans;
                }
            
            }
            return null;
        }

    }
}
