using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 20;

            if (temperatura > 25) {
                Console.WriteLine("Fa caldo!");
            } else if (temperatura<20) {
                Console.WriteLine("Fa freddo!");                
            } else {
                Console.WriteLine("Si sta bene!");                
            }

            Console.WriteLine((temperatura>25) ? "Fa caldo!" : "Si sta bene!");

            
        }
    }
}

