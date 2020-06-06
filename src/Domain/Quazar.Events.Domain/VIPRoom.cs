namespace Quazar.Events.Domain
{
    public class VIPRoom:Room
    {
        public VIPRoom(string title, int x, int y, Right right, Theme theme) : base(title, x, y, right, theme)
        {
        }
        
        public Limit Limit { get; set; }
    }
}