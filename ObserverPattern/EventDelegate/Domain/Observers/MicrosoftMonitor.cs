using System;
using ObserverPattern.Domain;
using ObserverPattern.EventDelegate.Domain.EventArguments;
using ObserverPattern.EventDelegate.Domain.Subjects;

namespace ObserverPattern.EventDelegate.Domain.Observers
{
	public class MicrosoftMonitor
	{
		public MicrosoftMonitor(StockTicker stockTicker)
		{
			stockTicker.StockChange += StockChangeHandler;
		}

		private static void StockChangeHandler(object sender, StockChangeEventArgs e)
		{
			CheckFilter(e.Stock);
		}

		private static void CheckFilter(Stock value)
		{
			if (value.Symbol == "MSFT" && value.Price > 10.00m)
			{
				Console.WriteLine("Microsoft has reached the target price: {0}", value.Price);
			}
		}
	}
}