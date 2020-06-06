using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class TicketType
    {
        private IEnumerable<Right> Rights { get; set; }
    }
}