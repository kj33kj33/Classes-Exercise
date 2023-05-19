using System;
namespace Classes
{
	public class Car
	{
		public Car()
		{
		}

		public Car(string make, string model, int year)
		{
			Make = make;
			Model = model;
			Year = year;
		}

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

		public void CarDetails()
		{
            Console.WriteLine($"This {Make} is a {Year} {Model}!");
        }
    }
}

