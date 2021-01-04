using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            double y = x;

            float x1 = 12000f;
            int y1 = (int)x1;

            int y2 = y1++;

            int x2 = Convert.ToInt32("12345");

            Console.WriteLine($"x={x}");
            Console.WriteLine($"x1={x1}");
            Console.WriteLine($"x2={x2}");
            Console.WriteLine($"y={y}");
            Console.WriteLine($"y1={y1}");
            Console.WriteLine($"y2={y2}");

        }
    }
}
