namespace DecoratorPattern.Domain.Bases
{
    public class SmallCake : Cake
    {
        public SmallCake()
        {
            Description = "Small Cake";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 5.00;
        }
    }
}