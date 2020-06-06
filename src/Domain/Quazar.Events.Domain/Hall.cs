namespace Quazar.Events.Domain
{
    public class Hall:Place
    {
        public Hall(string title, int x, int y, Right right) : base(title, x, y, right)
        {
        }
    }
}