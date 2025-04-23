using System;

namespace Lab
{
    class Lesson3
    {
        public static void Run()
        {
            Console.WriteLine("Enter C: ");
            double C = int.Parse(Console.ReadLine());
            double F = (C * 9 / 5) + 32;
            Console.WriteLine($"F = {F}");
        }
    }

}
