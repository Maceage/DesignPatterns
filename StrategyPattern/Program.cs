using System;
using StrategyPattern.Domain;
using StrategyPattern.Domain.Operations;

namespace StrategyPattern
{
	public class Program
	{
		private const int NumberOne = 10;
		private const int NumberTwo = 2;

		public static void Main(string[] args)
		{
			AddOperation();
			DivideOperation();
			MinusOperation();
			MultiplyOperation();

			Console.ReadLine();
		}

		private static void AddOperation()
		{
			Calculator calculator = new Calculator(new AddOperation());
			int result = calculator.Calculate(NumberOne, NumberTwo);

			Console.WriteLine("Add operation result: {0}", result);
		}

		private static void DivideOperation()
		{
			Calculator calculator = new Calculator(new DivideOperation());
			int result = calculator.Calculate(NumberOne, NumberTwo);

			Console.WriteLine("Divide operation result: {0}", result);
		}

		private static void MinusOperation()
		{
			Calculator calculator = new Calculator(new MinusOperation());
			int result = calculator.Calculate(NumberOne, NumberTwo);

			Console.WriteLine("Minus operation result: {0}", result);
		}

		private static void MultiplyOperation()
		{
			Calculator calculator = new Calculator(new MultiplyOperation());
			int result = calculator.Calculate(NumberOne, NumberTwo);

			Console.WriteLine("Multiply operation result: {0}", result);
		}
	}
}
