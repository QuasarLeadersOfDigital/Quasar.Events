using System.Collections;
using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Room:Place
    {

        public VIPRoom VipRoom { get; set; }
        
        public IEnumerable<Member> Members { get; set; }


        public Room(string title, int x, int y) : base(title, x, y)
        {
        }
    }
    
    
}