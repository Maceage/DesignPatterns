using System;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Framework;

namespace UnitOfWorkPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			UnitOfWork unitOfWork = new UnitOfWork();

			Customer customer = new Customer();
			unitOfWork.Load(customer);

			Customer firstCustomer = new Customer { FirstName = "Steve", LastName = "Ballmer" };
			Customer secondCustomer = new Customer { FirstName = "Steve", LastName = "Wozniak" };

			unitOfWork.Add(firstCustomer);
			unitOfWork.Add(secondCustomer);

			Console.WriteLine("Changed entities...");
			unitOfWork.ListChanged();

			Console.WriteLine("Added entities...");
			unitOfWork.ListAdded();

			Console.WriteLine("Committing changes...");
			unitOfWork.Commit();

			Console.ReadLine();
		}
	}
}