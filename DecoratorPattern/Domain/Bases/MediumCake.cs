namespace DecoratorPattern.Domain.Bases
{
    public class MediumCake : Cake
    {
        public MediumCake()
        {
            Description = "Medium Cake";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 8.00;
        }
    }
}