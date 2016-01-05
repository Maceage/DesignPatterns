using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Domain
{
	public class Lancaster : Aircraft
	{
		public Lancaster(string callSign, IAirTrafficControl atc)
			: base(callSign, atc)
		{
		}

		public override int Ceiling
		{
			get
			{
				return 21400;
			}
		}
	}
}