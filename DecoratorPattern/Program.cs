using System;
using DecoratorPattern.Domain.Bases;
using DecoratorPattern.Domain.Toppings;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildLargeCake();
            BuildMediumCake();
            BuildSmallCake();

            Console.ReadKey();
        }

        private static void BuildLargeCake()
        {
            Cake largeCake = new LargeCake();
            largeCake = new Icing(largeCake);
            largeCake = new Cherries(largeCake);
            largeCake = new ChocolateChips(largeCake);

            Console.WriteLine(largeCake.GetDescription());
            Console.WriteLine("{0:C2}", largeCake.CalculateCost());
        }

        private static void BuildMediumCake()
        {
            Cake mediumCake = new MediumCake();
            mediumCake = new Icing(mediumCake);
            mediumCake = new Cherries(mediumCake);

            Console.WriteLine(mediumCake.GetDescription());
            Console.WriteLine("{0:C2}", mediumCake.CalculateCost());
        }

        private static void BuildSmallCake()
        {
            Cake smallCake = new SmallCake();
            smallCake = new Icing(smallCake);

            Console.WriteLine(smallCake.GetDescription());
            Console.WriteLine("{0:C2}", smallCake.CalculateCost());
        }
    }
}
