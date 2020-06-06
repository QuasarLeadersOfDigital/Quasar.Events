using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class TicketType
    {
        public IEnumerable<Right> Rights { get; set; }
    }
}