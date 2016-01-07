using AdapterPattern.Domain.PinTypes;

namespace AdapterPattern.Domain.Interfaces
{
	public interface IUkPowerPlug
	{
		void SupplyPower(Electricity electricity, RectangularPin rectangularPin1, RectangularPin rectangularPin2, RectangularPin rectangularPin3);
	}
}