using MediatorPattern.Domain;

namespace MediatorPattern.Mediator
{
	public interface IAirTrafficControl
	{
		void ReceiveAircraftLocation(Aircraft reportingAircraft);
		void RegisterAircraftUnderGuidance(Aircraft aircraft);
	}
}