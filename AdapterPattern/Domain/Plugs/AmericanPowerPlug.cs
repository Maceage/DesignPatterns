using System;
using AdapterPattern.Domain.Interfaces;
using AdapterPattern.Domain.PinTypes;

namespace AdapterPattern.Domain.Plugs
{
	public class AmericanPowerPlug : IAmericanPowerPlug
	{
		public void SupplyPower(Electricity electricity, FlatPin flatPin1, FlatPin flatPin2)
		{
			Console.WriteLine("{0} being supplied to American Power Plug via {1} and {2}", electricity, flatPin1, flatPin2);
		}
	}
}