using System;
using lib;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car("red");

            string description = car.Describe();
            Console.WriteLine(description);

        }
    }
}
