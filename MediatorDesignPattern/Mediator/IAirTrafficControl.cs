using MediatorDesignPattern.Domain;

namespace MediatorDesignPattern.Mediator
{
	public interface IAirTrafficControl
	{
		void ReceiveAircraftLocation(Aircraft reportingAircraft);
		void RegisterAircraftUnderGuidance(Aircraft aircraft);
	}
}