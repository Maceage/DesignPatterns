using AdapterPattern.Domain.Interfaces;
using AdapterPattern.Domain.PinTypes;
using AdapterPattern.Domain.Plugs;

namespace AdapterPattern.Domain.Adapters
{
	public class UkPowerPlugAdapter : IPowerPlugAdapter
	{
		private readonly UkPowerPlug _ukPowerPlug;

		public UkPowerPlugAdapter(UkPowerPlug ukPowerPlug)
		{
			_ukPowerPlug = ukPowerPlug;
		}

		public void SupplyPower(Electricity electricity)
		{
			RectangularPin rectangularPin1 = new RectangularPin();
			RectangularPin rectangularPin2 = new RectangularPin();
			RectangularPin rectangularPin3 = new RectangularPin();

			_ukPowerPlug.SupplyPower(electricity, rectangularPin1, rectangularPin2, rectangularPin3);
		}
	}
}