using DecoratorPattern.Domain.Bases;

namespace DecoratorPattern.Domain.Toppings
{
    public class CakeDecorator : Cake
    {
        protected Cake _cake;

        public CakeDecorator(Cake cake)
        {
            _cake = cake;
        }

        public override string GetDescription()
        {
            return _cake.Description;
        }

        public override double CalculateCost()
        {
            return _cake.CalculateCost();
        }
    }
}