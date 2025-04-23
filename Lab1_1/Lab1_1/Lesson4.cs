using System;

namespace Lab
{
    class Lesson4
    {
        public static void Run()
        {
            Console.Write("Enter integer: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

        }
    }
}
