using System.Collections.Generic;

namespace FlyweightPattern.Domain
{
    public class Menu
    {
        private readonly Dictionary<string, CoffeeFlavour> _flavours = new Dictionary<string, CoffeeFlavour>();

        public CoffeeFlavour Lookup(string flavourName)
        {
            if (!_flavours.ContainsKey(flavourName))
            {
                _flavours.Add(flavourName, new CoffeeFlavour(flavourName));
            }

            return _flavours[flavourName];
        }

        public int TotalCoffeeFlavoursMade
        {
            get
            {
                return _flavours.Count;
            }
        }
    }
}