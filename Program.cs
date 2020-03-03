using System;

namespace Work_with_fixed_point_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Decimal type has a smaller range but greater 
            // precision than double.
            // The term fixed point means that the decimal
            // point(or binary point) doesnt move.

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            // The M suffix on the numbers is how you indicate
            // that a constant should use the decimal type.

            // Area of a circle: A=Math.PI * r^2

            double radius = 2.5;
            double area = Math.PI * (radius * radius);
            Console.WriteLine($" The area of a circle whose radius is {radius} equals {area}");
        }
    }
}
