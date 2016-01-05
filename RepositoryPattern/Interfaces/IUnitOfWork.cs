using System.Data.Objects;
using RepositoryPattern.Domain;

namespace RepositoryPattern.Interfaces
{
	public interface IUnitOfWork
	{
		IObjectSet<Employee> Employees { get; }
		void Commit();
	}
}