using MediatorPattern.Mediator;

namespace MediatorPattern.Domain
{
	public class Junkers : Aircraft
	{
		public Junkers(string callSign, IAirTrafficControl atc)
			: base(callSign, atc)
		{
		}

		public override int Ceiling
		{
			get
			{
				return 11150;
			}
		}
	}
}