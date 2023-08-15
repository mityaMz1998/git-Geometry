using System;
using FigureLib;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input side b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input side c:");
            double c = double.Parse(Console.ReadLine());

            IShape triangle = new Triangle(a, b, c);
            Console.WriteLine($"The area of triangle is: {triangle.GetArea()}");

            Console.Write("Input side radius:");
            double r = double.Parse(Console.ReadLine());

            IShape circle = new Circle(r);
            Console.WriteLine($"The area of circle is: {circle.GetArea()}");
        }
    }
}
