using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanLibraryBL
{
    public class ReportGenerator
    {

        private List<Event> _events;
        private HumanRepository _humanRepository;
        private GateRepositoryLocal _gateRepositoryLocal;

        public ReportGenerator()
        {
        }

        public ReportGenerator(List<Event> events, 
            HumanRepository humanRepository, 
            GateRepositoryLocal gateRepositoryLocal) 
        
        {
            _events = events;
            _humanRepository = humanRepository;
            _gateRepositoryLocal = gateRepositoryLocal;
        }
        List<ReportEvents> GenerateTotalEvents()

        {
            foreach(var oneEvent in _events)
            {
                ReportEvents reportEvent = new ReportEvents();
                reportEvent.HumanName = _humanRepository.Retrieve(oneEvent.HumanId).Name;
                reportEvent.Gate = _gateRepositoryLocal.Retrieve().Where(x => x.Id == 
                oneEvent.GateId).FirstOrDefault().Code;
                reportEvent.Date = oneEvent.Date;
                reportEvent.Pass = oneEvent.Pass;
                report.Add(reportEvent);
            }


            return report;
        }


    }
}
