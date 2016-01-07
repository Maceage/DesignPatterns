using ObserverPattern.Domain;
using ObserverPattern.EventDelegate.Domain.Observers;
using ObserverPattern.EventDelegate.Domain.Subjects;

namespace ObserverPattern.EventDelegate
{
	public class EventDelegateRunner
	{
		public static void RunDemo()
		{
			StockTicker stockTicker = new StockTicker();

			//// ReSharper disable UnusedVariable
			
			GoogleMonitor googleMonitor = new GoogleMonitor(stockTicker);
			MicrosoftMonitor microsoftMonitor = new MicrosoftMonitor(stockTicker);

			//// ReSharper restore UnusedVariable

			foreach (var stock in SampleData.GetNext())
			{
				stockTicker.Stock = stock;
			}
		}
	}
}