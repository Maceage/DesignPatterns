using System;
using ObserverPattern.Domain;

namespace ObserverPattern.EventDelegate.Domain.EventArguments
{
	public class StockChangeEventArgs : EventArgs
	{
		public StockChangeEventArgs(Stock s)
		{
			Stock = s;
		}

		public Stock Stock { get; set; }
	}
}