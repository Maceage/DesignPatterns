using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain.Rules
{
	public class FirstTimeCustomerRule : IDiscountRule
	{
		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (!customer.DateOfFirstPurchase.HasValue)
			{
				return 0.15m;
			}

			return 0;
		}
	}
}