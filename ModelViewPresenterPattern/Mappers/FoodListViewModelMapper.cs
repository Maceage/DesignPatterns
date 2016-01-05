using System.Collections.Generic;
using System.Linq;
using ModelViewPresenterPattern.Domain;
using ModelViewPresenterPattern.Models;

namespace ModelViewPresenterPattern.Mappers
{
	public static class FoodListViewModelMapper
	{
		public static FoodListViewModel MapFoodListViewModel()
		{
			return new FoodListViewModel
			{
				IsSorted = false,
				Food = MapFoodList()
			};
		}

		private static IList<FoodViewModel> MapFoodList()
		{
			var foodList = GetFood();

			return foodList.Select(MapFood).ToList();
		}

		private static FoodViewModel MapFood(Food food)
		{
			return new FoodViewModel { Id = food.Id, Name = food.Name };
		}

		private static IList<Food> GetFood()
		{
			return new List<Food>
			{
				new Food { Name = "Sushi" },
				new Food { Name = "Cake" },
				new Food { Name = "Sandwich" },
				new Food { Name = "Cookie" },
				new Food { Name = "Banana" }
			};
		}
	}
}