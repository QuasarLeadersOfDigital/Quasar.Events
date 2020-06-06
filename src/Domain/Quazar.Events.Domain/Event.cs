using System;
using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Event
    {
        private readonly IList<Ticket> _tickets;
        
        public Event(Member moderator)
        {
            Moderator = moderator;
            _tickets = new List<Ticket>();
        }
        
        public Map Map { get; private set; }
        
        public Member Moderator { get; }

        public IEnumerable<Ticket> Tickets => _tickets;

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void SetMap(Map map)
        {
            Map = map;
        }
    }
}