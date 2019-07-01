using System;
namespace HumanLibraryBL
{
    public class ReportTotalHours
    {
        public ReportTotalHours()
        {
        }

            public ReportTotalHours(string humanName, int totalHours)
            {
                HumanName = humanName;
                TotalHours = totalHours;
            }

        public string HumanName { get; set; }
        public int TotalHours { get; set; }
       
    }
}

