using System;
using static System.Math;

namespace lib
{
    public class Circle : Shape
    {
        public Circle(string colour, double radius) : base(colour)
        {

            Radius = radius;
        }

        public double Radius { get; set; }

        public double Diameter
        {
            get { return 2 * Radius; }
        }

        public double Circumference
        {
            get { return 2 * Radius * PI; }
        }

        public double Area
        {
            get { return PI * Pow(Radius, 2); }
        }
    }
}

