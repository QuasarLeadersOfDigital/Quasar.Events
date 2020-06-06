using System.Collections.Generic;

namespace Quazar.Events.Domain
{
    public class Map
    {
        private readonly List<Place> _places;

        public Map()
        {
            _places = new List<Place>();
        }
        
        IEnumerable<Place> Places => _places;
        
        public void AddPlace(Place place)
        {
            _places.Add(place);
        }

        public void DeletePlace(Place place)
        {
            _places.Remove(place);
        }
    }
    
    
}