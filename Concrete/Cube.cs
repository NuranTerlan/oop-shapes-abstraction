using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Cube : ThreeD
    {
        public Cube(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            return 6 * Math.Pow(SideLength, 2);
        }

        public override double CalculateVolume()
        {
            return Math.Pow(SideLength, 3);
        }
    }
}