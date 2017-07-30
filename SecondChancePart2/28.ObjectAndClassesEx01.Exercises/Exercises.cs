using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _28.ObjectAndClassesEx01.Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            var distance = CalculateDistance(p1, p2);
            Console.WriteLine($"Distance: {distance:f3}");
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;

            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
