using System.Collections.Generic;

namespace ObserverPattern.Traditional.Framework
{
	public abstract class AbstractSubject
	{
		private readonly List<AbstractObserver> _observers = new List<AbstractObserver>();

		public void Register(AbstractObserver observer)
		{
			_observers.Add(observer);
		}

		public void Unregister(AbstractObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (var o in _observers)
			{
				o.Update();
			}
		}
	}
}