using System;
using OOP_Tasks_Day1.Abstract;

namespace OOP_Tasks_Day1.Concrete
{
    public class Tetrahedron : ThreeD
    {
        public override double AreaVar { get; set; }
        public override double VolumeVar { get; set; }

        public Tetrahedron(int a) : base(a)
        {
        }

        public override double CalculateArea()
        {
            AreaVar = Math.Sqrt(3) * Math.Pow(Length, 2);
            return AreaVar;
        }

        public override double GetVolume()
        {
            VolumeVar = Math.Pow(Length, 3) / (6 * Math.Sqrt(2));
            return VolumeVar;
        }

        public override string ToString()
        {
            string objName = nameof(Tetrahedron);
            return $"{objName} (3D ({Length})) ==> Surface area = {CalculateArea()}, Volume = {GetVolume()}" +
                   $"\nI am a {objName} shape";
        }
    }
}