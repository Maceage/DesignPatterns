using System;
using System.ComponentModel;
using ModelViewViewModelPattern.Annotations;
using ModelViewViewModelPattern.Commands;
using ModelViewViewModelPattern.Domain;

namespace ModelViewViewModelPattern.ViewModels
{
	public class MainFormViewModel : INotifyPropertyChanged
	{
		private Car _modelCar;
		private SaveCarCommand _saveCarCommand;

		public MainFormViewModel()
		{
			InitializeCommands();
			LoadCar();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public Car ModelCar
		{
			get
			{
				return _modelCar;
			}

			set
			{
				_modelCar = value;
				OnPropertyChanged("ModelCar");
			}
		}

		public SaveCarCommand SaveCarCommand
		{
			get
			{
				return _saveCarCommand;
			}

			set
			{
				_saveCarCommand = value;
				OnPropertyChanged("SaveCarCommand");
			}
		}

		private void LoadCar()
		{
			ModelCar = new Car { Make = "BMW", Model = "M2", };
		}

		private void InitializeCommands()
		{
			SaveCarCommand = new SaveCarCommand(UpdateCar);
		}

		private void UpdateCar()
		{
			ModelCar.LastUpdated = DateTime.Now;
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}