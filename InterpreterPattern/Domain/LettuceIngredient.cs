using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class LettuceIngredient : IIngredient
	{
		public void Interpret(Context context)
		{
			context.Output += string.Format(" {0} ", "Lettuce");
		}
	}
}