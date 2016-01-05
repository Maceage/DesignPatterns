using System;

namespace NullObjectPattern.Domain
{
	public class WindowsComputer : ComputerBase
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
				return "Windows computer";
			}
		}

		public override void Start()
		{
			Console.WriteLine("Windows computer started");
		}

		public override void Stop()
		{
			Console.WriteLine("Windows computer stopped");
		}
	}
}