using System;
using StatePattern.Framework;

namespace StatePattern.Domain.States
{
	public class Proposed : BaseState, ICommands
	{
		private readonly WorkItem _owner;

		public Proposed(WorkItem owner)
		{
			_owner = owner;
		}

		public bool Delete()
		{
			return true;
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
				case "proposed":
					Console.WriteLine("Work Item is already proposed.");
					break;
				case "active":
					_owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in a proposed state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}