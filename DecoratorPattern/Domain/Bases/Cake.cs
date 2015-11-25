namespace DecoratorPattern.Domain.Bases
{
    public abstract class Cake
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract double CalculateCost();
    }
}