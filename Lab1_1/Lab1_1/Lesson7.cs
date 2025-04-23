using System;
using System.ComponentModel.Design;

namespace Lab
{
    class Lesson7
    {
        public static void Run()
        {
            Console.Write("Enter Year: ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
            
        }
    }
}
