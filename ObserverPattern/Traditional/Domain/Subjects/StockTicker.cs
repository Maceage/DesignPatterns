using ObserverPattern.Domain;
using ObserverPattern.Traditional.Framework;

namespace ObserverPattern.Traditional.Domain.Subjects
{
	public class StockTicker : AbstractSubject
	{
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
				Notify();
			}
		}
	}
}