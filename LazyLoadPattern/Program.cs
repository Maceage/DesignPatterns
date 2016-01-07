using System;
using LazyLoadPattern.Ghosts;
using LazyLoadPattern.LazyInit;
using LazyLoadPattern.ValueHolder;
using LazyLoadPattern.VirtualProxy;

namespace LazyLoadPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RunGhostsDemo();
			Console.WriteLine();

			RunLazyInitDemo();
			Console.WriteLine();

			RunValueHolderDemo();
			Console.WriteLine();

			RunVirtualProxyDemo();
			Console.WriteLine();

			Console.ReadLine();
		}

		private static void RunGhostsDemo()
		{
			Console.WriteLine("--- Start Ghosts Demo ---");

			GhostsRunner.RunDemo();

			Console.WriteLine("--- End Ghosts Demo ---");
		}

		private static void RunLazyInitDemo()
		{
			Console.WriteLine("--- Start Lazy Init Demo ---");

			LazyInitRunner.RunDemo();

			Console.WriteLine("--- End Lazy Init Demo ---");
		}

		private static void RunValueHolderDemo()
		{
			Console.WriteLine("--- Start Value Holder Demo ---");

			ValueHolderRunner.RunDemo();

			Console.WriteLine("--- End Value Holder Demo ---");
		}

		private static void RunVirtualProxyDemo()
		{
			Console.WriteLine("--- Start Virtual Proxy Demo ---");

			VirtualProxyRunner.RunDemo();

			Console.WriteLine("--- End Virtual Proxy Demo ---");
		}
	}
}
