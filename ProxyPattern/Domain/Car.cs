using System;
using ProxyPattern.Domain.Interfaces;

namespace ProxyPattern.Domain
{
	public class Car : ICar
	{
		public void DriveCar()
		{
			Console.WriteLine("Car has been driven!");
		}
	}
}