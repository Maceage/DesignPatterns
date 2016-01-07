using ObserverPattern.Domain;
using ObserverPattern.IObserver.Domain.Observers;
using ObserverPattern.IObserver.Domain.Subjects;

namespace ObserverPattern.IObserver
{
	// ReSharper disable once InconsistentNaming
	public static class IObserverRunner
	{
		public static void RunDemo()
		{
			StockTicker stockTicker = new StockTicker();

			GoogleMonitor googleMonitor = new GoogleMonitor();
			MicrosoftMonitor microsoftMonitor = new MicrosoftMonitor();

			using (stockTicker.Subscribe(googleMonitor))
			{
				using (stockTicker.Subscribe(microsoftMonitor))
				{
					foreach (var stock in SampleData.GetNext())
					{
						stockTicker.Stock = stock;
					}
				}
			}
		}
	}
}