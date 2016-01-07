using ObserverPattern.Domain;
using ObserverPattern.Traditional.Domain.Observers;
using ObserverPattern.Traditional.Domain.Subjects;

namespace ObserverPattern.Traditional
{
	public static class TraditionalRunner
	{
		public static void RunDemo()
		{
			StockTicker stockTicker = new StockTicker();

			//// ReSharper disable UnusedVariable

			GoogleObserver googleObserver = new GoogleObserver(stockTicker);
			MicrosoftObserver microsoftObserver = new MicrosoftObserver(stockTicker);

			//// ReSharper restore UnusedVariable

			foreach (var stock in SampleData.GetNext())
			{
				stockTicker.Stock = stock;
			}
		}
	}
}