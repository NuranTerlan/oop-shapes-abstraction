using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Sphere : ThreeD
    {
        public Sphere(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(SideLength, 2);
        }

        public override double CalculateVolume()
        {
            return 3.14159265358979D * Math.Pow(SideLength, 3);
        }
    }
}