using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Tetrahedron : ThreeD
    {
        public Tetrahedron(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Math.Pow(SideLength, 2);
        }

        public override double CalculateVolume()
        {
            return Math.Pow(SideLength, 3) / (6 * Math.Sqrt(2));
        }
    }
}