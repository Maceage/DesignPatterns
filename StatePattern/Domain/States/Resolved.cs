using System;
using StatePattern.Framework;

namespace StatePattern.Domain.States
{
	public class Resolved : BaseState, ICommands
	{
		private readonly WorkItem _owner;

		public Resolved(WorkItem owner)
		{
			_owner = owner;
		}

		public bool Delete()
		{
			Console.WriteLine("Work Item is already resolved. Cannot Delete.");
			return false;
		}

		public void Edit(string title, string desc)
		{
			_owner.Title = title;
			_owner.Description = desc;
		}

		public void Print()
		{
			Print(_owner);
		}

		public void SetState(string state)
		{
			switch (state)
			{
				case "resolved":
					Console.WriteLine("Work Item is already resolved.");
					break;
				case "active":
				case "closed":
					_owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in an resolved state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}