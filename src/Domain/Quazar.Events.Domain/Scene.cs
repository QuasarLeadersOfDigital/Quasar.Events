using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Scene:Place
    {
        public Scene(string title, int x, int y, Right right) : base("Scene", x, y, right)
        {
        }
        
        public IEnumerable<Member> Members { get; set; }

    }
}