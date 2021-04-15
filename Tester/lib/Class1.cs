using System;

namespace lib
{
    public class Car
    {
        public string Colour { get; set; }

        public Car(string colour)
        {
            this.Colour = colour;
        }

        public string Describe()
        {
            return "This car is " + Colour;
        }

    }
}
