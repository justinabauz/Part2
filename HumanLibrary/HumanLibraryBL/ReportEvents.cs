using System;
namespace HumanLibraryBL
{
    public class ReportEvents
    {
        public ReportEvents()
        {
        }

        public ReportEvents(string humanName, int gate, DateTime date, bool pass)
        {
            HumanName = humanName;
            Gate = gate;
            Date = date;
            Pass = pass;
        }

        public string HumanName { get; set; }
        public int Gate { get; set; }
        public DateTime Date { get; set; }
        public bool Pass { get; set; }

    }
}
