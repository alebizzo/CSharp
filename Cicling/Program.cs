using System;

namespace Cicling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Scegli il numero di iterazioni: ");
                string valore = Console.ReadLine();

                if (valore == "no")
                {
                    Console.WriteLine("ciao!");
                    break;
                }

                int righe = Convert.ToInt32(valore);

                for (int i = 1; i <= righe; i++)
                {
                    for (int ast = 1; ast <= i; ast++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }

            }

        }
    }
}
