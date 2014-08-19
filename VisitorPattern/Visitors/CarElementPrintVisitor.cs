using System;
using VisitorPattern.Domain;
using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Visitors
{
    public class CarElementPrintVisitor : ICarElementVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("Visiting engine");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Visiting {0} wheel", wheel.Name);
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Visiting body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Visiting car");
        }
    }
}