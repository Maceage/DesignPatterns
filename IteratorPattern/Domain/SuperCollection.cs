using System.Collections.Generic;

namespace IteratorPattern.Domain
{
	public class SuperCollection : List<string>
	{
		public string Get(int index)
		{
			return this[index];
		}
	}
}