using AdapterPattern.Domain.Interfaces;
using AdapterPattern.Domain.PinTypes;

namespace AdapterPattern.Domain.Adapters
{
	public class AmericanPowerPlugAdapter : IPowerPlugAdapter
	{
		private readonly IAmericanPowerPlug _americanPowerPlug;

		public AmericanPowerPlugAdapter(IAmericanPowerPlug americanPowerPlug)
		{
			_americanPowerPlug = americanPowerPlug;
		}

		public void SupplyPower(Electricity electricity)
		{
			FlatPin flatPin1 = new FlatPin();
			FlatPin flatPin2 = new FlatPin();

			_americanPowerPlug.SupplyPower(electricity, flatPin1, flatPin2);
		}
	}
}