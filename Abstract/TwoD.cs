namespace OOP_Tasks_Day1.Abstract
{
    public abstract class TwoD : Shape
    {
        protected TwoD(int a)
        {
            base.IAmXD = "2D";
            SideLength = a;
        }

        public abstract override double CalculateArea();
    }
}