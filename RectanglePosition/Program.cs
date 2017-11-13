using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle r1 = ReadRec(input);
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle r2 = ReadRec(input);

            if (CalcDistance(r1, r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle ReadRec(int[] input)
        {
            Rectangle r = new Rectangle();
            r.Top = input[0];
            r.Left = input[1];
            r.Right = input[2] + r.Top;
            r.Bottom = input[3] + r.Left;
            return r;
        }

        public static bool CalcDistance(Rectangle r1, Rectangle r2)
        {
            return (r1.Left >= r2.Left &&
                r1.Right <= r2.Right &&
                r1.Top >= r2.Top &&
                r1.Bottom <= r2.Bottom);
        }
    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }
}
