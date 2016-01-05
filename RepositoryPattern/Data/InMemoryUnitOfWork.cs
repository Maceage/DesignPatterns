using System.Data.Objects;
using RepositoryPattern.Domain;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern.Data
{
	public class InMemoryUnitOfWork : IUnitOfWork
	{
		public InMemoryUnitOfWork()
		{
			Committed = false;
		}

		public IObjectSet<Employee> Employees
		{
			get;
			set;
		}

		public bool Committed { get; set; }

		public void Commit()
		{
			Committed = true;
		}
	}
}