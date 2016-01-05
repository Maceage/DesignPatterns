using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Domain
{
	public class Stuka : Aircraft
	{
		public Stuka(string callSign, IAirTrafficControl atc)
			: base(callSign, atc)
		{
		}

		public override int Ceiling
		{
			get
			{
				return 29603;
			}
		}
	}
}