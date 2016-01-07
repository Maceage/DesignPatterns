using System;
using System.Collections.Generic;
using ObserverPattern.Domain;

namespace ObserverPattern.IObserver.Domain.Subjects
{
	public class StockTicker : IObservable<Stock>
	{
		private readonly List<IObserver<Stock>> _observers = new List<IObserver<Stock>>();

		private Stock _stock;

		public Stock Stock
		{
			get
			{
				return _stock;
			}

			set
			{
				_stock = value;
				Notify(_stock);
			}
		}

		private void Notify(Stock s)
		{
			foreach (var o in _observers)
			{
				if (s.Symbol == null || s.Price < 0)
				{
					o.OnError(new Exception("Bad Stock Data"));
				}
				else
				{
					o.OnNext(s);
				}
			}
		}

		public IDisposable Subscribe(IObserver<Stock> observer)
		{
			if (!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}

			return new Unsubscriber(_observers, observer);
		}

		private class Unsubscriber : IDisposable
		{
			private readonly List<IObserver<Stock>> _observers;
			private readonly IObserver<Stock> _observer;

			public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
			{
				_observers = observers;
				_observer = observer;
			}

			public void Dispose()
			{
				if (_observer != null && _observers.Contains(_observer))
				{
					_observers.Remove(_observer);
				}
			}
		}
	}
}