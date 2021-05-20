using System;
using System.Collections;
using OOP_Tasks_Day1.Abstract;
using OOP_Tasks_Day1.Concrete;

namespace OOP_Tasks_Day1
{
    class Program
    {
        static int GetInt(int min = 0, int max = 100)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        static TwoD GenerateTwoDShape()
        {
            int random = GetInt(1, 4);
            switch (random)
            {
                case 1:
                    return new Circle(GetInt());
                case 2:
                    return new Rectangle(GetInt());
                case 3:
                    return new Triangle(GetInt());
                default: // never be executed
                    return null;
            }
        }

        static ThreeD GenerateThreeDShape()
        {
            int random = GetInt(1, 4);
            switch (random)
            {
                case 1:
                    return new Sphere(GetInt());
                case 2:
                    return new Cube(GetInt());
                case 3:
                    return new Tetrahedron(GetInt());
                default: // never be executed
                    return null;
            }
        }

        static void IterateArrayList(ArrayList al)
        {
            int count = 1;
            foreach (var obj in al)
            {
                Console.WriteLine("----------------------\n" +
                                  $"Shape [{count}] = {obj}" +
                                  "\n----------------------");
                count++;
            }
        }

        static void Main(string[] args)
        {
            var al = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    al.Add(GenerateTwoDShape());
                    continue;
                }

                al.Add(GenerateThreeDShape());
            }

            IterateArrayList(al);
        }
    }
}
