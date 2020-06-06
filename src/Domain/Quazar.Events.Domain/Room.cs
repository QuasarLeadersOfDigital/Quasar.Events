using System.Collections;
using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Room:Place
    {

        public VIPRoom VipRoom { get; set; }
        
        public IEnumerable<Member> Members { get; set; }

        public Theme Theme { get; }

        public Room(string title, int x, int y, Right right, Theme theme) : base(title, x, y, right)
        {
            Theme = theme;
        }
    }
    
    
}