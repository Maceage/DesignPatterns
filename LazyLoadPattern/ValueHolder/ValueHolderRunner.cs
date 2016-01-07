using System;
using LazyLoadPattern.ValueHolder.Domain;

namespace LazyLoadPattern.ValueHolder
{
	public static class ValueHolderRunner
	{
		public static void RunDemo()
		{
			NotLoadItemsUntilReferenced();
		}

		private static void NotLoadItemsUntilReferenced()
		{
			var order = new OrderFactory().CreateFromId(123);

			var items = order.Items;
			Console.WriteLine("Order Item Count: {0}", items.Count);
		}
	}
}