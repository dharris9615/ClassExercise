using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "F-150";
            carOne.Year = 2014;

            var audi = new Car()
            {
                Make = "audi",
                Model = "R8",
                Year = 2017

            };
            var carList = new List<Car>() { carOne, audi };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            } 
        }
    }
}
