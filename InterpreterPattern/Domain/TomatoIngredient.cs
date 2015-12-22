using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class TomatoIngredient : IIngredient
	{
		public void Interpret(Context context)
		{
			context.Output += string.Format(" {0} ", "Tomato");
		}
	}
}