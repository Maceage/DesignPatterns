using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Data;
using RepositoryPattern.Domain;

namespace RepositoryPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var employees = GenerateEmployeeList();

			InMemoryObjectSet<Employee> employeeObjectSet = new InMemoryObjectSet<Employee>(employees);
			InMemoryUnitOfWork inMemoryUnitOfWork = new InMemoryUnitOfWork();
			inMemoryUnitOfWork.Employees = employeeObjectSet;

			FindEmployee(inMemoryUnitOfWork);
			AddEmployee(inMemoryUnitOfWork);
			RemoveEmployee(inMemoryUnitOfWork);
			UpdateEmployee(inMemoryUnitOfWork);

			Console.ReadLine();
		}

		private static void FindEmployee(InMemoryUnitOfWork inMemoryUnitOfWork)
		{
			var employee = inMemoryUnitOfWork.Employees.Single(e => e.Name == "Lenny");

			Console.WriteLine(employee.ToString());

			inMemoryUnitOfWork.Commit();
		}

		private static void AddEmployee(InMemoryUnitOfWork inMemoryUnitOfWork)
		{
			var employee = new Employee { Name = "Bart Simpson" };
			inMemoryUnitOfWork.Employees.AddObject(employee);
			
			Console.WriteLine("Added {0}", employee);

			inMemoryUnitOfWork.Commit();
		}

		private static void RemoveEmployee(InMemoryUnitOfWork inMemoryUnitOfWork)
		{
			var employee = inMemoryUnitOfWork.Employees.Single(e => e.Name == "Lenny");
			inMemoryUnitOfWork.Employees.DeleteObject(employee);

			Console.WriteLine("Removed {0}", employee);

			inMemoryUnitOfWork.Commit();
		}

		private static void UpdateEmployee(InMemoryUnitOfWork inMemoryUnitOfWork)
		{
			var employee = inMemoryUnitOfWork.Employees.Single(e => e.Name == "Mr Burns");
			employee.Name = "Waylon Smithers";

			Console.WriteLine("Updated {0}", employee);

			inMemoryUnitOfWork.Commit();
		}

		private static IList<Employee> GenerateEmployeeList()
		{
			return new List<Employee>
			{
				new Employee { Name = "Homer Simpson" },
				new Employee { Name = "Mr Burns" },
				new Employee { Name = "Lenny" },
				new Employee { Name = "Carl" }
			};
		}
	}
}
