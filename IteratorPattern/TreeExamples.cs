using System;
using System.Xml.Serialization;
using IteratorPattern.Domain;

namespace IteratorPattern
{
	public static class TreeExamples
	{
		private static Tree<int> CreateTreeWithValues(int numberOfValues)
		{
			if (numberOfValues <= 0)
			{
				return null;
			}

			var tree = new Tree<int>(1);
			for (int i = 2; i <= numberOfValues; i++)
			{
				tree.Add(i);
			}

			return tree;
		}

		public static void RunAllExamples()
		{
			StoreSixthValueInRightLeftNode();
			ListValuesInDepthFirstOrder();
			ListValuesInDepthFirstOrderWithEnumerator();
			ListValuesInBreadthFirstOrderWithEnumerator();
		}

		public static void StoreSixthValueInRightLeftNode()
		{
			Console.WriteLine("--- Store sixth value in right left node example start ---");

			int expectedValue = 6;
			Tree<int> myTree = CreateTreeWithValues(expectedValue);

			DisplayTree(myTree);

			Console.WriteLine("--- Store sixth value in right left node example end ---");
		}

		public static void ListValuesInDepthFirstOrder()
		{
			Console.WriteLine("--- List values in depth first order example start ---");

			int expectedValue = 6;
			Tree<int> myTree = CreateTreeWithValues(expectedValue);

			DisplayTree(myTree);

			Console.WriteLine("--- List values in depth first order example end ---");
		}

		public static void ListValuesInDepthFirstOrderWithEnumerator()
		{
			Console.WriteLine("--- List values in depth first order with enumerator example start ---");

			int expectedValue = 6;
			Tree<int> myTree = CreateTreeWithValues(expectedValue);

			DisplayTree(myTree);

			Console.WriteLine("--- List values in depth first order with enumerator example end ---");
		}

		public static void ListValuesInBreadthFirstOrderWithEnumerator()
		{
			Console.WriteLine("--- List values in breadth first order with enumerator example start ---");

			int expectedValue = 6;
			Tree<int> myTree = CreateTreeWithValues(expectedValue);
			myTree.UseBreadthFirstEnumerator = true;

			DisplayTree(myTree);

			Console.WriteLine("--- List values in breadth first order with enumerator example end ---");
		}

		private static void DisplayTree(Tree<int> tree)
		{
			var serializer = new XmlSerializer(tree.GetType());
			serializer.Serialize(Console.Out, tree);

			Console.WriteLine();
		}
	}
}