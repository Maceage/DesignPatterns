using System;
using MarkerPattern.Domain;
using MarkerPattern.Domain.Interfaces;

namespace MarkerPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Person person = new Person { Name = "Homer Simpson", Gender = "Male" };
			Dog dog = new Dog { Name = "Santa's Little Helper", Gender = "Male", Breed = "Greyhound" };

			PrintIsHuman(person);
			PrintIsHuman(dog);

			Console.ReadLine();
		}

		private static void PrintIsHuman(object entity)
		{
			if (entity is IHuman)
			{
				Console.WriteLine("Entity '{0}' is human", entity);
			}
			else
			{
				Console.WriteLine("Entity '{0}' is not human", entity);
			}
		}
	}
}