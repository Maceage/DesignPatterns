using System;
using LazyLoadPattern.Domain;

namespace LazyLoadPattern.LazyInit.Domain
{
    public class OrderLazy
    {
		private readonly Lazy<Customer> _customerInitializer;

		public OrderLazy()
        {
            _customerInitializer = new Lazy<Customer>(() => new Customer());
        }

        public Customer Customer
        {
            get
            {
                return _customerInitializer.Value;
            }
        }

        public string PrintLabel()
        {
            string result = Customer.CompanyName;
            return result + Environment.NewLine + _customerInitializer.Value.Address;
        }
    }
}
