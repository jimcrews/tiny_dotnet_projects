using System;
using lib;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle("red", 3.5);

            System.Console.WriteLine($"Circle. Colour = {circle.Colour}, radius = {circle.Radius}, Area = {circle.Area}");
        }
    }
}
