using System.Collections.Generic;
using System.Windows.Forms;
using ModelViewPresenterPattern.Models;
using ModelViewPresenterPattern.Presenters;
using ModelViewPresenterPattern.Views;

namespace ModelViewPresenterPattern
{
	public partial class MainForm : Form, IFoodView
	{
		private readonly FoodPresenter _presenter;

		public MainForm()
		{
			InitializeComponent();

			_presenter = new FoodPresenter(this);
			_presenter.Init();
		}

		public void Show(FoodListViewModel viewModel)
		{
			SortButton.Tag = viewModel.IsSorted;

			FoodListBox.DataSource = new List<FoodViewModel>(viewModel.Food);
			FoodListBox.DisplayMember = "Name";
			FoodListBox.ValueMember = "Id";
		}

		private void SortButton_Click(object sender, System.EventArgs e)
		{
			_presenter.Sort((bool)SortButton.Tag);
		}
	}
}
