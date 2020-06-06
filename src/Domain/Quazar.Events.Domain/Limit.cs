namespace Quazar.Events.Domain
{
    public class Limit
    {
        public int MaximumAmount;

        public Limit(int maximumAmount)
        {
            MaximumAmount = maximumAmount;
        }
    }
}