using System;

namespace FactoryPattern.Domain
{
    public class RedSmurf : ISmurf
    {
        public void Talk()
        {
            Console.WriteLine("Red smurf is talking!");
        }

        public void Sleep()
        {
            Console.WriteLine("Bye bye! Red smurf is sleeping");
        }
    }
}