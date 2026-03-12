using System;

namespace LoopTestProgram
{
    class LoopTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing using FOR loop:");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ankita");
            }
            Console.WriteLine();

            Console.WriteLine("Printing using WHILE loop:");

            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("Ankita");
                j++;
            }
        }
    }
}