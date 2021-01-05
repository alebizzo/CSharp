using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[5,5];
            int increment = 1;

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    intArray[a,b] = (b == 0) ? 0 : increment;
                    increment++;
                }
            }
            for (int c = 0; c < 5; c++)
            {
                for (int d = 0; d < 5; d++)
                {
                    Console.Write($"{intArray[c,d]} ");                    
                }
                Console.Write("\n");
            }

        }
    }
}
