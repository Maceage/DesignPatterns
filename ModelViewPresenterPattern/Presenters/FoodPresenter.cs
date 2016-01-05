using System.Linq;
using ModelViewPresenterPattern.Mappers;
using ModelViewPresenterPattern.Models;
using ModelViewPresenterPattern.Views;

namespace ModelViewPresenterPattern.Presenters
{
	public class FoodPresenter
	{
		private readonly IFoodView _view;

		public FoodPresenter(IFoodView view)
		{
			_view = view;
		}

		public void Init()
		{
			var foodListViewModel = GetViewModel();

			_view.Show(foodListViewModel);
		}

		public void Sort(bool isSorted)
		{
			var vm = GetViewModel();

			if (!isSorted)
			{
				vm.Food = vm.Food.OrderBy(f => f.Name);
			}

			vm.IsSorted = !isSorted;

			_view.Show(vm);
		}

		private static FoodListViewModel GetViewModel()
		{
			return FoodListViewModelMapper.MapFoodListViewModel();
		}
	}
}