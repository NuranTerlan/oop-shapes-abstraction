using System;

namespace OOP_Tasks_Day1.Abstract
{
    public abstract class ThreeD : Shape
    {
        protected ThreeD(int a)
        {
            base.IAmXD = "3D";
            SideLength = a;
        }

        public abstract override double CalculateArea();

        public abstract double CalculateVolume();

        public override string ShapeStringify(Shape shape)
        {
            var temp = base.ShapeStringify(shape).Split("\n");
            var resultForThreeD = temp[0] + $", Volume = {Math.Round(CalculateVolume(), 2)}\n" + temp[1];

            return resultForThreeD;
        }
    }
}