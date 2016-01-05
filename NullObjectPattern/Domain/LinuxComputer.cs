using System;

namespace NullObjectPattern.Domain
{
	public class LinuxComputer : ComputerBase
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
				return "Linux computer";
			}
		}

		public override void Start()
		{
			Console.WriteLine("Linux computer started");
		}

		public override void Stop()
		{
			Console.WriteLine("Linux computer stopped");
		}
	}
}