using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public class CarMaker
    {
        private readonly CarBuilder _builder;

        public CarMaker(CarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCar()
        {
            _builder.CreateNewCar();
            _builder.PrepareDriveType();
            _builder.ApplyBodyType();
            _builder.ApplyBadges();
            _builder.AddFeatures();
        }

        public Car GetCar()
        {
            return _builder.GetCar();
        }
    }
}