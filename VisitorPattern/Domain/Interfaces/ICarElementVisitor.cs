namespace VisitorPattern.Domain.Interfaces
{
    public interface ICarElementVisitor
    {
        void Visit(Engine engine);

        void Visit(Wheel wheel);

        void Visit(Body body);

        void Visit(Car car);
    }
}
