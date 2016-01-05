using System;
using System.Collections.Generic;
using System.Linq;
using MediatorDesignPattern.Domain;

namespace MediatorDesignPattern.Mediator
{
	public class AirTrafficControl : IAirTrafficControl
	{
		private const int MinimumIntrusionAltitude = 1000;

		private readonly IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();

		public void ReceiveAircraftLocation(Aircraft reportingAircraft)
		{
			foreach (Aircraft currentAircraftUnderGuidance in _aircraftUnderGuidance.Where(x => !x.Equals(reportingAircraft)))
			{
				if (Math.Abs(currentAircraftUnderGuidance.Altitude - reportingAircraft.Altitude) < MinimumIntrusionAltitude)
				{
					currentAircraftUnderGuidance.WarnOfAirspaceIntrusionBy(reportingAircraft);

					reportingAircraft.Climb(MinimumIntrusionAltitude);
				}
			}
		}

		public void RegisterAircraftUnderGuidance(Aircraft aircraft)
		{
			if (!_aircraftUnderGuidance.Contains(aircraft))
			{
				_aircraftUnderGuidance.Add(aircraft);
			}
		}
	}
}