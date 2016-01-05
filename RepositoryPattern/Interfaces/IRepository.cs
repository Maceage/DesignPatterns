using System;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryPattern.Interfaces
{
	public interface IRepository<T> where T : class, IEntity
	{
		IQueryable<T> FindAll();
		IQueryable<T> Find(Expression<Func<T, bool>> predicate);
		T FindById(Guid id);
		void Add(T newEntity);
		void Remove(T entity);
	}
}