using System;
using RulesPattern.Domain;

namespace RulesPattern
{
	public class Program
	{
		private static readonly DiscountCalculator _discountCalculator = new DiscountCalculator();

		public static void Main(string[] args)
		{
			CalculateDiscountForNewCustomer();
			CalculateDiscountForVeteran();
			CalculateDiscountForSenior();
			CalculateDiscountForBirthday();
			CalculateDiscountFor5YearLoyalCustomer();
			CalculateDiscountFor5YearLoyalCustomerOnBirthday();

			Console.ReadLine();
		}

		private static void CalculateDiscountForNewCustomer()
		{
			var customer = new Customer();

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("New customer discount: ${0}", discount);
		}

		private static void CalculateDiscountForVeteran()
		{
			var customer = new Customer
			{
				IsVeteran = true,
				DateOfFirstPurchase = DateTime.Today.AddDays(-1)
			};

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("Veteran customer discount: ${0}", discount);
		}

		private static void CalculateDiscountForSenior()
		{
			var customer = new Customer {
				DateOfBirth = DateTime.Today.AddYears(-65).AddDays(-5),
				DateOfFirstPurchase = DateTime.Today.AddDays(-1)
			};

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("Senior customer discount: ${0}", discount);
		}

		private static void CalculateDiscountForBirthday()
		{
			var customer = new Customer
			{
				DateOfBirth = DateTime.Today,
				DateOfFirstPurchase = DateTime.Today.AddDays(-1)
			};

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("Birthday customer discount: ${0}", discount);
		}

		private static void CalculateDiscountFor5YearLoyalCustomer()
		{
			var customer = new Customer
			{
				DateOfBirth = DateTime.Today.AddDays(-5),
				DateOfFirstPurchase = DateTime.Today.AddYears(-5)
			};

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("5 year customer discount: ${0}", discount);
		}

		private static void CalculateDiscountFor5YearLoyalCustomerOnBirthday()
		{
			var customer = new Customer
			{
				DateOfBirth = DateTime.Today,
				DateOfFirstPurchase = DateTime.Today.AddYears(-5)
			};

			decimal discount = _discountCalculator.CalculateDiscountPercentage(customer);

			Console.WriteLine("5 year customer on birthday discount: ${0}", discount);
		}
	}
}
