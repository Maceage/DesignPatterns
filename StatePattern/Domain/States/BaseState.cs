using System;

namespace StatePattern.Domain.States
{
	public class BaseState
	{
		public void Print(WorkItem wi)
		{
			Console.WriteLine("   Id:	{0}", wi.Id);
			Console.WriteLine("State:	{0}", wi.State);
			Console.WriteLine("Title:	{0}", wi.Title);
			Console.WriteLine(" Desc:	{0}", wi.Description);
		}
	}
}