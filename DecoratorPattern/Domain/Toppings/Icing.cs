using DecoratorPattern.Domain.Bases;

namespace DecoratorPattern.Domain.Toppings
{
    public class Icing : CakeDecorator
    {
        public Icing(Cake cake)
            : base(cake)
        {
            Description = "Icing";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _cake.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _cake.CalculateCost() + 1.25;
        }
    }
}