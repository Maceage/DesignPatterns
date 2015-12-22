using System.Collections.Generic;
using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class CondimentList : IExpression
	{
		private readonly List<ICondiment> _condiments;

		public CondimentList(List<ICondiment> condiments)
		{
			_condiments = condiments;
		}

		public void Interpret(Context context)
		{
			foreach (var condiment in _condiments)
			{
				condiment.Interpret(context);
			}
		}
	}
}