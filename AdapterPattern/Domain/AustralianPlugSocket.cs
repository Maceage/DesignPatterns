using AdapterPattern.Domain.Interfaces;

namespace AdapterPattern.Domain
{
	public class AustralianPlugSocket
	{
		public void PlugIn(IPowerPlugAdapter powerPlugAdapter)
		{
			Electricity electricity = new Electricity();

			powerPlugAdapter.SupplyPower(electricity);
		}
	}
}