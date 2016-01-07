using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain.Rules
{
	public class VeteranRule : IDiscountRule
	{
		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (customer.IsVeteran)
			{
				return 0.1m;
			}

			return 0;
		}
	}
}