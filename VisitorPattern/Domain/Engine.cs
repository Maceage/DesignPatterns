namespace VisitorPattern.Domain
{
    using VisitorPattern.Domain.Interfaces;

    public class Engine : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}