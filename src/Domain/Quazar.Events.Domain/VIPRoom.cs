namespace Quazar.Events.Domain
{
    public class VIPRoom:Room
    {
        public VIPRoom(string title, int x, int y) : base(title, x, y)
        {
        }
        
        public Limit Limit { get; set; }
    }
}