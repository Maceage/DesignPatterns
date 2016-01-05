using NullObjectPattern.Domain;

namespace NullObjectPattern.Data
{
	public class ComputerRepository
	{
		public ComputerBase Find(string computerName)
		{
			if (!string.IsNullOrWhiteSpace(computerName))
			{
				switch (computerName.ToLower())
				{
					case "apple":
						return new AppleComputer();
					case "linux":
						return new LinuxComputer();
					case "windows":
						return new WindowsComputer();
				}
			}

			return ComputerBase.Null;
		}
	}
}