namespace Quazar.Events.Domain
{
    public abstract class Place
    {
        public string Title { get; set; }

        public int XCoordinate;

        public int YCoordinate;
        
        protected Place(string title, int x, int y)
        {
            Title = title;
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}