using System;

namespace Lab
{
    class Lesson9
    {
        public static void Run()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"N = {result}");
        }
    }
}