using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public abstract class CarBuilder
    {
        protected Car _car;

        public Car GetCar()
        {
            return _car;
        }

        public void CreateNewCar()
        {
            _car = new Car();
        }

        public abstract void PrepareDriveType();
        public abstract void ApplyBodyType();
        public abstract void ApplyBadges();
        public abstract void AddFeatures();
    }
}