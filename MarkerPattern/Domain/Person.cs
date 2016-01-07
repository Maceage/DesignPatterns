using MarkerPattern.Domain.Interfaces;

namespace MarkerPattern.Domain
{
	public class Person : IHuman
	{
		public string Name { get; set; } 
		public string Gender { get; set; }

		public override string ToString()
		{
			return string.Format("{0} ({1})", Name, Gender);
		}
	}
}