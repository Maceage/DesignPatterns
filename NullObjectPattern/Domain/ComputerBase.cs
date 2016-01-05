using System;

namespace NullObjectPattern.Domain
{
	public abstract class ComputerBase
	{
		private static readonly NullComputer _nullComputer = new NullComputer();

		public static NullComputer Null
		{
			get
			{
				return _nullComputer;
			}
		}

		public abstract Guid Id { get; }
		public abstract string Name { get; }

		public abstract void Start();
		public abstract void Stop();

		public class NullComputer : ComputerBase
		{
			public override Guid Id
			{
				get
				{
					return Guid.Empty;
				}
			}

			public override string Name
			{
				get
				{
					return string.Empty;
				}
			}

			public override void Start()
			{
			}

			public override void Stop()
			{
			}
		}
	}
}