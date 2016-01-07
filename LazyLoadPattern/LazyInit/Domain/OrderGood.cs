using System;
using LazyLoadPattern.Domain;

namespace LazyLoadPattern.LazyInit.Domain
{
    public class OrderGood
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
            return Customer.CompanyName + Environment.NewLine + Customer.Address;
        }
    }
}