using System;

namespace Lab
{
    class Lesson1
    {
        public static void Run()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you are {age} years old");
        }
    }
}
