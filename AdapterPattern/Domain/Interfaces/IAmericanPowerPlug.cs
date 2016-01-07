using AdapterPattern.Domain.PinTypes;

namespace AdapterPattern.Domain.Interfaces
{
	public interface IAmericanPowerPlug
	{
		void SupplyPower(Electricity electricity, FlatPin flatPin1, FlatPin flatPin2);
	}
}