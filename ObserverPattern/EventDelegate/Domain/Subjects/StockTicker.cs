using System;
using ObserverPattern.Domain;
using ObserverPattern.EventDelegate.Domain.EventArguments;

namespace ObserverPattern.EventDelegate.Domain.Subjects
{
	public class StockTicker
	{
		private Stock _stock;

		public event EventHandler<StockChangeEventArgs> StockChange;

		public Stock Stock
		{
			get
			{
				return _stock;
			}

			set
			{
				_stock = value;
				OnStockChange(new StockChangeEventArgs(_stock));
			}
		}

		protected virtual void OnStockChange(StockChangeEventArgs e)
		{
			if (StockChange != null)
			{
				StockChange(this, e);
			}
		}
	}
}