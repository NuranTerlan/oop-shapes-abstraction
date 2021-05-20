using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Rectangle : TwoD
    {
        public override double AreaVar { get; set; }

        public Rectangle(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            AreaVar = Math.Pow(Length, 2);
            return AreaVar;
        }

        public override string ToString()
        {
            string objName = nameof(Rectangle);
            return $"{objName} (2D ({Length})) ==> Area = {CalculateArea()}" +
                   $"\nI am a {objName} shape";
        }
    }
}