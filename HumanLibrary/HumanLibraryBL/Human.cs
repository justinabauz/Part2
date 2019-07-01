using System;
using System.Collections.Generic;

namespace HumanLibraryBL
{
        public class Human
        {
            public Human()
            {

            }

            public Human(int id, string name, string surname, List<int> gateIdRights)
            {
                Id = id;
                Name = name;
                Surname = surname;
                GateIdRights = gateIdRights;

            }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public List<int> GateIdRights { get; set; }
    }
}
