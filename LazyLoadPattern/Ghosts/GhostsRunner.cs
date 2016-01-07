using System;
using System.Linq;
using LazyLoadPattern.Ghosts.Domain;

namespace LazyLoadPattern.Ghosts
{
	public static class GhostsRunner
	{
		public static void RunDemo()
		{
			LoadItselfOnlyOnceOnPropertyAccess();
			LoadItemsInSingleCallOnPropertyAccess();
		}

		private static void LoadItselfOnlyOnceOnPropertyAccess()
		{
			int orderId = 123;
			var order = new TestOrderWrapper(orderId);

			Console.WriteLine("Order ID: {0}", order.Id);
			Console.WriteLine("Order WasLoadCalled: {0}", order.WasLoadCalled);
			Console.WriteLine("Order RowDataCount: {0}", order.GetDataRowCount);

			// ReSharper disable once UnusedVariable
			var shipMethod = order.ShipMethod;
			Console.WriteLine("Order WasLoadCalled: {0}", order.WasLoadCalled);
			Console.WriteLine("Order RowDataCount: {0}", order.GetDataRowCount);

			// ReSharper disable once UnusedVariable
			var customer = order.Customer;
			Console.WriteLine("Order WasLoadCalled: {0}", order.WasLoadCalled);
			Console.WriteLine("Order RowDataCount: {0}", order.GetDataRowCount);
		}

		private static void LoadItemsInSingleCallOnPropertyAccess()
		{
			var order = new Order(123);

			int itemCount = order.Items.Count();
			Console.WriteLine("Order Item Count: {0}", itemCount);
		}
	}
}