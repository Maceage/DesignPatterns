using DecoratorPattern.Domain.Bases;

namespace DecoratorPattern.Domain.Toppings
{
    public class Cherries : CakeDecorator
    {
        public Cherries(Cake cake)
            : base(cake)
        {
            Description = "Cherries";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _cake.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _cake.CalculateCost() + 1.00;
        }
    }
}