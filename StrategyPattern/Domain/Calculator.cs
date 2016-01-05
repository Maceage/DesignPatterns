namespace StrategyPattern.Domain
{
	public class Calculator
	{
		private readonly ICalculateOperation _calculateOperation;

		public Calculator(ICalculateOperation calculateOperation)
		{
			_calculateOperation = calculateOperation;
		}

		public int Calculate(int value1, int value2)
		{
			return _calculateOperation.Calculate(value1, value2);
		}
	}
}