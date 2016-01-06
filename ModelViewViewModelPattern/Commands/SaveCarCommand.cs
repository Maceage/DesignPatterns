using System;
using System.Windows.Input;

namespace ModelViewViewModelPattern.Commands
{
	public class SaveCarCommand : ICommand
	{
		private readonly Action _executeMethod;

		public SaveCarCommand(Action executeAction)
		{
			_executeMethod = executeAction;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			_executeMethod.Invoke();
		}
	}
}