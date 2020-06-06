using System.Collections.Generic;
using System.Linq;

namespace Quazar.Events.Domain
{
    public abstract class Place
    {

        private readonly IList<Member> _members;

        public IEnumerable<Member> Members => _members;
        public string Title { get; }

        public int XCoordinate;

        public int YCoordinate;
        
        public Right Right { get; }
        
        protected Place(string title, int x, int y, Right right)
        {
            Title = title;
            XCoordinate = x;
            YCoordinate = y;
            Right = right;
        }

        public void Join(Member member)
        {
            if (member.Ticket.TicketType.Rights.Any(r => r.GuestAccess))
            {
                _members.Add(member);
            }
            
            //TODO: except right access
        }
    }
}