using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class WheatBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += string.Format(" {0} ", "Wheat-IBread");
		}
	}
}