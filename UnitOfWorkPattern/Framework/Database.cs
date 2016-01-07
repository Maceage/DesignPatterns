using System;

namespace UnitOfWorkPattern.Framework
{
	public static class Database
	{
		public static void Insert(IEntity entity)
		{
			Console.WriteLine("Inserting entity {0} into database...", entity);
		}

		public static void Update(IEntity entity)
		{
			Console.WriteLine("Updating entity {0} in database...", entity);
		}
	}
}