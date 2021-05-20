namespace OOP_Tasks_Day1.Abstract
{
    public abstract class ThreeD : IShape
    {
        public abstract double AreaVar { get; set; }
        public abstract double VolumeVar { get; set; }
        public double Length { get; set; }

        // constructors

        protected ThreeD(int a)
        {
            Length = a;
        }

        // Copy Constructor
        protected ThreeD(ThreeD threeDimensional)
        {
            Length = threeDimensional.Length;
        }

        public abstract double CalculateArea();

        public abstract double GetVolume();

        public abstract override string ToString();
    }
}