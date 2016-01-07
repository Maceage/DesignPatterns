using System;
using LazyLoadPattern.Domain;

namespace LazyLoadPattern.VirtualProxy.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public virtual Customer Customer { get; set; }

        public string PrintLabel()
        {
            return Customer.CompanyName + Environment.NewLine + Customer.Address;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}