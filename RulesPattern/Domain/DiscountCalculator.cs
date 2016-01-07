using System;
using System.Collections.Generic;
using RulesPattern.Domain.Rules;
using RulesPattern.Domain.Rules.Interfaces;

namespace RulesPattern.Domain
{
	public class DiscountCalculator
	{
		private readonly List<IDiscountRule> _rules = new List<IDiscountRule>();

		public DiscountCalculator()
		{
			_rules.Add(new BirthdayDiscountRule());
			_rules.Add(new SeniorRule());
			_rules.Add(new VeteranRule());
			_rules.Add(new LoyalCustomerRule(1, 0.10m));
			_rules.Add(new LoyalCustomerRule(5, 0.12m));
			_rules.Add(new LoyalCustomerRule(10, 0.20m));
			_rules.Add(new FirstTimeCustomerRule());
		}

		public decimal CalculateDiscountPercentage(Customer customer)
		{
			decimal discount = 0;

			foreach (var rule in _rules)
			{
				discount = Math.Max(rule.CalculateCustomerDiscount(customer), discount);
			}

			return discount;
		}
	}
}