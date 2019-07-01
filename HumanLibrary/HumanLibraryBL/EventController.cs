using System;
using System.Collections.Generic;

namespace HumanLibraryBL
{
    public class EventController
    {
        public List<Event> events = new List<Event>();
        public bool TryPass(int humanId, int gateId)
        {
            Event _event = new Event();
            _event.HumanId = humanId;
            _event.GateId = gateId;
            _event.Date = DateTime.Now;
            bool hasRight = false;

            Human human = new HumanRepository().Retrieve(humanId);
            foreach (var oneRight in human.GateIdRights)
            {
                if (oneRight == gateId)
                {

                    hasRight = true;
                }
            }
            _event.Pass = hasRight;
            events.Add(_event);
            return hasRight;
        
        }

    }
}


























































