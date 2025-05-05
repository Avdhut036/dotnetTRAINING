using Day1ConsoleApp.Models;

namespace Day1ConsoleApp {
	class Program
	{
		static void Main(string[] args)
		{
			var people = new List<Person>()
			{
				new Person {Id = 1 , Name ="Avdhut" , Age = 18 } ,
				new Person {Id = 2 , Name = "Mohit" , Age = 42 } ,
				new Person { Id = 3, Name = "Karan", Age = 9 }
			};

			Console.WriteLine("All People : ");
			people.ForEach(person => Console.WriteLine(person));

			Console.WriteLine("\n People older than 30 ! ");
			var olderPeople = people.Where(person => person.Age > 30);
			foreach (var person in olderPeople) { 
				Console.WriteLine(person);
			}
		}
	}
}