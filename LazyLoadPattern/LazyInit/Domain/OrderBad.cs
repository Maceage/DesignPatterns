using System;
using LazyLoadPattern.Domain;

namespace LazyLoadPattern.LazyInit.Domain
{
    public class OrderBad
    {
        private Customer _customer;

        public Customer Customer
        {
            get
            {
	            return _customer ?? (_customer = new Customer());
            }
        }

        public string PrintLabel()
        {
            string result = _customer.CompanyName;
            return result + Environment.NewLine + Customer.Address;
        }
    }
}