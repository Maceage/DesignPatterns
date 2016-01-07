using System;
using PrototypePattern.Domain;

namespace PrototypePattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Creating the Matrix...");
			Console.WriteLine();

			TheMatrix theMatrix = new TheMatrix();

			theMatrix.TakeBluePill();
			theMatrix.EncounterAgentSmith(5);
			theMatrix.FireBullets(100);
			theMatrix.MakePhoneCall();
			theMatrix.PrintState();

			Console.WriteLine();
			Console.WriteLine("Cloning the Matrix...");
			Console.WriteLine();
			
			TheMatrix newMatrix = theMatrix.Clone() as TheMatrix;

			if (newMatrix != null)
			{
				newMatrix.PrintState();
			}

			Console.ReadLine();
		}
	}
}
