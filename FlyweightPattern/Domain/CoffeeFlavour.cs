namespace FlyweightPattern.Domain
{
    public class CoffeeFlavour
    {
        private readonly string _name;

        public CoffeeFlavour(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}