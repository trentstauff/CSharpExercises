using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Consecutive Sequence
            Console.WriteLine();
            Console.WriteLine("Q1: Consecutive Sequence");
            Console.WriteLine();
            Console.WriteLine("5-4-3-2-1 -> " + Consecutive.isConsecutive("5-4-3-2-1"));
            Console.WriteLine("5-5-5-2-1 -> " + Consecutive.isConsecutive("5-5-5-2-1"));
            Console.WriteLine("5-6-7-8-9 -> " + Consecutive.isConsecutive("5-6-7-8-9"));
            Console.WriteLine("5-6-7-8-10 -> " + Consecutive.isConsecutive("5-6-7-8-10"));

            // 2. Duplicate Numbers
            Console.WriteLine();
            Console.WriteLine("Q2: Duplicate Numbers");
            Console.WriteLine();
            Console.WriteLine("2-2-2-2 -> " + Duplicate.duplicate("2-2-2-2"));
            Console.WriteLine("2-3-4-100 -> " + Duplicate.duplicate("2-3-4-100"));

            // Skipping 3

            // 4. Convert Sentence to Pascal Case
            Console.WriteLine();
            Console.WriteLine("Q4. Convert Sentence to Pascal Case");
            Console.WriteLine();
            Console.WriteLine("HELLO THIS IS A TEST! -> " + ToPascalCase.toPascalCase("HELLO THIS IS A TEST!"));
            Console.WriteLine("HELLO thisssss IS A TEST! -> " + ToPascalCase.toPascalCase("HELLO thisssss IS A TEST!"));
            Console.WriteLine("look at this sick result! -> " + ToPascalCase.toPascalCase("look at this sick result!"));
        }
    }
}
