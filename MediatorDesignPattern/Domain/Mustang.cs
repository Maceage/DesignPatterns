using MediatorPattern.Mediator;

namespace MediatorPattern.Domain
{
	public class Mustang : Aircraft
	{
		public Mustang(string callSign, IAirTrafficControl atc)
			: base(callSign, atc)
		{
		}

		public override int Ceiling
		{
			get
			{
				return 41900;
			}
		}
	}
}