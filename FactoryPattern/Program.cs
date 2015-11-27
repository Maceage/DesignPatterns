using System;
using FactoryPattern.Domain;
using FactoryPattern.Factory;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBlueSmurf();
            CreateRedSmurf();
            CreatePapaSmurf();

            Console.ReadLine();
        }

        private static void CreateBlueSmurf()
        {
            string carName = "blue";

            SmurfFactory factory = new SmurfFactory();

            ISmurf smurf = factory.CreateInstance(carName);

            smurf.Talk();
            smurf.Sleep();
        }

        private static void CreateRedSmurf()
        {
            string carName = "red";

            SmurfFactory factory = new SmurfFactory();

            ISmurf smurf = factory.CreateInstance(carName);

            smurf.Talk();
            smurf.Sleep();
        }

        private static void CreatePapaSmurf()
        {
            string carName = "papa";

            SmurfFactory factory = new SmurfFactory();

            ISmurf smurf = factory.CreateInstance(carName);

            smurf.Talk();
            smurf.Sleep();
        }
    }
}
