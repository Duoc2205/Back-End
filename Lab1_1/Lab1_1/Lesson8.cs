using System;

namespace Lab
{
    class Lesson8
    {
        public static void Run()
        {
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(" ");
                for(int j = 1; j <= 10 ; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
