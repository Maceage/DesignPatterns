﻿namespace StatePattern.Framework
{
	public interface ICommands
	{
		bool Delete();
		void Edit(string title, string desc);
		void Print();
		void SetState(string state);
	}
}