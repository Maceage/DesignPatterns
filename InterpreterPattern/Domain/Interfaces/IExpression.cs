namespace InterpreterPattern.Domain.Interfaces
{
	public interface IExpression
	{
		void Interpret(Context context);
	}
}