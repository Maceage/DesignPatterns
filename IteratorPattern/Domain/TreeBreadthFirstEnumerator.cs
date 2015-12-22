using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.Domain
{
	public class TreeBreadthFirstEnumerator<T> : IEnumerator<T>
	{
		private readonly Queue<IEnumerator<Tree<T>>> _enumerators = new Queue<IEnumerator<Tree<T>>>();
		private readonly Tree<T> _tree;

		private Tree<T> _current;

		public TreeBreadthFirstEnumerator(Tree<T> tree)
		{
			_tree = tree;
		}

		public T Current
		{
			get { return _current.Value; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (_current == null)
			{
				Reset();
				_current = _tree;
				_enumerators.Enqueue(_current.Children().GetEnumerator());

				return true;
			}

			while (_enumerators.Count > 0)
			{
				var enumerator = _enumerators.Peek();
				if (enumerator.MoveNext())
				{
					_current = enumerator.Current;
					_enumerators.Enqueue(_current.Children().GetEnumerator());

					return true;
				}

				_enumerators.Dequeue();
			}

			return false;
		}

		public void Reset()
		{
			_current = null;
			_enumerators.Clear();
		}
	}
}