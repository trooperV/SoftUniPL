using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Intersection_Of_Circles
{
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
        public void Intersects(Circle c2)
        {
            double a = Center.X - c2.Center.X;
            double b = Center.Y - c2.Center.Y;

            double d = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));

            if (d <= Radius + c2.Radius) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point c1p = new Point() { X = arr1[0], Y = arr1[1] };
            Circle c1 = new Circle() { Center = c1p, Radius = arr1[2] };

            Point c2p = new Point() { X = arr2[0], Y = arr2[1] };
            Circle c2 = new Circle() { Center = c2p, Radius = arr2[2] };

            c1.Intersects(c2);
        }
    }
}
