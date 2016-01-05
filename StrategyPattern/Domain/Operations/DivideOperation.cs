namespace StrategyPattern.Domain.Operations
{
	public class DivideOperation : ICalculateOperation
	{
		public int Calculate(int value1, int value2)
		{
			return value1 / value2;
		}
	}
}