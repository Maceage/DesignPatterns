using System;
using System.Collections.Generic;
using System.Transactions;

namespace UnitOfWorkPattern.Framework
{
	public class UnitOfWork
	{
		private readonly IList<IEntity> _added = new List<IEntity>();
		private IList<IEntity> _changed = new List<IEntity>();

		public void Add(IEntity entity)
		{
			_added.Add(entity);
		}

		public void Load(IEntity entity)
		{
			_changed = entity.Load() as List<IEntity>;
		}

		public void Commit()
		{
			using (TransactionScope transactionScope = new TransactionScope())
			{
				foreach (IEntity entity in _changed)
				{
					entity.Update();
				}

				foreach (IEntity entity in _added)
				{
					entity.Insert();
				}

				transactionScope.Complete();
			}
		}

		public void ListAdded()
		{
			foreach (IEntity entity in _added)
			{
				Console.WriteLine("Entity '{0}' added", entity);
			}
		}

		public void ListChanged()
		{
			foreach (IEntity entity in _changed)
			{
				Console.WriteLine("Entity '{0}' changed", entity);
			}
		}
	}
}