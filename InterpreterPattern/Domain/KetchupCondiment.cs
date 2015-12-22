using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class KetchupCondiment : ICondiment
	{
		public void Interpret(Context context)
		{
			context.Output += string.Format(" {0} ", "Ketchup");
		}
	}
}