using System;

namespace OOP_Tasks_Day1.Abstract
{
    public abstract class Shape
    {
        protected string AmXd;
        public double SideLength { get; set; }
        public abstract double CalculateArea();

        protected Shape(double sideLength)
        {
            SideLength = sideLength;
        }

        public virtual string ShapeStringify(Shape shape)
        {
            // extract class name from full assembly name
            // X.X.X.X.Circle -> objName: Circle
            // [^1] specifies last
            string objName = this.GetType().Name;
            return $"{objName} ({AmXd} ({SideLength})) ==> Surface area = {Math.Round(CalculateArea(), 2)}" +
                   $"\nI am a {objName} shape";
        }

        public override string ToString()
        {
            return ShapeStringify(this);
        }
    }
}