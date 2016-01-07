using System.Collections;

namespace ServiceLocatorPattern.Framework
{
	public class ServiceLocator
	{
		private static readonly Hashtable _services = new Hashtable();

		public static void AddService<T>(T service)
		{
			_services.Add(typeof(T).Name, service);
		}

		public static void AddService<T>(string name, T service)
		{
			_services.Add(name, service);
		}

		public static T GetService<T>()
		{
			return (T)GetService<T>(typeof(T).Name);
		}

		public static object GetService<T>(string serviceName)
		{
			return (T)_services[serviceName];
		}
	}
}