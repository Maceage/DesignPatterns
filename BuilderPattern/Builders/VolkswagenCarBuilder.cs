using System.Collections.Generic;
using BuilderPattern.Domain.Enumerations;

namespace BuilderPattern.Builders
{
    public class VolkswagenCarBuilder : CarBuilder
    {
        public override void PrepareDriveType()
        {
            _car.DriveType = DriveType.FrontWheelDrive;
            _car.IsPetrol = false;
        }

        public override void ApplyBodyType()
        {
            _car.CarType = CarType.Sedan;
        }

        public override void ApplyBadges()
        {
            _car.ManufacturerType = Manufacturer.Volkswagen;
            _car.ModelName = "Passat";
        }

        public override void AddFeatures()
        {
            _car.HasSunroof = false;
            _car.HasAirConditioning = true;

            _car.Features = new List<string>
            {
                "Rear Parking Sensors",
                "Cruise Control"
            };
        }
    }
}