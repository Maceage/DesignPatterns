using System;
using LazyLoadPattern.LazyInit.Domain;

namespace LazyLoadPattern.LazyInit
{
	public static class LazyInitRunner
	{
		public static void RunDemo()
		{
			PrintLabelWithGoodOrder();
			PrintLabelWithBadOrder();
			PrintLabelWithLazyOrder();
		}

		private static void PrintLabelWithGoodOrder()
		{
			var order = new OrderGood();

			var result = order.PrintLabel();

			Console.WriteLine(result);
		}

		private static void PrintLabelWithBadOrder()
		{
			var order = new OrderBad();

			string result = null;

			try
			{
				result = order.PrintLabel();
			}
			catch (Exception)
			{
				Console.WriteLine("Bad order!");
			}

			Console.WriteLine(result);
		}

		private static void PrintLabelWithLazyOrder()
		{
			var order = new OrderLazy();

			var result = order.PrintLabel();

			Console.WriteLine(result);
		}
	}
}