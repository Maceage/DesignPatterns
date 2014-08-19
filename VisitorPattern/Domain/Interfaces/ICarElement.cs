namespace VisitorPattern.Domain.Interfaces
{
    public interface ICarElement
    {
        void Accept(ICarElementVisitor visitor);
    }
}