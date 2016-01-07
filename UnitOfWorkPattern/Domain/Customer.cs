using System;
using System.Collections.Generic;
using UnitOfWorkPattern.Framework;

namespace UnitOfWorkPattern.Domain
{
	public class Customer : IEntity
	{
		public Customer()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public void Insert()
		{
			Database.Insert(this);
		}

		public void Update()
		{
			Database.Update(this);
		}

		public IList<IEntity> Load()
		{
			return new List<IEntity>
			{
				new Customer { FirstName = "Bill", LastName = "Gates" },
				new Customer { FirstName = "Steve", LastName = "Jobs" },
				new Customer { FirstName = "Elon", LastName = "Musk" }
			};
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", FirstName, LastName);
		}
	}
}