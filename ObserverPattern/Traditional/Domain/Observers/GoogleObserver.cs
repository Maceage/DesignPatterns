using System;
using ObserverPattern.Traditional.Domain.Subjects;
using ObserverPattern.Traditional.Framework;

namespace ObserverPattern.Traditional.Domain.Observers
{
	public class GoogleObserver : AbstractObserver
	{
		public GoogleObserver(StockTicker subj)
		{
			DataSource = subj;
			subj.Register(this);
		}

		private StockTicker DataSource { get; }

		public override void Update()
		{
			decimal price = DataSource.Stock.Price;
			string symbol = DataSource.Stock.Symbol;

			if (symbol == "GOOG")
			{
				Console.WriteLine("Google's new price is: {0}", price);
			}
		}
	}
}