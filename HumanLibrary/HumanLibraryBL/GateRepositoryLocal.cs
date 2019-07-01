using System;
using System.Collections.Generic;


namespace HumanLibraryBL
{
    public class GateRepositoryLocal
    {

        private List<Gate> _gates = new List<Gate>()
        {
            new Gate(){ Id = 1, Code = "G001", Description = "North gate"},
            new Gate(){ Id = 2, Code = "G002", Description = "West gate"},
            new Gate(){ Id = 3, Code = "G003", Description = "South gate"},
            new Gate(){ Id = 4, Code = "G004", Description = "East gate"}
        };
        public List<Gate> Retrive()
        {

            return _gates;
        }
    }

}