using System;
using ProxyPattern.Domain;

namespace ProxyPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Attempting to drive car without any age check...");

			Car car = new Car();
			car.DriveCar();

			Console.WriteLine("Attempting to drive proxy car as a 16 year old...");

			Driver driver = new Driver(16);

			ProxyCar proxyCar = new ProxyCar(driver);
			proxyCar.DriveCar();

			Console.ReadLine();
		}
	}
}
