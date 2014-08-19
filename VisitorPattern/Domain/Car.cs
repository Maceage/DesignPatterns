using System.Collections.Generic;

using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Domain
{
    public class Car : ICarElement
    {
        private readonly IList<ICarElement> _elements;

        public Car()
        {
            _elements = new List<ICarElement>();
            _elements.Add(new Wheel("Front left"));
            _elements.Add(new Wheel("Front right"));
            _elements.Add(new Wheel("Back left"));
            _elements.Add(new Wheel("Back right"));
            _elements.Add(new Body());
            _elements.Add(new Engine());
        }

        public void Accept(ICarElementVisitor visitor)
        {
            foreach (ICarElement carElement in _elements)
            {
                carElement.Accept(visitor);
            }

            visitor.Visit(this);
        }
    }
}