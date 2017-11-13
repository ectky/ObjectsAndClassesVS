using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p1 = new Point();
            p1.X = input[0];
            p1.Y = input[1];
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p2 = new Point();
            p2.X = input[0];
            p2.Y = input[1];
            Console.WriteLine($"{CalcDistance(p1, p2):F3}");
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
