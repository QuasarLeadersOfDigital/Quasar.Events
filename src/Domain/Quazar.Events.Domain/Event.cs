using System;
using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Event
    {
        public Map Map { get; set; }
        
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}