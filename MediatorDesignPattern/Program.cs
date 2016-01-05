using MediatorDesignPattern.Domain;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var airTrafficControl = new AirTrafficControl();

			var fighter1 = new Junkers("JC123", airTrafficControl);
			var fighter2 = new Lancaster("LA456", airTrafficControl);
			var fighter3 = new Mustang("MS789", airTrafficControl);
			var fighter4 = new Spitfire("SF3121", airTrafficControl);
			var fighter5 = new Stuka("ST6059", airTrafficControl);

			fighter1.Altitude += 25000;
			fighter2.Altitude += 25000;
			fighter3.Altitude += 25000;
			fighter4.Altitude += 25000;
			fighter5.Altitude += 25000;
		}
	}
}
