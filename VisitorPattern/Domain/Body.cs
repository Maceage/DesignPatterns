using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Domain
{
    public class Body : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}