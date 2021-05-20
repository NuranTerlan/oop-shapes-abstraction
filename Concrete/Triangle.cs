using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Triangle : TwoD
    {
        public override double AreaVar { get; set; }

        public Triangle(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            AreaVar = Math.Sqrt(3) * Math.Pow(Length, 2) / 4;
            return AreaVar;
        }

        public override string ToString()
        {
            string objName = nameof(Triangle);
            return $"{objName} (2D ({Length})) ==> Area = {CalculateArea()}" +
                   $"\nI am a {objName} shape";
        }
    }
}