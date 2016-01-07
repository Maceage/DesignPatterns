namespace MarkerPattern.Domain
{
	public class Dog
	{
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Breed { get; set; }

		public override string ToString()
		{
			return string.Format("{0} - {1} ({2})", Name, Breed, Gender);
		}
	}
}