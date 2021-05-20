using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Circle : TwoD
    {
        public override double AreaVar { get; set; }

        public Circle(int radius) : base(radius)
        {
        }

        public override double CalculateArea()
        {
            AreaVar = Math.PI * Math.Pow(Length, 2);
            return AreaVar;
        }

        public override string ToString()
        {
            string objName = nameof(Circle);
            return $"{objName} (2D ({Length})) ==> Area = {CalculateArea()}" +
                   $"\nI am a {objName} shape";
        }
    }
}