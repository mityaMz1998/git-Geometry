using System;

namespace FigureLib
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
                Console.WriteLine("Triangle is rectangular");
        }
        public override double GetArea()
        {
            // The area of any triangle on three sides can be calculated using the Heron formula
            double halfPerimeter = (SideA + SideB + SideC) / 2.0;
            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
            return Area;
        }
    }
}
