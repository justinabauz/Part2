using System;

namespace HumanLibraryBL
{
    public class Event
    {
        public Event()
        {

        }

        public Event(int id, int humanId, int gateId, DateTime date, bool pass)
        {
            Id = id;
            HumanId = humanId;
            GateId = gateId;
            Date = date;
            Pass = pass;

        }
        public int Id { get; set; }
        public int HumanId { get; set; }
        public int GateId { get; set; }
        public DateTime Date { get; set; }
        public bool Pass { get; set; }
    }
}
