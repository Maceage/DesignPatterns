using System.Collections.Generic;
using BuilderPattern.Domain.Enumerations;

namespace BuilderPattern.Builders
{
    public class BmwCarBuilder : CarBuilder
    {
        public override void PrepareDriveType()
        {
            _car.DriveType = DriveType.RearWheelDrive;
            _car.IsPetrol = true;
        }

        public override void ApplyBodyType()
        {
            _car.CarType = CarType.Coupe;
        }

        public override void ApplyBadges()
        {
            _car.ManufacturerType = Manufacturer.Bmw;
            _car.ModelName = "3 Series";
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