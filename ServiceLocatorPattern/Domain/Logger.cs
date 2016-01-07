using System;
using ServiceLocatorPattern.Domain.Interfaces;

namespace ServiceLocatorPattern.Domain
{
	public class Logger : ILogger
	{
		public void LogMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}