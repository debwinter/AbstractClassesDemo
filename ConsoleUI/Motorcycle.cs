using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        public Motorcycle()
		{
		}

        public bool LeatherJacketRequired { get; set; } = false;

        public override void DriveAbstract()
        {
            if (LeatherJacketRequired)
            {
                Console.WriteLine("We always wear our leather jackets.");
            }
            else
            {
                Console.WriteLine("We can wear whatever we want.");
            }
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("We are riding a motorcycle!");
        }
    }
}

