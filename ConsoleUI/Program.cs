using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Car c1 = new Car()
            {
                Year = "2012",
                Make = "Toyota",
                Model = "Camry",
                TypeOfCar = "sedan"
            };
            vehicles.Add(c1);

            Motorcycle m1 = new Motorcycle()
            {
                Year = "2019",
                Make = "Harley-Davidson",
                Model = "Sportster",
                LeatherJacketRequired = true
            };
            vehicles.Add(m1);

            Vehicle v1 = new Car()
            {
                Year = "2021",
                Make = "Honda",
                Model = "Fit",
                TypeOfCar = "hatchback"
            };
            vehicles.Add(v1);

            Vehicle v2 = new Motorcycle()
            {
                Year = "2023",
                Make = "Suzuki",
                Model = "GSX-R"
            };
            vehicles.Add(v2);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"{v.Year} {v.Make} {v.Model}:");
                v.DriveVirtual();
                v.DriveAbstract();
                Console.WriteLine();
            }
        }
    }
}
