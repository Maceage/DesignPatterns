using System;
using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain.Rules
{
	public class SeniorRule : IDiscountRule
	{
		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
			{
				return .05m;
			}

			return 0;
		}
	}
}