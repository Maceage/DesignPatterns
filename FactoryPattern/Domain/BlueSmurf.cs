using System;

namespace FactoryPattern.Domain
{
    public class BlueSmurf : ISmurf
    {
        public void Talk()
        {
            Console.WriteLine("Blue smurf has something to say!");
        }

        public void Sleep()
        {
            Console.WriteLine("Blue smurf is now sleeping");
        }
    }
}