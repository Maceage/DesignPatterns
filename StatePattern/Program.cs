using System;
using StatePattern.Domain;

namespace StatePattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WorkItem workItem = CreateWorkItem();

			EditWorkItem(workItem);

			SetItemState(workItem, "active");

			DeleteWorkItem(workItem);

			SetItemState(workItem, "proposed");
			SetItemState(workItem, "resolved");
			SetItemState(workItem, "proposed");
			SetItemState(workItem, "active");

			DeleteWorkItem(workItem);

			SetItemState(workItem, "closed");
			SetItemState(workItem, "resolved");
			SetItemState(workItem, "closed");

			DeleteWorkItem(workItem);

			Console.ReadLine();
		}

		private static WorkItem CreateWorkItem()
		{
			Console.WriteLine("Creating new work item...");

			WorkItem workItem = WorkItem.Create();
			workItem.Print();

			Console.WriteLine();

			return workItem;
		}

		private static void EditWorkItem(WorkItem workItem)
		{
			Console.WriteLine("Editing work item...");

			workItem.Edit("Work item title here", "Work item description here");
			workItem.Print();

			Console.WriteLine();
		}

		private static void SetItemState(WorkItem workItem, string state)
		{
			Console.WriteLine("Setting work item state to {0}...", state);

			workItem.SetState(state);
			workItem.Print();

			Console.WriteLine();
		}

		private static void DeleteWorkItem(WorkItem workItem)
		{
			Console.WriteLine("Deleting work item...");

			workItem.Delete();
			workItem.Print();

			Console.WriteLine();
		}
	}
}
