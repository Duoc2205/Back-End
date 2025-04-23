using System;
using System.Transactions;

namespace Lab
{
    class Lesson5
    {
        public static void Run()
        {
            Console.Write("Enter number(1): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter numver(2): ");
            double b = double.Parse(Console.ReadLine());
            double c = a + b;
            double d = a * b;
            Console.WriteLine($"Sum = {c}");
            Console.WriteLine($"Product = {d}");
        }
    }
}
