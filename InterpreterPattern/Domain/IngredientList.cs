using System.Collections.Generic;
using InterpreterPattern.Domain.Interfaces;

namespace InterpreterPattern.Domain
{
	public class IngredientList : IExpression
	{
		private readonly List<IIngredient> _ingredients;

		public IngredientList(List<IIngredient> ingredients)
		{
			_ingredients = ingredients;
		}

		public void Interpret(Context context)
		{
			foreach (var ingredient in _ingredients)
			{
				ingredient.Interpret(context);
			}
		}
	}
}