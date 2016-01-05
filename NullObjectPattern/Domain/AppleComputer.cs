using System;

namespace NullObjectPattern.Domain
{
	public class AppleComputer : ComputerBase
	{
		public override Guid Id
		{
			get
			{
				return Guid.NewGuid();
			}
		}

		public override string Name
		{
			get
			{
				return "Apple computer";
			}
		}

		public override void Start()
		{
			Console.WriteLine("Apple computer started");
		}

		public override void Stop()
		{
			Console.WriteLine("Apple computer stopped");
		}
	}
}