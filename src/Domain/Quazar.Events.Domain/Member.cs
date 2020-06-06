namespace Quazar.Events.Domain
{
    public class Member
    {
        public int UserId { get; }
        
        public string Name { get; }
        
        public Ticket Ticket { get; }
        
        public MemberType MemberType { get; }

        public Member(int userid, string name, MemberType memberType, Ticket ticket)
        {
            UserId = userid;
            Name = name;
            MemberType = memberType;
            Ticket = ticket;
        }
    }
}