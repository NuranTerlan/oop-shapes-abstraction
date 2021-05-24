using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Rectangle : TwoD
    {
        public Rectangle(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}