using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Triangle : TwoD
    {
        public Triangle(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Math.Pow(SideLength, 2) / 4;
        }
    }
}