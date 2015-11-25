using DecoratorPattern.Domain.Bases;

namespace DecoratorPattern.Domain.Toppings
{
    public class ChocolateChips : CakeDecorator
    {
        public ChocolateChips(Cake cake)
            : base(cake)
        {
            Description = "Chocolate Chips";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _cake.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _cake.CalculateCost() + 2.00;
        }
    }
}