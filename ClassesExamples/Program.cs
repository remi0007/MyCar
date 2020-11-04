using System;
using System.Collections.Generic;

namespace ClassesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2015;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "Cx5",
                Year = 2018
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carlist = new List<Car>() { myCar, mazda, chevy };

            Console.WriteLine(carlist.Capacity);

            foreach(var vehicle in carlist)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
