using System;

namespace FacadePattern.Domain.Computer
{
    public class Memory
    {
        public void Allocate()
        {
            Console.WriteLine("A beastly 640k has been allocated - ought to be enough for anyone");
        }
    }
}