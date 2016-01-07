using System;
using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain.Rules
{
	public class LoyalCustomerRule : IDiscountRule
	{
		private readonly decimal _discount;
		private readonly int _yearsAsCustomer;

		public LoyalCustomerRule(int yearsAsCustomer, decimal discount)
		{
			_yearsAsCustomer = yearsAsCustomer;
			_discount = discount;
		}

		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (customer.DateOfFirstPurchase.HasValue)
			{
				if (customer.DateOfFirstPurchase.Value.AddYears(_yearsAsCustomer) <= DateTime.Today)
				{
					var birthdayRule = new BirthdayDiscountRule();

					return _discount + birthdayRule.CalculateCustomerDiscount(customer);
				}
			}

			return 0;
		}
	}
}