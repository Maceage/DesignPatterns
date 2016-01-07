using System;
using StatePattern.Framework;

namespace StatePattern.Domain
{
	public class WorkItem : ICommands
	{
		private ICommands _stateCommands;
		private string _state;

		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public string State
		{
			get
			{
				return _state;
			}

			set
			{
				_state = value.ToLower();

				if (_state == "proposed")
				{
					_stateCommands = new States.Proposed(this);
				}

				if (_state == "active")
				{
					_stateCommands = new States.Active(this);
				}

				if (_state == "resolved")
				{
					_stateCommands = new States.Resolved(this);
				}

				if (_state == "closed")
				{
					_stateCommands = new States.Closed(this);
				}
			}
		}

		internal static WorkItem Create()
		{
			var wi = new WorkItem();
			wi.Id = -1;
			wi.State = "Proposed";
			return wi;
		}

		public bool Delete()
		{
			bool canDelete = _stateCommands.Delete();

			if (canDelete)
			{
				Console.WriteLine("Work item deleted!");
			}

			return canDelete;
		}

		public void Edit(string title, string desc)
		{
			_stateCommands.Edit(title, desc);
		}

		public void Print()
		{
			_stateCommands.Print();
		}

		public void SetState(string newstate)
		{
			_stateCommands.SetState(newstate.ToLower());
		}
	}
}