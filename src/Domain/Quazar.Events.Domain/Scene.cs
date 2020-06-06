using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Scene:Place
    {
        public Scene(string title, int x, int y) : base("Scene", x, y)
        {
        }
        
        public IEnumerable<Member> Members { get; set; }

    }
}