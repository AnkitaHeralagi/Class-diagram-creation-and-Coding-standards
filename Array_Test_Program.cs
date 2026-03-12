using System;

namespace ArrayTestProgram
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            string[] names = { "Ankita", "Akul", "Priya", "Amit", "Neha" };

            Console.WriteLine("Printing using FOR loop:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Index: " + i + "  Name: " + names[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Printing using FOREACH loop:");

            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}