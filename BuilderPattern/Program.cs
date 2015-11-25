using System;
using BuilderPattern.Builders;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildBmwCar();

            BuildAudiCar();

            BuildVolkswagenCar();

            Console.ReadKey();
        }

        private static void BuildBmwCar()
        {
            Console.WriteLine("-> Start BMW car builder <-");

            var carMaker = new CarMaker(new BmwCarBuilder());
            carMaker.BuildCar();
            var car1 = carMaker.GetCar();

            car1.Display();

            Console.WriteLine("-> End BMW car builder <-");
            Console.WriteLine();
        }

        private static void BuildAudiCar()
        {
            Console.WriteLine("-> Start Audi car builder <-");

            var carMaker2 = new CarMaker(new AudiCarBuilder());
            carMaker2.BuildCar();
            var car2 = carMaker2.GetCar();

            car2.Display();

            Console.WriteLine("-> End Audi car builder <-");
            Console.WriteLine();
        }

        private static void BuildVolkswagenCar()
        {
            Console.WriteLine("-> Start Volkswagen car builder <-");

            var carMaker3 = new CarMaker(new VolkswagenCarBuilder());
            carMaker3.BuildCar();
            var car3 = carMaker3.GetCar();

            car3.Display();

            Console.WriteLine("-> Start Volkswagen car builder <-");
            Console.WriteLine();
        }
    }
}
