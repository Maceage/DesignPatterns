using System;
using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain.Rules
{
	public class BirthdayDiscountRule : IDiscountRule
	{
		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (customer.DateOfBirth.Month == DateTime.Today.Month &&
				customer.DateOfBirth.Day == DateTime.Today.Day)
			{
				return 0.10m;
			}

			return 0;
		}
	}
}