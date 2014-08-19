using System;
using VisitorPattern.Domain;
using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Visitors
{
    public class CarElementDoVisitor : ICarElementVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("Starting my engine");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Visiting my {0} wheel", wheel.Name);
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Moving my body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Starting my car");
        }
    }
}