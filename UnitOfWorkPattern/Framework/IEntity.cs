using System;
using System.Collections.Generic;

namespace UnitOfWorkPattern.Framework
{
	public interface IEntity
	{
		Guid Id { get; set; }

		void Insert();
		void Update();
		IList<IEntity> Load();
	}
}