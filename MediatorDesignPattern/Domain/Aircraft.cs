using System;
using MediatorPattern.Mediator;

namespace MediatorPattern.Domain
{
	public abstract class Aircraft
	{
		private readonly IAirTrafficControl _atc;
		private int _currentAltitude;

		protected Aircraft(string callSign, IAirTrafficControl atc)
		{
			_atc = atc;
			CallSign = callSign;
			_atc.RegisterAircraftUnderGuidance(this);
		}

		public abstract int Ceiling { get; }

		public string CallSign { get; private set; }

		public int Altitude
		{
			get
			{
				return _currentAltitude;
			}

			set
			{
				_currentAltitude = value;
				_atc.ReceiveAircraftLocation(this);
			}
		}

		public void Climb(int heightToClimb)
		{
			Altitude += heightToClimb;

			Console.WriteLine("{0} climbing to {1}ft", CallSign, Altitude);
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType() != GetType())
			{
				return false;
			}

			var incoming = (Aircraft)obj;
			return CallSign.Equals(incoming.CallSign);
		}

		public override int GetHashCode()
		{
			return CallSign.GetHashCode();
		}

		public void WarnOfAirspaceIntrusionBy(Aircraft reportingAircraft)
		{
			Console.WriteLine("Airspace intrusion for {0} by {1}", CallSign, reportingAircraft.CallSign);
		}
	}
}