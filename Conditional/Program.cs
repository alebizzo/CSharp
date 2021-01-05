using System;

namespace Conditional
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digita il valore:");
            string Valore = Console.ReadLine();

            if (Valore == "primo")
            {
                    Console.WriteLine("Hai digitato 'primo'");
            } else if (Valore == "secondo") {
                Console.WriteLine("Hai digitato 'secondo'");
            } else {
                Console.WriteLine("Hai digitato un valore non previsto");
            }

            switch (Valore)
            {
                case "primo":
                    Console.WriteLine("Hai digitato 'primo'");
                    break;
                case "secondo":
                    Console.WriteLine("Hai digitato 'secondo'");
                    break;
                default:
                    Console.WriteLine("Hai digitato un valore non previsto");
                    break;
            }
            
        }
    }
}

