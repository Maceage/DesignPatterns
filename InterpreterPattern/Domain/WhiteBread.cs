using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class WhiteBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += string.Format(" {0} ", "White-IBread");
		}
	}
}