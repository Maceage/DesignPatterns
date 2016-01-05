using System.Linq;
using System.Windows.Controls;
using System.Windows.Ink;

namespace MementoPattern.Domain
{
	public class InkCanvasWithUndo : InkCanvas
	{
		public IMemento CreateMemento()
		{
			Stroke[] copy = Strokes.ToArray();
			return new InkCanvasMemento { State = copy };
		}

		public void SetMemento(IMemento memento)
		{
			Strokes = new StrokeCollection((Stroke[])memento.State);
		}

		public class InkCanvasMemento : IMemento
		{
			public object State { get; set; }
		}
	}
}