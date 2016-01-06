using System;
using System.ComponentModel;
using ModelViewViewModelPattern.Annotations;

namespace ModelViewViewModelPattern.Domain
{
	public class Car : INotifyPropertyChanged
	{
		private string _make;
		private string _model;
		private DateTime _lastUpdated;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Make
		{
			get
			{
				return _make;
			}

			set
			{
				_make = value;
				OnPropertyChanged("Make");
			}
		}

		public string Model
		{
			get
			{
				return _model;
			}

			set
			{
				_model = value;
				OnPropertyChanged("Model");
			}
		}

		public DateTime LastUpdated
		{
			get
			{
				return _lastUpdated;
			}

			set
			{
				_lastUpdated = value;
				OnPropertyChanged("LastUpdated");
			}
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