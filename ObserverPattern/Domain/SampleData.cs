using System.Collections.Generic;

namespace ObserverPattern.Domain
{
	public class SampleData
	{
		private static readonly decimal[] _samplePrices = { 10.00m, 10.25m, 555.55m, 9.50m, 9.03m, 500.00m, 499.99m, 10.10m };
		private static readonly string[] _sampleStocks = { "MSFT", "MSFT", "GOOG", "MSFT", "MSFT", "GOOG", "GOOG", "MSFT" };

		public static IEnumerable<Stock> GetNext()
		{
			for (int i = 0; i < _samplePrices.Length; i++)
			{
				Stock s = new Stock();

				s.Symbol = _sampleStocks[i];
				s.Price = _samplePrices[i];

				yield return s;
			}
		}
	}
}