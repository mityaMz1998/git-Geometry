using System;

namespace FigureLib
{
    public class Figure
    {
        public double Area { get; set; }
        public virtual double GetArea()
        {
            return Area;
        }
    }
}
