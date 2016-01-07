using System;
using LazyLoadPattern.VirtualProxy.Domain;

namespace LazyLoadPattern.VirtualProxy
{
	public static class VirtualProxyRunner
	{
		public static void RunDemo()
		{
			PrintLabelWithOrderProxy();
		}

		private static void PrintLabelWithOrderProxy()
		{
			int testOrderId = 123;
			var order = new OrderFactory().CreateFromId(testOrderId);

			Console.WriteLine("Order ID: {0}", order.Id);

			string result = order.PrintLabel();

			Console.WriteLine("Order Label: {0}", result);
		}
	}
}