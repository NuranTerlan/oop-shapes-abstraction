using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Circle : TwoD
    {
        public Circle(int radius) : base(radius)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(SideLength, 2);
        }
    }
}