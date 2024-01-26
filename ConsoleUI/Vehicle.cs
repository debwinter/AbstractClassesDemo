using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public Vehicle()
		{
		}

        public string Year { get; set; } = "Unknown";

        public string Make { get; set; } = "Unknown";

        public string Model { get; set; } = "Unknown";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("We are driving!");
        }
    }
}

