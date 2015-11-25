using System.Collections.Generic;
using BuilderPattern.Domain.Enumerations;

namespace BuilderPattern.Builders
{
    public class AudiCarBuilder : CarBuilder
    {
        public override void PrepareDriveType()
        {
            _car.DriveType = DriveType.FourByFour;
            _car.IsPetrol = true;
        }

        public override void ApplyBodyType()
        {
            _car.CarType = CarType.Suv;
        }

        public override void ApplyBadges()
        {
            _car.ManufacturerType = Manufacturer.Audi;
            _car.ModelName = "Q3";
        }

        public override void AddFeatures()
        {
            _car.HasSunroof = true;
            _car.HasAirConditioning = true;

            _car.Features = new List<string>
            {
                "Rear Parking Sensors",
                "Front Parking Sensors",
                "Adaptive Headlights",
                "Cruise Control"
            };
        }
    }
}