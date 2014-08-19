using VisitorPattern.Domain;
using VisitorPattern.Domain.Interfaces;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICarElement car = new Car();
            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());
        }
    }
}
