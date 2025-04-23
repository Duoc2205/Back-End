using System;

namespace Lab
{
    class Lesson2
    {
        public static void Run()
        {
            Console.Write("Enter length: ");
            int Length = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int Width = int.Parse(Console.ReadLine());
            int Area = Length * Width;
            Console.Write($"Enter area: {Area}");
        }
    }
}
