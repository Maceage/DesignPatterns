using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Domain
{
	public class Spitfire : Aircraft
	{
		public Spitfire(string callSign, IAirTrafficControl atc)
			: base(callSign, atc)
		{
		}

		public override int Ceiling
		{
			get
			{
				return 36500;
			}
		}
	}
}