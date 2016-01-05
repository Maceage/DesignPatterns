using System;

namespace ModelViewPresenterPattern.Domain
{
	public class Food : IFood
	{
		public Food()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; private set; }
		public string Name { get; set; }
	}
}