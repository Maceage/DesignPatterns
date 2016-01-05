namespace StrategyPattern.Domain.Operations
{
	public class AddOperation : ICalculateOperation
	{
		public int Calculate(int value1, int value2)
		{
			return value1 + value2;
		}
	}
}