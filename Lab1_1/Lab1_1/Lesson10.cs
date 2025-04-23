using System;

namespace Lab
{
    class Lesson10
    {
        public static void Run()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            
            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }
    }
}
