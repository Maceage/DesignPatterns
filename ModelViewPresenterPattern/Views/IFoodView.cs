using ModelViewPresenterPattern.Models;

namespace ModelViewPresenterPattern.Views
{
	public interface IFoodView
	{
		void Show(FoodListViewModel viewModel);
	}
}