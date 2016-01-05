using System;
using NullObjectPattern.Data;
using NullObjectPattern.Domain;

namespace NullObjectPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FindComputer("apple");
			FindComputer("linux");
			FindComputer("windows");
			
			FindComputer(null);

			Console.ReadLine();
		}

		private static void FindComputer(string computerName)
		{
			var computerRepository = new ComputerRepository();

			ComputerBase computer = computerRepository.Find(computerName);

			if (computer != ComputerBase.Null)
			{
				computer.Start();
				computer.Stop();
			}
			else
			{
				Console.WriteLine("Computer not found!");
			}
		}
	}
}