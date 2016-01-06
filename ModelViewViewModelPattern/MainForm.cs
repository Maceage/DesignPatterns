using System;
using System.Windows.Forms;
using System.Windows.Input;
using ModelViewViewModelPattern.ViewModels;

namespace ModelViewViewModelPattern
{
	public partial class MainForm : Form
	{
		private MainFormViewModel _mainFormViewModel;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_mainFormViewModel = new MainFormViewModel();

			BindingSource bindingSource = new BindingSource(_mainFormViewModel, null);

			MakeTextBox.DataBindings.Add("Text", bindingSource, "ModelCar.Make");
			ModelTextBox.DataBindings.Add("Text", bindingSource, "ModelCar.Model");
			LastUpdatedLabel.DataBindings.Add("Text", bindingSource, "ModelCar.LastUpdated");

			SaveButton.Tag = _mainFormViewModel.SaveCarCommand;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ICommand command = ((Control)sender).Tag as ICommand;

			if (command != null)
			{
				command.Execute(null);
			}
		}
	}
}
