using System.Collections.Generic;

using VisitorPattern.Domain.Interfaces;

namespace VisitorPattern.Domain
{
    public class Car : ICarElement
    {
        private IList<ICarElement> _elements;

        public Car(IList<ICarElement> elements)
        {
            _elements = elements;
        }

        public void Accept(ICarElementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}