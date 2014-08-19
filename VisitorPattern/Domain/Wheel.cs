using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Domain
{
    public class Wheel : ICarElement
    {
        public Wheel(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}