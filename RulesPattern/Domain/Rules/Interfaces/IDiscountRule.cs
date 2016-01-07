namespace RulesPattern.Domain.Rules.Interfaces
{
	public interface IDiscountRule
	{
		decimal CalculateCustomerDiscount(Customer customer);
	}
}