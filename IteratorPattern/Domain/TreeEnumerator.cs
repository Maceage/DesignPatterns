using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.Domain
{
	public class TreeEnumerator<T> : IEnumerator<T>
	{
		private readonly Stack<Tree<T>> _breadcrumb = new Stack<Tree<T>>();
		private readonly Tree<T> _tree;

		private Tree<T> _current;
		private Tree<T> _previous;

		public TreeEnumerator(Tree<T> tree)
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
				return true;
			}

			if (_current.LeftChild != null)
			{
				return TraverseLeft();
			}

			if (_current.RightChild != null)
			{
				return TraverseRight();
			}

			return TraverseUpAndRight();
		}

		private bool TraverseUpAndRight()
		{
			if (_breadcrumb.Count > 0)
			{
				_previous = _current;

				while (true)
				{
					_current = _breadcrumb.Pop();
					if (_previous != _current.RightChild)
					{
						break;
					}
				}

				if (_current.RightChild != null)
				{
					_breadcrumb.Push(_current);
					_current = _current.RightChild;
					return true;
				}
			}

			return false;
		}

		private bool TraverseLeft()
		{
			_breadcrumb.Push(_current);
			_current = _current.LeftChild;

			return true;
		}

		private bool TraverseRight()
		{
			_breadcrumb.Push(_current);
			_current = _current.RightChild;

			return true;
		}

		public void Reset()
		{
			_current = null;
		}
	}
}