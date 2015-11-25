namespace DecoratorPattern.Domain.Bases
{
    public class LargeCake : Cake
    {
        public LargeCake()
        {
            Description = "Large Cake";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 10.00;
        }
    }
}