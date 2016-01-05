using System;
using RepositoryPattern.Interfaces;

namespace RepositoryPattern.Domain
{
	public class Employee : IEntity
	{
		public Employee()
		{
			Id = Guid.NewGuid();
		}

		public virtual Guid Id { get; private set; }
		public virtual string Name { get; set; }

		public override string ToString()
		{
			return string.Format("Name: {0} [{1}]", Name, Id);
		}
	}
}