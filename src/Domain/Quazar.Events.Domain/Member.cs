namespace Quazar.Events.Domain
{
    public class Member
    {
        public int UserId;
        
        public string Name;

        public MemberType MemberType { get; set; }

        public Member(int userid, string name, MemberType memberType)
        {
            UserId = userid;
            Name = name;
            MemberType = memberType;
        }
    }
}