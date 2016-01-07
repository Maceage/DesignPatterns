using System;

namespace RulesPattern.Domain
{
	public class Customer
	{
		public DateTime? DateOfFirstPurchase { get; set; }
		public DateTime DateOfBirth { get; set; }
		public bool IsVeteran { get; set; }
	}
}