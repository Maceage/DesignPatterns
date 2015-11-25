using System;
using System.Collections.Generic;
using BuilderPattern.Domain.Enumerations;

namespace BuilderPattern.Domain
{
    public class Car
    {
        public DriveType DriveType { get; set; }
        public Manufacturer ManufacturerType { get; set; }
        public string ModelName { get; set; }
        public CarType CarType { get; set; }

        public bool IsPetrol { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasSunroof { get; set; }

        public List<string> Features { get; set; }

        public void Display()
        {
            Console.WriteLine("Drive type: {0}", DriveType);
            Console.WriteLine("Manufacturer: {0}", ManufacturerType);
            Console.WriteLine("Car type: {0}", CarType);

            if (IsPetrol)
            {
                Console.WriteLine("Uses petrol");
            }

            if (HasSunroof)
            {
                Console.WriteLine("Has sunroof");
            }

            if (HasAirConditioning)
            {
                Console.WriteLine("Has air conditioning");
            }

            Console.WriteLine("Features:");

            foreach (var feature in Features)
            {
                Console.WriteLine("   {0}", feature);
            }
        }
    }
}