using System;
using FacadePattern.Domain;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComputerFacade computerFacade = new ComputerFacade();
            computerFacade.Start();

            Console.ReadKey();
        }
    }
}
