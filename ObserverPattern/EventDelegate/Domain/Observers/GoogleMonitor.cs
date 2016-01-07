using System;
using ObserverPattern.Domain;
using ObserverPattern.EventDelegate.Domain.EventArguments;
using ObserverPattern.EventDelegate.Domain.Subjects;

namespace ObserverPattern.EventDelegate.Domain.Observers
{
	public class GoogleMonitor
	{
		public GoogleMonitor(StockTicker stockTicker)
		{
			stockTicker.StockChange += StockChangeHandler;
		}

		private static void StockChangeHandler(object sender, StockChangeEventArgs e)
		{
			CheckFilter(e.Stock);
		}

		private static void CheckFilter(Stock value)
		{
			if (value.Symbol == "GOOG")
			{
				Console.WriteLine("Google's new price is: {0}", value.Price);
			}
		}
	}
}