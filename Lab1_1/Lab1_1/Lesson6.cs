using System;

namespace Lab
{
    class Lesson6
    {
        public static void Run()
        {
            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (a < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
