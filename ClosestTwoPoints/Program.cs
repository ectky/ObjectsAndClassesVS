using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();
                Point p = new Point();
                p.X = input[0];
                p.Y = input[1];
                points[i] = p;
            }
            FindClosestPoints(points);
        }

        public static void FindClosestPoints(Point[] points)
        {
            double min = double.MaxValue;
            Point p1 = new Point();
            Point p2 = new Point();
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double dis = CalcDistance(points[i], points[j]);
                    if (dis < min)
                    {
                        min = dis;
                        p1 = points[i];
                        p2 = points[j];
                    }

                }
            }

            Console.WriteLine($"{min:F3}");
            Console.WriteLine($"({p1.X}, {p1.Y})");
            Console.WriteLine($"({p2.X}, {p2.Y})");
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
