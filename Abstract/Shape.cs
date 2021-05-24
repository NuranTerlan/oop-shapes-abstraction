using System;

namespace OOP_Tasks_Day1.Abstract
{
    public abstract class Shape
    {
        protected string IAmXD; 
        public double SideLength { get; set; }
        public abstract double CalculateArea();

        public virtual string ShapeStringify(Shape shape)
        {
            // extract class name from full assembly name
            // X.X.X.X.Circle -> objName: Circle
            // [^1] specifies last
            string objName = shape.GetType().ToString().Split('.')[^1];
            return $"{objName} ({IAmXD} ({SideLength})) ==> Surface area = {Math.Round(CalculateArea(), 2)}" +
                   $"\nI am a {objName} shape";
        }

        public override string ToString()
        {
            return ShapeStringify(this);
        }
    }
}