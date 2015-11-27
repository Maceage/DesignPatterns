using System;

namespace FacadePattern.Domain.Computer
{
    public class HardDrive
    {
        public void Spin()
        {
            Console.WriteLine("Hard drives spinning at a rapid 10RPM");
        }
    }
}