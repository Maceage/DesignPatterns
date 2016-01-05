using System.Collections.Generic;
using System.Windows.Input;
using MementoPattern.Domain;

namespace MementoPattern
{
	public partial class MainWindow
	{
		private readonly Stack<IMemento> _states = new Stack<IMemento>();

		public MainWindow()
		{
			InitializeComponent();
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));
			InkCanvasWithUndo1.MouseUp += InkCanvasWithUndo_MouseUp;

			StoreState();
		}

		private static void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
		{
			var myWindow = (MainWindow)sender;

			if (e.Command == ApplicationCommands.Undo)
			{
				myWindow.Undo();
			}
		}

		private void StoreState()
		{
			var memento = InkCanvasWithUndo1.CreateMemento();
			_states.Push(memento);

			StatesCountLabel.Content = _states.Count;
		}

		private void InkCanvasWithUndo_MouseUp(object sender, MouseButtonEventArgs e)
		{
			StoreState();
		}

		private void Undo()
		{
			if (_states.Count > 1)
			{
				_states.Pop();

				var lastState = _states.Peek();
				InkCanvasWithUndo1.SetMemento(lastState);
			}

			StatesCountLabel.Content = _states.Count;
		}
	}
}
