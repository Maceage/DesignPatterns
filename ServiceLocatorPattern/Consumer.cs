using ServiceLocatorPattern.Domain.Interfaces;
using ServiceLocatorPattern.Framework;

namespace ServiceLocatorPattern
{
	public class Consumer
	{
		private readonly ILogger _logger;

		public Consumer()
		{
			_logger = ServiceLocator.GetService<ILogger>();
		}

		public void DoSomething(int numberOfTimes)
		{
			for (int i = 0; i < numberOfTimes; i++)
			{
				_logger.LogMessage("Doing something!");
			}
		} 
	}
}