using System;
using ProxyPattern.Domain.Interfaces;

namespace ProxyPattern.Domain
{
	public class ProxyCar : ICar
	{
		private readonly Driver _driver;
		private readonly ICar _car;

		public ProxyCar(Driver driver)
		{
			_driver = driver;
			_car = new Car();
		}

		public void DriveCar()
		{
			if (_driver.Age <= 18)
			{
				Console.WriteLine("You are too young to drive!");
			}
			else
			{
				_car.DriveCar();
			}
		}
	}
}