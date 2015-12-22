using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.Domain
{
	[Serializable]
	public class Tree<T> : IEnumerable<T>
	{
		public Tree()
		{
		}

		public Tree(T value)
		{
			Value = value;
		}

		public T Value { get; set; }

		public Tree<T> LeftChild { get; set; }
		public Tree<T> RightChild { get; set; }

		public bool UseBreadthFirstEnumerator { get; set; }

		public void Add(T value)
		{
			if (LeftChild == null)
			{
				LeftChild = new Tree<T>(value);
				return;
			}

			if (RightChild == null)
			{
				RightChild = new Tree<T>(value);
				return;
			}

			if (LeftChild.Depth() <= RightChild.Depth())
			{
				LeftChild.Add(value);
				return;
			}

			RightChild.Add(value);
		}

		public int Depth()
		{
			if (LeftChild == null || RightChild == null)
			{
				return 0;
			}

			return 1 + Math.Max(LeftChild.Depth(), RightChild.Depth());
		}

		public IEnumerable<Tree<T>> Children()
		{
			if (LeftChild != null)
			{
				yield return LeftChild;
			}

			if (RightChild != null)
			{
				yield return RightChild;
			}
		}

		public List<T> ToList()
		{
			var myList = new List<T>();
			myList.Add(Value);

			if (LeftChild != null)
			{
				myList.AddRange(LeftChild.ToList());
			}

			if (RightChild != null)
			{
				myList.AddRange(RightChild.ToList());
			}

			return myList;
		}

		public IEnumerator<T> GetEnumerator()
		{
			if (UseBreadthFirstEnumerator)
			{
				return new TreeBreadthFirstEnumerator<T>(this);
			}

			return new TreeEnumerator<T>(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}