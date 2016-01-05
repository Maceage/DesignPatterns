using System.Collections.Generic;

namespace ModelViewPresenterPattern.Models
{
	public class FoodListViewModel
	{
		public IEnumerable<FoodViewModel> Food { get; set; }

		public bool IsSorted { get; set; }
	}
}