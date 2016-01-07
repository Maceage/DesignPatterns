using System;
using ObserverPattern.IObserver;
using ObserverPattern.Traditional;

namespace ObserverPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RunTraditionalExample();

			RunIObserverExample();

			RunEventDelegateExample();

			Console.ReadLine();
		}

		private static void RunTraditionalExample()
		{
			Console.WriteLine("--- Start Traditional Example ---");

			TraditionalRunner.RunDemo();

			Console.WriteLine("--- End Traditional Example ---");
		}

		private static void RunIObserverExample()
		{
			Console.WriteLine("--- Start IObserver Example ---");

			IObserverRunner.RunDemo();

			Console.WriteLine("--- End IObserver Example ---");
		}

		private static void RunEventDelegateExample()
		{
			Console.WriteLine("--- Start Event/Delegate Example ---");

			IObserverRunner.RunDemo();

			Console.WriteLine("--- End Event/Delegate Example ---");
		}
	}
}