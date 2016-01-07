using System;

namespace PrototypePattern.Domain
{
	public class TheMatrix : ICloneable
	{
		private bool _hasTakenRedPill;
		private bool _hasTakenBluePill;

		private int _numberOfTimesAgentSmithEncountered;
		private int _numberOfPhoneCalls;
		private int _numberOfBulletsFired;

		public void TakeRedPill()
		{
			_hasTakenRedPill = true;
			_hasTakenBluePill = false;
		}

		public void TakeBluePill()
		{
			_hasTakenBluePill = true;
			_hasTakenRedPill = false;
		}

		public void EncounterAgentSmith(int numberOfTimes)
		{
			_numberOfTimesAgentSmithEncountered++;
		}

		public void MakePhoneCall()
		{
			_numberOfPhoneCalls++;
		}

		public void FireBullets(int numberOfBullets)
		{
			_numberOfBulletsFired++;
		}

		public void PrintState()
		{
			Console.WriteLine("Has taken red pill? {0}", _hasTakenRedPill);
			Console.WriteLine("Has taken blue pill? {0}", _hasTakenBluePill);

			Console.WriteLine("Number of times Agent Smith encountered: {0}", _numberOfTimesAgentSmithEncountered);
			Console.WriteLine("Number of phone calls: {0}", _numberOfPhoneCalls);
			Console.WriteLine("Number of bullets fired: {0}", _numberOfBulletsFired);
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}