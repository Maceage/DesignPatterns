using System;
using AdapterPattern.Domain.Interfaces;
using AdapterPattern.Domain.PinTypes;

namespace AdapterPattern.Domain.Plugs
{
	public class UkPowerPlug : IUkPowerPlug
	{
		public void SupplyPower(Electricity electricity, RectangularPin rectangularPin1, RectangularPin rectangularPin2, RectangularPin rectangularPin3)
		{
			Console.WriteLine("{0} being supplied to UK Power Plug via {1}, {2} and {3}", electricity, rectangularPin1, rectangularPin2, rectangularPin3);
		}
	}
}