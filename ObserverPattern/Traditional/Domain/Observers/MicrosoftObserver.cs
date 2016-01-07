using System;
using ObserverPattern.Traditional.Domain.Subjects;
using ObserverPattern.Traditional.Framework;

namespace ObserverPattern.Traditional.Domain.Observers
{
	public class MicrosoftObserver : AbstractObserver
	{
		public MicrosoftObserver(StockTicker subj)
		{
			DataSource = subj;
			subj.Register(this);
		}

		private StockTicker DataSource { get; }

		public override void Update()
		{
			decimal price = DataSource.Stock.Price;
			string symbol = DataSource.Stock.Symbol;

			if (symbol == "MSFT" && price > 10.00m)
			{
				Console.WriteLine("Microsoft has reached the target price: {0}", price);
			}
		}
	}
}