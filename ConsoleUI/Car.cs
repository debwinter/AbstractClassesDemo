using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
        public Car()
		{
		}

        public string TypeOfCar { get; set; }
        
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {TypeOfCar} is fun to drive.");
        }
    }
}

