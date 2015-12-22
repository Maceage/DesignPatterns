using System;
using System.Collections;
using IteratorPattern.Domain;

namespace IteratorPattern
{
	public static class IteratorExamples
	{
		public static void RunAllExamples()
		{
			ArrayIterationExample();
			EnumeratorExample();
			ForEachExample();
			ListIterationExample();
		}

		public static void ArrayIterationExample()
		{
			Console.WriteLine("--- Array iteration example start ---");

			var stocks = new[] { "MSFT", "GOOG", "AAPL" };

			for (int i = 0; i < stocks.Length; i++)
			{
				Console.WriteLine(stocks[i]);
			}

			Console.WriteLine("--- Array iteration example end ---");
		}

		public static void EnumeratorExample()
		{
			Console.WriteLine("--- Enumeration iteration example start ---");

			var stocks = new[] { "MSFT", "GOOG", "AAPL" };
			IEnumerator enumerator = stocks.GetEnumerator();

			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}

			Console.WriteLine("--- Enumeration iteration example end ---");
		}

		public static void ForEachExample()
		{
			Console.WriteLine("--- For each iteration example start ---");

			var stocks = new[] { "MSFT", "GOOG", "AAPL" };

			foreach (string stock in stocks)
			{
				Console.WriteLine(stock);
			}

			Console.WriteLine("--- For each iteration example end ---");
		}

		public static void ListIterationExample()
		{
			Console.WriteLine("--- List iteration example start ---");

			var stocks = new SuperCollection { "MSFT", "GOOG", "AAPL" };

			for (int i = 0; i < stocks.Count; i++)
			{
				Console.WriteLine(stocks.Get(i));
			}

			Console.WriteLine("--- List iteration example end ---");
		}
	}
}