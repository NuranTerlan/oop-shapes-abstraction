namespace OOP_Tasks_Day1.Abstract
{
    public abstract class TwoD : IShape
    {
        public abstract double AreaVar { get; set; }
        public double Length { get; set; }

        // constructors

        protected TwoD(int a)
        {
            Length = a;
        }

        // Copy Constructor
        protected TwoD(TwoD twoDimensional)
        {
            Length = twoDimensional.Length;
        }

        public abstract override string ToString();

        public abstract double CalculateArea();
    }
}