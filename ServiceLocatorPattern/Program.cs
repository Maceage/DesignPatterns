using System;
using ServiceLocatorPattern.Domain;
using ServiceLocatorPattern.Domain.Interfaces;
using ServiceLocatorPattern.Framework;

namespace ServiceLocatorPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RegisterServices();

			Consumer consumer = new Consumer();
			consumer.DoSomething(5);

			Console.ReadLine();
		}

		private static void RegisterServices()
		{
			ILogger logger = new Logger();
			ServiceLocator.AddService(logger);
		}
	}
}
