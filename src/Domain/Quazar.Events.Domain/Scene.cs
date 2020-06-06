using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Scene:Place
    {
        public IEnumerable<Member> Members { get; set; }
    }
}